using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Antlr.Runtime.Tree;
using CompilerConsole.Parser.Exceptions;
using CompilerConsole.Parser.Interfaces;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.AbstractNodes;
using CompilerConsole.Parser.Utils;
using Node = CompilerConsole.Parser.Nodes.AbstractNodes.Node;

namespace CompilerConsole.Parser.Parsers.Expression {
#region Enums
    enum ExpressionTokens {
        Assign,
        Sum,
        Div,
        Sub,
        Mult
    }

     enum NodeEnum : int
    {
        Left = 0,
        Right = 1
    }

#endregion
    public static partial class ExpressionsParser {

        private static Dictionary<string, ExpressionTokens> _tokens;

        static ExpressionsParser() {
            _tokens = new Dictionary<string, ExpressionTokens>();
            _tokens.Add("=", ExpressionTokens.Assign);
            _tokens.Add("+", ExpressionTokens.Sum);
            _tokens.Add("-", ExpressionTokens.Sub);
            _tokens.Add("/", ExpressionTokens.Div);
            _tokens.Add("*", ExpressionTokens.Mult);
        }

        public static Node ParseAssign(ITree tree, BodyTable wrapTable, Node leftNode) {
            if (tree.ChildCount == 0) {
                throw new Exceptions.InvalidOperationException($"Ошибка применения операции '=' с узлом {leftNode.Name}. Справа должно быть выражение");
            }
            if (!(leftNode is VariableNode)) {
                throw new Exceptions.InvalidOperationException($"Ошибка применения операции '=' с узлом {leftNode.Name}. Попытка прмиенения операции равно к {leftNode.GetType().Name}");
            }

            Node rightExpr =  ExpressionRecParser(tree.GetChild(0), wrapTable);

            return new Nodes.Expression(leftNode, rightExpr,"=");

        }


        private static Node ParseNew(ITree tree, BodyTable table) {

            if (tree.ChildCount == 0) {
                return null;
            }

            string type = tree.GetChild(0).Text;
            if (String.CompareOrdinal(tree.Text, "NEW_ARR") == 0) {
                if (!Node.IsBaseType(type)) {
                    var temp = BodyTable.FindHeapNode(type, table);
                    if (temp == null) {
                        throw  new NodeNotFoundException($"Тип {type} не найден");
                    }
                }

                var expr = ExpressionRecParser(tree.GetChild(1), table);

                if (String.CompareOrdinal(expr.DataType, "int") != 0) {
                    throw new InvalidTypeCastException($"При инициаллизации массива не удалось преобразовать кол-во элементов к типу int");
                }

                return new ArrayNode("TEMP", type, table, expr);
            }

            if (String.CompareOrdinal(tree.Text, "NEW_CLASS") == 0)
            {
                if (Node.IsBaseType(type)) {
                    throw new NodeNotFoundException($"Тип {type} не найден");
                }

                var temp = BodyTable.FindHeapNode(type, table);

                if (temp == null) {
                    throw new NodeNotFoundException($"Тип {type} не найден");
                }

                if (tree.ChildCount <2) {
                    return new HeapVariableNode("TEMP", type, table, null);
                }

                var expr = ExpressionRecParser(tree.GetChild(1), table);

                return new HeapVariableNode("TEMP", type, table, expr);
            }
            return null;
        }

        public static Node ExpressionRecParser(ITree tree, BodyTable table) {
            if (tree == null) {
                //ОООЧЕНЬ маловероятная ситуация. Даже представить себе такой не могу
                return null;
            }

            //Здесь будет проверка на узел. отличный от классического узла в мат выражении

            var t = ParseNew(tree, table);
            if (t != null) {
                return t;
            }

            if (CallParser.Instanience.IsCall(tree)) {
               return CallParser.Instanience.ParseCall(tree, table);
            }

            if (IsObjectCall(tree.Text)) {
                //Если мы вызываем объект, то надо распарсить иначе
                var obj = tree.GetChild((int) NodeEnum.Left);   //Получаем левого ребенка. Это объект к которому посылается сообщение
                var selector = tree.GetChild((int) NodeEnum.Right); //Получаем правый узел

                //Првоеряем, объявляен ли такой объект или нет
                var variable = BodyTable.FindVariable(obj.Text, table);
                if (variable == null) {
                    throw new NodeNotFoundException($"Переменная с именем {obj.Text} не найдена");
                }

                //если переменная не объект
                if (!variable.IsObject()) {
                    throw new NodeNotFoundException($"Переменная с именем {variable.Name} с типом {variable.DataType} не является сложным типом");
                }

                Node heapNode = BodyTable.FindHeapNode(variable.DataType, table);

                if (heapNode == null) {
                    throw new InvalidTypeCallException($"Класс {variable.DataType} не найден.");
                }

                //Пока будем брать только переменные
                var objVar = BodyTable.FindVariable(selector.Text, table);

                if (objVar == null) {
                    throw new NodeNotFoundException($"Переменная с именем {tree.Text} не найдена");
                }

                return objVar;

            }

            //Если мы дошли до листа
            if (tree.ChildCount == 0) {

                StackVariableNode tempVar = TryGetVariableFromLiteral(tree.Text);
                if (tempVar != null) {
                    return tempVar;
                }

                if (IsVariable(tree)) {
                    VariableNode node = BodyTable.FindVariable(tree.Text, table);
                    if (node == null) {
                        throw new NodeNotFoundException($"Переменная с именем {tree.Text} не найдена");
                    }
                    return node;
                }


            }
            //если мы дошли сюда, то у нас какое-то математическое выражение 
            Node rightNode =  ExpressionRecParser(tree.GetChild((int)NodeEnum.Right), table);
            Node lefttNode = ExpressionRecParser(tree.GetChild((int)NodeEnum.Left), table);
            var expr = new Nodes.Expression(rightNode, lefttNode, tree.Text);
            if (!expr.IsOperationValid()) {
                throw new InvalidTypeCastException($"невозможно привести тип {expr.Node1Type} к типу {expr.Node2Type}");
            }
            return new Nodes.Expression(rightNode, lefttNode, tree.Text);

        }

        /// <summary>
        /// Проверяет, является ли имя узла переменной
        /// (Парсит по регулярному выражению ^[aA-zZ]+$
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        private static bool IsVariable(ITree tree) {
            Regex regEx = new Regex("^[aA-zZ]+$");
            return regEx.IsMatch(tree.Text);
        }
        /// <summary>
        /// Проверяет, является ли узел вызовом компанента объекта
        /// Значение узла должно быть ->
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool IsObjectCall(string text) {

            return String.CompareOrdinal(text, "->") == 0;
        }

        private static StackVariableNode TryGetVariableFromLiteral(string text) {
            if (String.CompareOrdinal(text, "false") == 0 || String.CompareOrdinal(text, "true") == 0) {
                return StackVariableNode.CreateTempNode("bool");
            }

            Regex regEx = new Regex("^\"[aA-zZ]+\"$");
            if (regEx.IsMatch(text)) {
                //Строка
                return StackVariableNode.CreateTempNode("string");
            }

            regEx = new Regex("^\'[aA-zZ]\'$");
            if (regEx.IsMatch(text)) {
                //Символ
                return StackVariableNode.CreateTempNode("char");
            }

            regEx = new Regex("^[0-9]+$");
            if (regEx.IsMatch(text)) {
                //Целое
                return StackVariableNode.CreateTempNode("int");
            }

            regEx = new Regex("^[0-9]+\\.[0-9]+$");
            if (regEx.IsMatch(text))
            {
                //Дробное
                return StackVariableNode.CreateTempNode("double");
            }

            return null;
        }

    }
}
