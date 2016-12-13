using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using Antlr.Runtime.Tree;
using CompilerConsole.Parser.Exceptions;
using CompilerConsole.Parser.Nodes;
using Type = CompilerConsole.Parser.Nodes.Type;

namespace CompilerConsole.Parser {
    public partial class Parser {
        /// <summary>
        /// Расчитано на то, что Itree = VAR_DECL
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="body"></param>
        private List<VariableNode> ParseVarDecl(ITree tree, Body body) {
            ITree type = tree.GetChild(0);

            if (!this.IsType(type.Text)) {
                throw new UndefinedTypeException($"Типа {type.Text} не существует");
            }
            List<VariableNode> variables = new List<VariableNode>();
            Type varType;
            if (tree.Text == "ARR_DECL") {
                varType = this.GetArrType(type.Text);
            }
            else {
                varType = this.GetVarType(type.Text);
            }


            for (int i = 1; i < tree.ChildCount; i++) {
                if (this.IsType(tree.GetChild(i).Text)) {
                    throw new UsedKeyWorldExceptioncs(
                        $"Для имени переменной было использовано ключевое слово {tree.GetChild(0).Text}");
                }

                if (body.FindNodeByName<VariableNode>(tree.GetChild(i).Text) != null) {
                    throw new NodeAlreadyExistException($"Переменная с именем {tree.GetChild(i).Text} объявлена ранее");
                }

                variables.Add(new VariableNode(tree.GetChild(i).Text, varType));
            }

            return variables;
        }

        public MethodNode ParseMethodDeclare(ITree tree, Body body) {
            string methodName = tree.GetChild(1).Text;

            if (Body.FindNodeByName<MethodNode>(methodName, body) != null) {
                throw new NodeAlreadyExistException($"Метод с именем {methodName} уже объявлен");
            }

            Type returnType;
            if (tree.GetChild(0).Text == "RET_TYPE_SINGLE") {
                if (tree.GetChild(0).GetChild(0).Text == "void") {
                    returnType = Type.Void;
                }
                else {
                    returnType = this.GetVarType(tree.GetChild(0).GetChild(0).Text);
                }
            }
            else if (tree.GetChild(0).Text == "RET_TYPE_ARR") {
                returnType = this.GetArrType(tree.GetChild(0).GetChild(0).Text);
            }
            else {
                throw new DataException(
                    $"Ошибка при парсинге метода {methodName} - не верно указано возвращаемое значение {tree.GetChild(0)}");
            }

            List<VariableNode> args = new List<VariableNode>();
            ITree argsNode = tree.GetChild(2);

            var bodyTable = new Body(new List<Node>(), body);
            for (int i = 0; i < argsNode.ChildCount; i++) {
                VariableNode varNode;
                varNode = this.ParseVarDecl(argsNode.GetChild(i), bodyTable)[0];
                args.Add(varNode);
            }
            var methodNode = new MethodNode(methodName, returnType, bodyTable, args);
            return methodNode;
        }

        public ArrNode PareArrDecl(ITree tree, Body body) {
            ITree type = tree.GetChild(0);
            ITree name = tree.GetChild(1);
            ITree length = tree.GetChild(2);

            Type typeToken = this.GetArrType(type.Text);

            if (body.FindNodeByName<VariableNode>(name.Text) != null) {
                throw new NodeAlreadyExistException($"Переменная с именем {name.Text} объявлена ранее");
            }

            Node arrLength = this.ParsExpr(length, body);
            if (arrLength.DataType != Type.VarInt) {
                throw new BadExpressionException($"При создании массива ошибка с типом разерности. Нужен VarInt а был {arrLength.DataType} при создании массива {name.Text} ");
            }
            return new ArrNode(name.Text, typeToken, arrLength);
        }


        public Node ParseExpression(ITree tree, Body body, ExprToken exprToken) {
            switch (exprToken) {
                case ExprToken.IsEqual:
                    break;
                case ExprToken.IsLess:
                    break;
                case ExprToken.IsMore:
                    break;
                case ExprToken.IsLessOrEqual:
                    break;
                case ExprToken.IsMoreOrEqual:
                    break;
                case ExprToken.Add:
                    break;
                case ExprToken.Sub:
                    break;
                case ExprToken.Mult:
                    break;
                case ExprToken.Div:
                    break;
                case ExprToken.Conj:
                    break;
                case ExprToken.Dij:
                    break;
                case ExprToken.Neg:
                    break;
                case ExprToken.Ass:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(exprToken), exprToken, null);
            }
            return null;
        }

        /// <summary>
        /// Подразумевается получить tree в виде 
        ///     ExprToken
        ///       |   |
        ///     Node Node
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="body"></param>
        /// <param name="exprToken"></param>
        /// <returns></returns>
        public Node ParsExpr(ITree tree, Body body) {
            if (tree == null) {
                Console.WriteLine("TREE == NULL IN PARSEEXPR FUCK!");
                return null;
            }

            Literals lit = this.GetLiterals(tree.Text);
            if (lit != null) {
                return lit;
            }

            Token token;

            if (this._tokensDictionary.TryGetValue(tree.Text, out token)) {
                return this.ActionParse(token, tree, body);
            }

            #region Variable
            if (this.IsVariable(tree)) {
                VariableNode variable = Body.FindNodeByName<VariableNode>(tree.Text, body);

                if (variable == null) {
                    throw new NodeNotfoundException(
                        $"Переменной с именем {tree.Text} не существует в текущем контексте ");
                }
                return variable;
            }
            #endregion

            #region Expression

            if (this.IsExpr(tree.Text)) {
                ITree leftNode = tree.GetChild(0);
                ITree rightNode = tree.GetChild(1);
                Node left = this.ParsExpr(leftNode, body);
                Node right = this.ParsExpr(rightNode, body);
                ExprToken t = this.GetExpr(tree.Text);
                var expr = new Expression(left, right, t);

                if (!expr.IsValid) {
                    throw new BadExpressionException(
                        $"Произошла ошибка при разборе выражения {t} между типами {left.DataType} и {right.DataType}");
                }
                return expr;
            }
            return null;
            #endregion
        }

        public ArrCall ParseArrCall(ITree tree, Body body) {
            ITree arrName = tree.GetChild(0);
            ITree callindex = tree.GetChild(1);

           var arrNode =  Body.FindNodeByName<ArrNode>(arrName.Text, body);

            if (arrNode == null) {
                throw new NodeNotfoundException($"Массив с именем {arrName.Text} не найден в текущем контексте");
            }

            ArrCall res = new ArrCall(arrNode);
            res.Index = this.ParsExpr(callindex, body);
            return res;
        }

        public MethCall ParseMethCall(ITree tree, Body body) {
            ITree methName = tree.GetChild(0);
            ITree args = tree.GetChild(1);

            MethodNode method = Body.FindNodeByName<MethodNode>(methName.Text, body);

            if (method == null)
            {
                throw new NodeNotfoundException($"Метод с именем {methName.Text} не найден в текущем контексте");
            }
            List<Node> argList = new List<Node>();
            for (int i = 0; i < args.ChildCount; i++) {
                argList.Add(this.ParsExpr(args.GetChild(i), body));
            }

            if (argList.Count != method.ArgList.Count) {
                throw new NodeNotfoundException($"Метод с именем {method.Name} содержит другое кол-во вргументов ");
            }

            for (int i = 0; i < argList.Count; i++) {
                if (argList[i].DataType != method.ArgList[i].DataType) {
                    throw new NodeNotfoundException($"Метод с именем {method.Name} не содержит аргументы с такими типами ");
                }
            }

            MethCall call = new MethCall(method);
            call.SendArgs = argList;

            return call;
        }

        private bool IsVariable(ITree tree) {
            Regex regEx = new Regex("^[aA-zZ]+$");
            return regEx.IsMatch(tree.Text);
        }

        private Node ActionParse(Token token, ITree treeNode, Body body) {
            switch (token) {
                case Token.ARR_CALL:
                    var t1 =  this.ParseArrCall(treeNode, body);
                    body.Nodes.Add(t1);
                    return t1;
                case Token.METH_CALL:
                    var t2 =  this.ParseMethCall(treeNode, body);
                    body.Nodes.Add(t2);
                    return t2;
                case Token.INC:
                    break;
                case Token.DEC:
                    break;
                   
            }
            throw new UndefinedTokenException($"При разборе выражения использовался токен {treeNode.Text}");
        }

        private Literals GetLiterals(string text)
        {
            if (String.CompareOrdinal(text, "false") == 0 || String.CompareOrdinal(text, "true") == 0)
            {
                return new Literals(Type.VarBool, bool.Parse(text));
            }

            Regex regEx = new Regex("^\"[aA-zZ]+\"$");
            if (regEx.IsMatch(text))
            {
                //Строка
                return new Literals(Type.VarString, text);
            }

            regEx = new Regex("^\'[aA-zZ]\'$");
            if (regEx.IsMatch(text))
            {
                //Символ
                return new Literals(Type.VarChar, char.Parse(text));
            }

            regEx = new Regex("^[0-9]+$");
            if (regEx.IsMatch(text))
            {
                //Целое
                return new Literals(Type.VarInt, int.Parse(text));
            }

            regEx = new Regex("^[0-9]+\\.[0-9]+$");
            if (regEx.IsMatch(text))
            {
                //Дробное
                return new Literals(Type.VarFloat, float.Parse(text));
            }

            return null;
        }


    }
}