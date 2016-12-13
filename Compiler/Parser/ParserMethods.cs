using System;
using System.Collections.Generic;
using System.Data;
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
            Type varType = this.GetVarType(type.Text);


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

        public MethodNode ParseMethodDeclare(ITree tree, Body body)
        {
            string methodName = tree.GetChild(1).Text;

            if (Body.FindNodeByName<MethodNode>(methodName, body) != null)
            {
                throw new NodeAlreadyExistException($"Метод с именем {methodName} уже объявлен");
            }

            Type returnType;
            if (tree.GetChild(0).Text == "RET_TYPE_SINGLE")
            {
                if (tree.GetChild(0).GetChild(0).Text == "void") {
                    returnType = Type.Void;
                }
                else {
                    returnType = this.GetVarType(tree.GetChild(0).GetChild(0).Text);
                }

            }
            else if (tree.GetChild(0).Text == "RET_TYPE_ARR")
            {
                returnType = this.GetArrType(tree.GetChild(0).GetChild(0).Text);
            }
            else
            {
                throw new DataException(
                    $"Ошибка при парсинге метода {methodName} - не верно указано возвращаемое значение {tree.GetChild(0)}");
            }

            List<VariableNode> args = new List<VariableNode>();
            ITree argsNode = tree.GetChild(2);

            var bodyTable = new Body(new List<Node>(), body);
            for (int i = 0; i < argsNode.ChildCount; i++)
            {

                VariableNode varNode;
                varNode = this.ParseVarDecl(argsNode.GetChild(i), bodyTable)[0];
                args.Add(varNode);
            }
            var methodNode = new MethodNode(methodName,returnType, bodyTable, args);
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

            return new ArrNode(name.Text, typeToken, 0);
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
    }
}
