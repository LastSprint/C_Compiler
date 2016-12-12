using System;
using System.Collections.Generic;
using Antlr.Runtime.Tree;
using CompilerConsole.Parser.Exceptions;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.AbstractNodes;
using CompilerConsole.Parser.Parsers.Expression;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Parsers {
    enum CallToken {
        CallArr,
        CallMeth,
        CallObj,
        CallAss
    }


    class CallParser {

        #region Singleton

        private static CallParser _instantience;

        public static CallParser Instanience {
            get {
                if (_instantience == null) {
                    return new CallParser();
                }
                return _instantience;
            }
        }

        #endregion


        private CallParser() {
            this.CallTokensDict = new Dictionary<string, CallToken>();
            this.CallTokensDict.Add("ARR_CALL", CallToken.CallArr);
            this.CallTokensDict.Add("METH_CALL", CallToken.CallMeth);
            this.CallTokensDict.Add("=", CallToken.CallAss);
            this.CallTokensDict.Add("->", CallToken.CallObj);
        }

        /// <summary>
        /// Словарь, содержащий токены по ключам - именам узлов дерева, возвращаемого ANTLR
        /// </summary>
        public Dictionary<string, CallToken> CallTokensDict { get; private set; }

        /// <summary>
        /// Проверяет, является ли данный узел узлом вызова
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public bool IsCall(ITree tree) {
            bool result = false;

            foreach (var key in this.CallTokensDict.Keys) {
                result = result || String.CompareOrdinal(tree.Text, key) == 0;
            }
            return result;
        }

        public Node ParseCall(ITree tree, BodyTable table) {
            CallToken token;
            this.CallTokensDict.TryGetValue(tree.Text, out token);
            //Сто пудов извлечется        
            var temp = this.MakeAction(tree, table, token);
            table.AddNode(temp);
            return temp;
        }

        private Node MakeAction(ITree tree, BodyTable table, CallToken token) {
            switch (token) {
                case CallToken.CallArr: {
                    return this.ArrCallParse(tree, table);
                }
                case CallToken.CallAss: {
                    return this.AssParse(tree, table);
                }
                case CallToken.CallMeth: {
                    return this.MethodCallParse(tree, table);
                }
                case CallToken.CallObj: {
                    return this.ObjectCallParse(tree, table);
                }
            }
            return null;
        }


        private Node MethodCallParse(ITree tree, BodyTable table) {
            var method = BodyTable.FindMethod(tree.GetChild(0).Text, table);
            if (method == null) {
                throw new NodeNotFoundException($"Метода с именем {tree.GetChild(0).Text} не существует");
            }

            if (method.Args.Count == 0) {
                //Если совпадают аргументы
                if (tree.ChildCount == 1) {
                    return method;
                }
                else {
                    //Аргументы не совпадают
                    throw new NodeNotFoundException(
                        $"У метода с именем {method.Name} другая сигнатура. У него вообще не аргументов");
                }
            }
            else {
                //Если совпадают аргументы
                if (tree.ChildCount > 1) {
                    IList<Node> callArgsNodes = new List<Node>();
                    ITree argsTree = tree.GetChild(1);
                    for (int i = 0; i < argsTree.ChildCount; i++) {
                        callArgsNodes.Add(ExpressionsParser.ExpressionRecParser(argsTree.GetChild(i), table));
                    }

                    if (callArgsNodes.Count != method.Args.Count) {
                        throw new NodeNotFoundException(
                            $"У метода с именем {method.Name} другая сигнатура. Не совпадает кол-во аргументов");
                    }

                    for (int i = 0; i < callArgsNodes.Count; i++) {
                        if (String.CompareOrdinal(callArgsNodes[i].DataType, method.Args[i].DataType) != 0) {
                            throw new NodeNotFoundException(
                                $"У метода с именем {method.Name} другая сигнатура. Не совпадают типы аргументов");
                        }
                    }

                    return new MethodCallNode(method, table, callArgsNodes);
                }
                else {
                    //Аргументы не совпадают
                    throw new NodeNotFoundException(
                        $"У метода с именем {method.Name} другая сигнатура. У метода есть аргументы");
                }
            }
        }

        private Node ObjectCallParse(ITree tree, BodyTable table) {
            if (tree.ChildCount > 2) {
                throw new ImvalidParseException(@"Допущена синтаксическя ошибка");
            }

            ITree obj = tree.GetChild(0); //Объект, которому посылается сообщение
            ITree leftExpr = tree.GetChild(1);

            var node = BodyTable.FindVariable(obj.Text, table);
            if (node == null) {
                throw new NodeNotFoundException($"Переменной с именем {obj.Text} не существует в ткущем контексте");
            }
            BodyNode cls = BodyTable.FindHeapNode(node.DataType, table) as BodyNode;
            CallToken token;
            if (this.CallTokensDict.TryGetValue(leftExpr.Text,out token)) {
               return this.MakeAction(leftExpr, cls.Body, token);
            }
            else {
                VariableNode vNode = BodyTable.FindVariable(leftExpr.Text, cls.Body);
                if (vNode == null) {
                    throw new NodeNotFoundException($"Сущность {node.DataType} не содержит переменной с именем {leftExpr.Text}");
                }
                return vNode;
                //Это переменная
            }
        }

        private ArrCallNode ArrCallParse(ITree tree, BodyTable table) {
            ITree arrName = tree.GetChild(0);
            ITree elementIndex = tree.GetChild(1);

            var arr = BodyTable.FindNode<ArrayNode>(arrName.Text, table);

            if (arr == null) {
                throw new NodeNotFoundException($"Переменная с именем {arrName.Text} не существует в текущем контексте");
            }

            Node expr = Expression.ExpressionsParser.ExpressionRecParser(elementIndex, table);

            if (tree.ChildCount == 3) {
                throw new NotImplementedException(@"Присвоение переменной элементу ассива пока не написано. Приношу извинения за временные неудобства");
                ITree assNode = tree.GetChild(2);
                Node assExpr = ExpressionsParser.ExpressionRecParser(assNode.GetChild(0), table);
            }
            return new ArrCallNode(arr, expr, table);
        }
        /// <summary>
        /// АХТУНГ!!!!!
        /// КОСТЫЛЬ!!!!!
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        private Node AssParse(ITree tree, BodyTable table)
        {
            ITree leftNode = tree.GetChild(0);
            ITree rightNode = tree.GetChild(1);

            if (leftNode.Text == "ARR_CALL") {
                ArrCallNode left = this.ArrCallParse(leftNode, table);
                left.AssignExpression = ExpressionsParser.ParseAssign(tree, table, left);
                return left;
            }
            //Вроде только так может быть

            VariableNode node = BodyTable.FindNode<VariableNode>(leftNode.Text, table);

            if (node == null) {
                throw new NodeNotFoundException($"Переменная с именем {leftNode.Text} не существует в текущем контексте");
            }

            node.AssignExpression = ExpressionsParser.ParseAssign(tree, table, node);
            return node;
        }
    }
}


