using System;
using System.Collections.Generic;
using System.Data;
using Antlr.Runtime.Tree;
using CompilerConsole.Parser.Exceptions;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.AbstractNodes;
using CompilerConsole.Parser.Parsers.Expression;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser {
    internal static class DeclareNodeParser {
        /// <summary>
        /// Парсит узел с токеном class. Подразумевается, что мы получаем узел - корень класса (с текстом class)
        /// Дерево выглядит так:
        ///      __class__
        ///     |         |
        ///  ClassName   BODY
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="wrapTable"></param>
        /// <returns></returns>
        public static ClassNode ParseClassDeclare(ITree tree, BodyTable wrapTable) {
            string className = tree.GetChild(0).Text;

            if (wrapTable.FindNode<ClassNode>(className) != null) {
                throw new NodeAlreadyExistException($"Класс с именем {className} уже существует");
            }

            BodyTable bodyTable = new  BodyTable(new List<Node>(), wrapTable);
            ClassNode classNode = new ClassNode(className, bodyTable, wrapTable);
            wrapTable.AddNode(classNode);
            return classNode;
        }

        public static VariableNode ParseVariableNodeDeclare(ITree tree, BodyTable wrapTable) {
            string varType = tree.GetChild(0).Text;
            string varName = tree.GetChild(1).Text;

            if (BodyTable.FindVariable(varName, wrapTable) != null) {
                //Если переменная с таким именем уже существует
                throw new NodeAlreadyExistException($"Переменная с именем {varName} уже существует");
            }

            VariableNode varNode;
            bool notANew = String.CompareOrdinal(tree.Text, "ARR_DECL") == 0;
            if (Node.IsBaseType(varType) && !notANew) {
                varNode = new StackVariableNode(varName, varType, wrapTable);
            }
            else {
                if (!Node.IsBaseType(varType)) {
                    if (BodyTable.FindHeapNode(varType, wrapTable) == null) {
                        throw new NodeNotFoundException($"Типа с именем {varType} не существует в текущем контексте");
                    }
                }
                if (notANew) {
                    varNode = new ArrayNode(varName, varType, wrapTable);
                }
                else {
                    varNode = new HeapVariableNode(varName, varType, wrapTable);
                }
                
            }

            if (tree.ChildCount == 3) {
                Node node = ExpressionsParser.ParseAssign(tree.GetChild(2), wrapTable, varNode);
                varNode.AssignExpression = node;

            }
            wrapTable.AddNode(varNode);
            return varNode;
        }



        public static MethodNode ParseMethodDeclare(ITree tree, BodyTable wrapTable) {
            string methodName = tree.GetChild(1).Text;

            if (wrapTable.FindNode<MethodNode>(methodName) != null) {
                throw new NodeAlreadyExistException($"Метод с именем {methodName} уже объявлен");
            }

            string returnType;
            if (tree.GetChild(0).Text == "RET_TYPE_SINGLE") {
                returnType = tree.GetChild(0).GetChild(0).Text;
            }
            else if (tree.GetChild(0).Text == "RET_TYPE_ARR") {
                returnType = tree.GetChild(0).GetChild(0).Text;
            }
            else {
                throw new DataException(
                    $"Ошибка при парсинге метода {methodName} - не верно указано возвращаемое значение {tree.GetChild(0)}");
            }

            IList<VariableNode> args = new List<VariableNode>();
            ITree argsNode = tree.GetChild(2);
            var bodyTable = new BodyTable(new List<Node>(), wrapTable);
            for (int i = 0; i < argsNode.ChildCount; i++) {

                VariableNode varNode;
                    varNode = ParseVariableNodeDeclare(argsNode.GetChild(i), bodyTable);
                args.Add(varNode);
            }
            var methodNode = new MethodNode(methodName, bodyTable, wrapTable, returnType, args);
            wrapTable.AddNode(methodNode);
            return methodNode;
        }

        //public static ArrayNode ParseArr(ITree tree, BodyTable wrapTable) {
        //    string arrType = tree.GetChild(0).Text;
        //    string arrName = tree.GetChild(1).Text;

        //    if (wrapTable.FindNode<VariableNode>(arrName) != null) {
        //        throw new NodeAlreadyExistException($"Массив с именем {arrName} уже объявлена");
        //    }

        //    var arrNode = new ArrayNode(arrName, arrType, wrapTable);
        //    wrapTable.AddNode(arrNode);
        //    return arrNode;
        //}

        public static StructNode ParseStructDeclare(ITree tree, BodyTable wrapTable) {
            string structName = tree.GetChild(0).Text;

            if (wrapTable.FindNode<StructNode>(structName) != null) {
                throw new NodeAlreadyExistException($"Структура с именем {structName} уже объявлена");
            }


            BodyTable bodyTable = new BodyTable(new List<Node>(), wrapTable);
            var structNode = new StructNode(structName, bodyTable, wrapTable);
            wrapTable.AddNode(structNode);
            return structNode;
        }
    }
}
