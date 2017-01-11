using System;
using System.Collections.Generic;
using System.Text;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.BodyNodes;
using CompilerConsole.Parser.Nodes.CallNode;
using Type = CompilerConsole.Parser.Nodes.Type;

namespace CompilerConsole.Parser {
    public class Optimizator {

        private class RemovedElement {

            public BodyNode Body { get; set; }
            public VariableNode VarNode { get; set; }

            public RemovedElement(BodyNode body, VariableNode varNode) {
                this.Body = body;
                this.VarNode = varNode;
            }
        }

        private BodyNode _mainBody;

        public Optimizator(Body mainBody) {
            this._mainBody = new MethodNode("*temp", Type.NotAType, mainBody, null);
        }

        public void Optimize() {
            this.RecOptimizator(this._mainBody);
            this.DeleteUnusedMethods();
            this.DeleteUnusedVariables();
        }

        private void RecOptimizator(Node node) {
            this.Action(node);
        }

        #region Optimize expression

        private void Action(Node node) {
            if (node is BodyNode) {
                var body = (BodyNode) node;
                foreach (var nod in body) {
                    this.RecOptimizator(nod);
                }
            }
            else if (node is Expression) {
                var flag = false;
                this.OptimizeExpression(node, ref flag);
            }
            else if (node is MethCall) {
                foreach (var sendArg in (node as MethCall).SendArgs) {
                    var flag = false;
                    this.OptimizeExpression(sendArg, ref flag);
                }
            }
        }

        private T CastToType<T>(object obj) {
            return (T) obj;
        }

        private Node OptimizeExpression(Node node, ref bool cantComplite) {
            if (cantComplite) {
                return node;
            }

            if (node is Expression) {
                var expression = (Expression) node;

                if (expression.ExprToken == ExprToken.Ass) {
                    expression.RightNode = this.OptimizeExpression(expression.RightNode, ref cantComplite);
                    cantComplite = true;
                    return null;
                }

                if (expression.ExprToken == ExprToken.Neg) {
                    cantComplite = false;
                    return node;
                }

                Node leftExpr = null;
                bool flagComplite = true;
                if (expression.LeftNode != null) {
                    leftExpr = this.OptimizeExpression(expression.LeftNode, ref cantComplite);
                }

                Node rightExpr = null;
                if (expression.ExprToken != ExprToken.Ass && expression.RightNode != null) {
                    rightExpr = this.OptimizeExpression(expression.RightNode, ref cantComplite);
                }

                if (!flagComplite) {
                    cantComplite = true;
                    return node;
                }

                if (!(leftExpr is Literals)) {
                    return new Expression(leftExpr, this.OptimizeExpression(rightExpr, ref cantComplite),
                        expression.ExprToken);
                }

                if (!(rightExpr is Literals)) {
                    return new Expression(this.OptimizeExpression(leftExpr, ref cantComplite), rightExpr,
                        expression.ExprToken);
                }

                var leftLiteral = (Literals) leftExpr;
                var rightLiteral = (Literals) rightExpr;
                cantComplite = false;
                switch (leftLiteral.DataType) {
                    case Type.VarInt: {
                        var left = this.CastToType<int>(leftLiteral.Value);
                        var right = this.CastToType<int>(rightLiteral.Value);

                        return new Literals(Type.VarInt,
                            this.ExecuteExpressionForInteger(left, right, expression.ExprToken));
                    }

                    case Type.VarChar: {
                        var left = this.CastToType<char>(leftLiteral.Value);
                        var right = this.CastToType<char>(rightLiteral.Value);
                        return new Literals(Type.VarChar,
                            this.ExecuteExpressionForChar(left, right, expression.ExprToken));
                    }

                    case Type.VarBool: {
                        var left = this.CastToType<bool>(leftLiteral.Value);
                        var right = this.CastToType<bool>(rightLiteral.Value);
                        return new Literals(Type.VarBool,
                            this.ExecuteExpressionForBool(left, right, expression.ExprToken));
                    }

                    case Type.VarString: {
                        var left = this.CastToType<string>(leftLiteral.Value);
                        var right = this.CastToType<string>(rightLiteral.Value);
                        return new Literals(Type.VarString,
                            this.ExecuteExpressionForString(left, right));
                    }
                }
            }
            if (node is Literals) {
                return node;
            }

            if (node is VariableNode) {
                return node;
            }

            return node;
        }

        private object ExecuteExpressionForInteger(int left, int right, ExprToken token) {
            switch (token) {
                case ExprToken.IsEqual:
                    return left == right;
                case ExprToken.IsLess:
                    return left < right;
                case ExprToken.IsMore:
                    return left > right;
                case ExprToken.IsLessOrEqual:
                    return left <= right;
                case ExprToken.IsMoreOrEqual:
                    return left >= right;
                case ExprToken.Add:
                    return left + right;
                case ExprToken.Sub:
                    return left - right;
                case ExprToken.Mult:
                    return left*right;
                case ExprToken.Div:
                    return left/right;
            }
            return null;
        }

        private object ExecuteExpressionForChar(char left, char right, ExprToken token) {
            switch (token) {
                case ExprToken.IsEqual:
                    return left == right;
                case ExprToken.IsLess:
                    return left < right;
                case ExprToken.IsMore:
                    return left > right;
                case ExprToken.IsLessOrEqual:
                    return left <= right;
                case ExprToken.IsMoreOrEqual:
                    return left >= right;
                case ExprToken.Add:
                    return left + right;
                case ExprToken.Sub:
                    return left - right;
            }
            return null;
        }

        private object ExecuteExpressionForBool(bool left, bool right, ExprToken token) {
            switch (token) {
                case ExprToken.Conj:
                    return left && right;
                case ExprToken.Dij:
                    return left || right;
                case ExprToken.Neg:
                    break;
            }
            return null;
        }

        private object ExecuteExpressionForString(string left, string right) {
            return left == right;
        }

        #endregion

        private void DeleteUnusedMethods() {
            List<MethodNode> methods = new List<MethodNode>();

            foreach (var node in this._mainBody) {
                if (node is MethodNode) {
                    methods.Add(node as MethodNode);
                }
            }
            List<MethodNode> toRemove = new List<MethodNode>();
            foreach (var method in methods) {
                var flag = false;
                foreach (var node in this._mainBody) {
                    if (!(node is MethodNode) || node.Name == method.Name) continue;
                    var meth = node as MethodNode;
                    //Проходим по телу метода и ищем вызовы методов
                    foreach (var expr in meth) {
                        if (!(expr is MethCall)) continue;

                        var call = (MethCall) expr;

                        if (call.Method.Name != method.Name) continue;
                        flag = true;
                        break;
                    }
                    if (flag) {
                        break;
                    }
                }

                if (flag) continue;

                if (method.Name != "main" && method.Name != "Main" && method.MethodType != MethodType.Libr) {
                    toRemove.Add(method);
                }
            }

            StringBuilder deletedMethods = new StringBuilder($"Кол-во удаленных методов: {toRemove.Count}{Environment.NewLine}");

            foreach (var node in toRemove) {
                deletedMethods.AppendLine($"\t{node.Name}");
                this._mainBody.Body.Nodes.Remove(node);
            }

            Console.WriteLine(deletedMethods.ToString());

        }

        private void DeleteUnusedVariables() {
            List<RemovedElement> toRemove = new List<RemovedElement>();

            foreach (var node in this._mainBody) {
                if (node is BodyNode) {
                    var body = (BodyNode) node;

                    foreach (var elem in body) {
                        if (!(elem is VariableNode)) continue;

                        var varNode = (VariableNode) elem;

                        if (!varNode.IsUsed) {
                            toRemove.Add(new RemovedElement(body, varNode));
                        }
                    }

                }

                if (node is VariableNode) {
                    var varNode = (VariableNode)node;

                    if (!varNode.IsUsed)
                    {
                        toRemove.Add(new RemovedElement(this._mainBody, varNode));
                    }
                }

            }

            StringBuilder strb = new StringBuilder($"Кол-во удаленных переменных: {toRemove.Count}{Environment.NewLine}");

            foreach (var removedElement in toRemove) {
                strb.AppendLine("\t"+removedElement.VarNode.Name);
                removedElement.Body.Body.Nodes.Remove(removedElement.VarNode);
            }

            Console.WriteLine(strb.ToString());

        }

    }
}