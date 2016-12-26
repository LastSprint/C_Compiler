using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using Antlr.Runtime.Tree;
using CompilerConsole.Parser.Exceptions;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.BodyNodes;
using CompilerConsole.Parser.Nodes.CallNode;
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
                variables.Add(this.PareArrDecl(tree, body));
                return variables;
            }
            else {
                varType = this.GetVarType(type.Text);
            }


            for (int i = 1; i < tree.ChildCount; i++) {

                if (tree.GetChild(i).Text == "=") {
                    variables[0].Assign = this.ParsExpr(tree.GetChild(i).GetChild(0), body);
                    break;
                }

                if (this.IsType(tree.GetChild(i).Text)) {
                    throw new UsedKeyWorldExceptioncs(
                        $"Для имени переменной было использовано ключевое слово {tree.GetChild(0).Text}");
                }

                if (Body.FindNodeByName<VariableNode>(tree.GetChild(i).Text, body) != null) {
                    throw new NodeAlreadyExistException($"Переменная с именем {tree.GetChild(i).Text} объявлена ранее");
                }

                variables.Add(new StructVariableNode(tree.GetChild(i).Text, varType));
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

            foreach (var variable in methodNode.ArgList) {
                methodNode.Body.Nodes.Add(variable);
            }

            return methodNode;
        }

        public ArrNode PareArrDecl(ITree tree, Body body) {
            ITree type = tree.GetChild(0);
            ITree name = tree.GetChild(1);
            ITree length = tree.GetChild(2);

            Type typeToken = this.GetArrType(type.Text);

            if (Body.FindNodeByName<StructVariableNode>(name.Text,body) != null) {
                throw new NodeAlreadyExistException($"Переменная с именем {name.Text} объявлена ранее");
            }
            if (length == null) {
                return new ArrNode(name.Text, typeToken, null);
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
                    return t1;
                case Token.METH_CALL:
                    var t2 =  this.ParseMethCall(treeNode, body);
                    return t2;
                case Token.INC:
                    var t3 = this.ParseIncDec(treeNode, body, ExprToken.Add);
                    return t3;
                case Token.DEC:
                    var t4 = this.ParseIncDec(treeNode, body, ExprToken.Sub);
                    return t4;

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

        private Node ParseIncDec(ITree tree, Body body, ExprToken token) {
            var variable = Body.FindNodeByName<StructVariableNode>(tree.GetChild(0).Text, body);
            if (variable == null) {
                throw new NodeNotfoundException($"переменной с именем {tree.GetChild(0).Text} не существует");
            }
            Expression fe = new Expression(variable, new Literals(variable.DataType, 1),token);
            Expression re = new Expression(variable, fe, ExprToken.Ass);
            return re;
        }

        private IfNode ParseIf(ITree tree, Body body) {
            ITree cond = tree.GetChild(0);
            ITree ifBody = tree.GetChild(1);

            Node expr = this.ParsExpr(cond, body);
            if (expr.DataType != Type.VarBool) {
                throw new UndefinedTypeException($"Выражение внутри if должно иметь тип bool, а не {expr.DataType}");
            }

            Body tempBody = new Body();
            tempBody.WrapBody = body;
            this.RecPars(ifBody, tempBody);
            var ifNode = new IfNode(tempBody);
            ifNode.Condition = expr;
            return ifNode;

        }

        private ForLoop ParseForLoop(ITree tree, Body body) {
            ITree varE = tree.GetChild(0);
            ITree condT = tree.GetChild(1);
            ITree imp = tree.GetChild(2);
            ITree bodyL = tree.GetChild(3);

            Node varNode;

            if (varE.Text == "VAR_DECL") {
                varNode = this.ParseVarDecl(varE, body)[0];
            }
            else {
                varNode = this.ParsExpr(tree, body);
            }

            Body loopBody = new Body();
            loopBody.Nodes.Add(varNode);
            loopBody.WrapBody = body;
            Node cond = this.ParsExpr(condT, loopBody);

            if (cond.DataType != Type.VarBool) {
                throw new UndefinedTypeException($"логическое условие для for должно иметь тип bool а не {cond.DataType}");
            }

            Node loop = this.ParsExpr(imp, loopBody);

            var fl = new ForLoop(loopBody);
            fl.VarNode = varNode;
            fl.CondNode = cond;
            fl.Incremental = loop;
            this.RecPars(bodyL, loopBody);
            return fl;
        }

        private WhileLoop ParseWhileLoop(ITree tree, Body body)
        {
            ITree condT = tree.GetChild(0);
            ITree bodyL = tree.GetChild(1);

            Body loopBody = new Body();
            loopBody.WrapBody = body;
            Node cond = this.ParsExpr(condT, loopBody);

            if (cond.DataType != Type.VarBool)
            {
                throw new UndefinedTypeException($"логическое условие для While должно иметь тип bool а не {cond.DataType}");
            }

            var fl = new WhileLoop(loopBody);
            fl.Condition = cond;

            this.RecPars(bodyL, loopBody);

            return fl;
        }

        private DoLoop ParseDoLoop(ITree tree, Body body)
        {
            ITree condT = tree.GetChild(1);
            ITree bodyL = tree.GetChild(0);

            Body loopBody = new Body();
            loopBody.WrapBody = body;
            Node cond = this.ParsExpr(condT, loopBody);

            if (cond.DataType != Type.VarBool)
            {
                throw new UndefinedTypeException($"логическое условие для Do_While должно иметь тип bool а не {cond.DataType}");
            }

            var fl = new DoLoop(loopBody);
            fl.Condition = cond;

            this.RecPars(bodyL, loopBody);

            return fl;
        }

        private ReturnNode ParseReturn(ITree tree, Body body) {
            if (_currentMethod == null) {
                throw new Exception("оператор return использован вне контекста метода");
            }

            Type returnedValueType;
            Node returnedValue = null;
            if (tree.ChildCount == 0) {
                returnedValueType = Type.Void;
            }
            else {
                returnedValue = this.ParsExpr(tree.GetChild(0), body);
                returnedValueType = returnedValue.DataType;
            }

            if (returnedValueType != _currentMethod.DataType)
            {
                throw new InvalidCastException($"Метод возвращает тип {_currentMethod.DataType} а ретерн возвращет {returnedValueType} - неувязочка");
            }

            return new ReturnNode(returnedValueType, returnedValue);
        }

    }
}