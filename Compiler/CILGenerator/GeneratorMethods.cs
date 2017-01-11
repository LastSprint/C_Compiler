using System;
using System.Collections.Generic;
using System.Text;
using CompilerConsole.Parser;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.BodyNodes;
using CompilerConsole.Parser.Nodes.CallNode;
using Type = CompilerConsole.Parser.Nodes.Type;

namespace CompilerConsole.CILGenerator {
    public partial class Generator {
        /// <summary>
        ///     Счетчик строк
        /// </summary>
        public int Counter;

        /// <summary>
        ///     Это символ табуляции
        /// </summary>
        public string Offset = "\t";

        /// <summary>
        ///     IL_
        /// </summary>
        public string PreLineNumber = "IL_";

        public string LineNumber => this.PreLineNumber + this.Counter++ + ":" + this.Offset;

        /// <summary>
        ///     Генерирует IL код для методы
        /// </summary>
        /// <param name="method">Метод, для которого нужно сгенерировать IL код</param>
        /// <returns></returns>
        private string GenerateCILMethod(MethodNode method) {
            this.Counter = 0;
            var methodCIL = new StringBuilder();
            string startMethodCIL;

            #region Method start

            StringBuilder arrays = new StringBuilder();

            if (method.Name == "main") {
                startMethodCIL = this.Reader(Template.DeclMainFunc);

                foreach (var node in method.Body.WrapBody.Nodes)
                {
                    if (node is ArrNode)
                    {
                        arrays.AppendLine(this.ExpressionToIL(node));
                    }
                }
            }
            else {
                startMethodCIL = this.Reader(Template.StartFuncDecl);
                startMethodCIL = startMethodCIL.Replace("{type}", this.ToCILVariableType(method.DataType));
            }


            startMethodCIL = startMethodCIL.Replace(this.cilReplacedToken[CILReplacedToken.MethodName], method.Name);
            //Генерирем аргументы и включаем их в шаблон
            startMethodCIL = startMethodCIL.Replace(this.cilReplacedToken[CILReplacedToken.MethodArgs],
                this.GenerateArgs(method));

            #endregion

            #region Methpd body

            methodCIL.AppendLine(startMethodCIL);
            //Генерация декларации локальных переменных
            var localVardeclTemplate = this.Reader(Template.LocalvariableDeclaration);
            localVardeclTemplate = localVardeclTemplate.Replace(this.cilReplacedToken[CILReplacedToken.Variables],
                this.GenerateLocalVariableDeclaration(method.Body));
            methodCIL.AppendLine(localVardeclTemplate);
            //Генерация IL кода для выражений
            methodCIL.AppendLine(arrays.ToString());
            methodCIL.AppendLine(this.GenerateExpression(method));

            #endregion

            #region Method end

            //Генерация IL кода для окончания декларации метода
            var methodEnd = this.Reader(Template.DeclFuncFinich);
            methodCIL.AppendLine(methodEnd);

            #endregion

            return methodCIL.ToString();
        }

        /// <summary>
        ///     Генерирует IL код для объявления глобальных переменных
        /// </summary>
        /// <param name="body">Тело, из которого нужно извлечь объявление глобальных переменных и сгененрировать для них IL код</param>
        /// <returns>Сгенерированный IL код</returns>
        private string GenerateGlobalVar(Body body) {
            var fields = new StringBuilder();
            foreach (var node in body.Nodes) {
                if (node is VariableNode) {
                    if ((node as VariableNode).IsGlobal) {
                        var decl = this.Reader(Template.FieldDecl);
                        decl = decl.Replace("{name}", node.Name);
                        decl = decl.Replace("{type}", this.ToCILVariableType(node.DataType));
                        fields.AppendLine(decl);
                    }
                }
            }
            return fields.ToString();
        }

        private string GenerateFuncArg(VariableNode variable) {
            return $"{this.ToCILVariableType(variable.DataType)} {variable.Name}";
        }

        private string GenerateVarDecl(VariableNode node) {
            return $"{this.Offset} [{node.Number}] {this.ToCILVariableType(node.DataType)} {node.Name}";
        }

        /// <summary>
        ///     Переводит тип переменной в тип переменной, понятный CILу
        /// </summary>
        /// <param name="type">тип переменной, который нужно перевести в CIL тип</param>
        /// <returns>строковое представление CIL типа</returns>
        private string ToCILVariableType(Type type) {
            switch (type) {
                case Type.VarInt:
                    return "int32";
                case Type.VarFloat:
                    return "float32";
                case Type.VarString:
                    return "string";
                case Type.VarChar:
                    return "char";
                case Type.VarBool:
                    return "bool";
                case Type.ArrInt:
                    return "int32[]";
                case Type.ArrFloat:
                    return "float32[]";
                case Type.ArrString:
                    return "string[]";
                case Type.ArrChar:
                    return "char[]";
                case Type.ArrBool:
                    return "bool[]";
                case Type.Void:
                    return "void";
            }
            return null;
        }

        private string GenerateILDoLoop(DoLoop doLoop) {
            var template = this.Reader(Template.DoWhile);
            var loopBody = this.ParseBody(doLoop.Body);
            var counter = GetLineNumber(loopBody);
            var cond = this.ExpressionToIL(doLoop.Condition);
            template = template.Replace("{cond}", cond);
            template = template.Replace("{end line}", this.LineNumber);
            template = template.Replace("{body line}", this.PreLineNumber + counter);
            return template.Replace("{body}", loopBody);
        }

        private string GenerateILMethCall(MethCall methCallNode)
        {
            StringBuilder methodCall = new StringBuilder();
            foreach (var sendArg in methCallNode.SendArgs)
            {
                if (sendArg is ArrNode)
                {
                    methodCall.AppendLine(this.GenerateVariable((VariableNode)sendArg));
                }
                else
                {
                    methodCall.AppendLine(this.ExpressionToIL(sendArg));
                }
            }

            switch (methCallNode.Method.Name)
            {
                case Parser.Parser.WriteMethodName:
                    {
                        var type = methCallNode.SendArgs.Count != 0 ? methCallNode.SendArgs[0].DataType : Type.Void;
                        var strType = type == Type.Void ? "" : ToCILVariableType(type);
                        methodCall.Append(this.LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset +
                                          this.Reader(Template.ConsoleWriteLine)
                                              .Replace("{type}", strType));
                        break;
                    }
                case Parser.Parser.ReadMethodName:
                    {
                        //Если вызываем ввод из консоли
                        methodCall.Append(this.LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset +
                                          this.Reader(Template.ConsoleReadLine));
                        break;
                    }
                case Parser.Parser.ReadFile:
                    {
                        methodCall.Append(this.LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset +
                                          this.Reader(Template.ReadFile));
                        break;
                    }
                case Parser.Parser.Concate:
                    {
                        methodCall.Append(this.LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset +
                                          this.Reader(Template.Concate));
                        break;
                    }
                case Parser.Parser.Write:
                    {
                        var type = methCallNode.SendArgs.Count != 0 ? methCallNode.SendArgs[0].DataType : Type.Void;
                        var strType = type == Type.Void ? "" : ToCILVariableType(type);
                        methodCall.Append(this.LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset +
                                          this.Reader(Template.Write)
                                              .Replace("{type}", strType));
                        break;
                    }
                case Parser.Parser.ConvertToString:
                    {
                        methodCall.Append(this.LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset +
                                          this.Reader(Template.Convert));
                        break;
                    }
                case Parser.Parser.WriteFile:
                    {
                        var tmp = this.Reader(Template.WriteFile).Replace("{line}", this.LineNumber);
                        tmp = tmp.Replace("{line1}", this.LineNumber);
                        methodCall.Append(tmp);
                        break;
                    }
                default:
                    {
                        string method = this.Reader(Template.CallMethod);
                        method = method.Replace("{type}", ToCILVariableType(methCallNode.Method.DataType));
                        method = method.Replace("{name}", methCallNode.Method.Name);

                        string args = "";

                        for (int i = 0; i < methCallNode.SendArgs.Count; i++)
                        {
                            var sendArg = methCallNode.SendArgs[i];
                            args += ToCILVariableType(sendArg.DataType);
                            if (methCallNode.SendArgs.Count > 1 && i != methCallNode.SendArgs.Count - 1)
                            {
                                args += ", ";
                            }
                        }
                        method = method.Replace("{args}", args);
                        methodCall.Append(this.LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset +
                                          method);
                        break;
                    }
            }
            return methodCall.ToString();
        }

        private string GenerateConjExpr(Expression expr) {
            var left = this.ExpressionToIL(expr.LeftNode) + Environment.NewLine;

            var op = "";
            if (expr.ExprToken == ExprToken.Conj) {
                op = this._operationDictionary[ILOperation.Conj].Replace("{opline}", this.LineNumber) +
                     Environment.NewLine;
            }
            else if (expr.ExprToken == ExprToken.Dij) {
                op = this._operationDictionary[ILOperation.Dij].Replace("{opline}", this.LineNumber) +
                     Environment.NewLine;
            }
            var right = this.ExpressionToIL(expr.RightNode) + Environment.NewLine;

            var endOp = "";

            if (expr.ExprToken == ExprToken.Conj) {
                endOp = this.Reader(Template.Conj);
            }
            else if (expr.ExprToken == ExprToken.Dij) {
                endOp = this.Reader(Template.Dij);
            }
            endOp = endOp.Replace("{br line}", this.LineNumber);
            var constLine = this.LineNumber;
            op = op.Replace("{const line}", constLine.Replace(":", ""));
            endOp = endOp.Replace("{const line}", constLine);
            endOp = endOp.Replace("{end}", this.LineNumber + " br {end line}");

            return left + op + right + endOp + Environment.NewLine;
        }

        #region Method body decomposition

        /// <summary>
        ///     Генерирует IL код, для аргументов метода
        /// </summary>
        /// <param name="method">Метод, для которого нужно сгенерировать аргументы</param>
        /// <returns>Сгенерированный IL код</returns>
        private string GenerateArgs(MethodNode method) {
            var args = new StringBuilder();
            for (var i = 0; i < method.ArgList.Count; i++) {
                var variableNode = method.ArgList[i];
                args.Append(this.Offset + this.GenerateFuncArg(variableNode));
                if (method.ArgList.Count > 1 && i != method.ArgList.Count - 1) {
                    args.Append(",");
                }
                args.AppendLine();
            }

            return args.ToString();
        }

        private List<VariableNode> GetAllLocalVariables(Body body) {
            var variables = new List<VariableNode>();

            foreach (var node in body.Nodes) {
                if (node is VariableNode) {
                    variables.Add(node as VariableNode);
                }

                if (node is BodyNode) {
                    variables.AddRange(this.GetAllLocalVariables((node as BodyNode).Body));
                }
            }

            foreach (var variableNode in variables) {
                if (!(variableNode is ArrNode))
                    body.Nodes.Remove(variableNode);
            }

            return variables;
        }

        /// <summary>
        ///     Гененрирует IL код, отвечающий за объявление локальныхп еременных в функции
        /// </summary>
        /// <param name="method">Метод, для которого нужно сгенерировать IL</param>
        /// <returns>Сгенерированный IL код</returns>
        private string GenerateLocalVariableDeclaration(Body body) {
            var localVariables = new StringBuilder();

            var variables = this.GetAllLocalVariables(body);
            //теперь заносим их в IL
            for (var i = 0; i < variables.Count; i++) {
                localVariables.Append(this.GenerateVarDecl(variables[i]));
                if (variables.Count > 1 && i < variables.Count - 1) {
                    localVariables.Append(",");
                }
                localVariables.AppendLine();
            }

            return localVariables.ToString();
        }

        /// <summary>
        ///     Генерирует IL код соответствующи различным операциям
        /// </summary>
        /// <param name="method">Метод, выражения в теле которого необходимо сгенерировать в виде IL кода</param>
        /// <remarks>ЕСТЬ ГЕНЕРАЦИЯ ТОЛЬКО ДЛЯ ПРИСВАИВАНИЯ</remarks>
        /// <returns>IL кода</returns>
        private string GenerateExpression(MethodNode method) {
            var expressions = new StringBuilder();
            //Начинаем парсить выражения
            foreach (var node in method.Body.Nodes) {
                var result = this.ExpressionToIL(node);

                if (!string.IsNullOrEmpty(result)) {
                    expressions.AppendLine(result);
                }
            }
            return expressions.ToString();
        }

        #endregion

        #region Utils

        private string GenerateVariable(Node node) {
            var varNode = (VariableNode) node;
            if (varNode.IsGlobal) {
                var field = this.Reader(Template.CallField);
                field = field.Replace("{type}", this.ToCILVariableType(varNode.DataType));
                field = field.Replace("{name}", varNode.Name);
                return this.LineNumber + this._operationDictionary[ILOperation.ReadField] + this.Offset + field;
            }
            var operation = varNode.IsMethodArg
                ? this._operationDictionary[ILOperation.ReadMethodArg]
                : this._operationDictionary[ILOperation.ReadLocalVariable];

            return this.LineNumber + operation + this.Offset + varNode.Number;
        }

        public string ExpressionToIL(Node node) {
            if (node is StructVariableNode) {
                var varNode = (VariableNode) node;
                if (varNode.IsGlobal) {
                    var field = this.Reader(Template.CallField);
                    field = field.Replace("{type}", this.ToCILVariableType(varNode.DataType));
                    field = field.Replace("{name}", varNode.Name);
                    return this.LineNumber+this._operationDictionary[ILOperation.ReadField] + this.Offset + field;
                }
                var operation = varNode.IsMethodArg
                    ? this._operationDictionary[ILOperation.ReadMethodArg]
                    : this._operationDictionary[ILOperation.ReadLocalVariable];

                return this.LineNumber + operation + this.Offset + varNode.Number;
            }

            if (node is ArrCall) {
                var arr = (ArrCall) node;
                string arrCall;
                if (arr.Arr.IsGlobal) {
                    var field = this.Reader(Template.CallField);
                    field = field.Replace("{type}", this.ToCILVariableType(arr.Arr.DataType));
                    field = field.Replace("{name}", arr.Arr.Name);
                    arrCall = this.LineNumber + this._operationDictionary[ILOperation.ReadField] + this.Offset + field+
                              Environment.NewLine;
                }
                else {
                    if (arr.Arr.IsMethodArg) {
                        arrCall = this.LineNumber + this._operationDictionary[ILOperation.ReadMethodArg] + this.Offset +
                                  arr.Arr.Number + Environment.NewLine;
                    }
                    else {
                        arrCall = this.LineNumber + this._operationDictionary[ILOperation.ReadLocalVariable] +
                                  this.Offset +
                                  arr.Arr.Number + Environment.NewLine;
                    }
                }
                var index = this.ExpressionToIL(arr.Index) + Environment.NewLine;
                string load;
                if (arr.Arr.DataType == Type.ArrString) {
                    load = this._operationDictionary[ILOperation.ReadArrRefElement];
                }
                else {
                    load = this._operationDictionary[ILOperation.ReadArrStructElement];
                }


                return arrCall + index + this.LineNumber + load;
            }

            if (node is MethCall) {
                return this.GenerateILMethCall((MethCall) node);
            }

            if (node is Expression) {
                return this.ActionExprToIL((Expression) node);
            }

            if (node is Literals) {
                return this.LineNumber + this.GenerateConstIL((Literals) node);
            }
            if (node is ArrNode) {
                var arr = (ArrNode) node;
                var arrSize = this.ExpressionToIL(arr.Length) + Environment.NewLine;
                var arrDecl = this.Reader(Template.ArrDecl);
                var t = this.ToCILVariableType(arr.DataType);
                t = t.Replace("[]", "");
                var fc = t[0];
                t = t.Remove(0, 1);
                t = t.Insert(0, char.ToUpper(fc).ToString());
                arrDecl = this.LineNumber + arrDecl.Replace("{type}", t) + Environment.NewLine;
                var writeArr = "";
                if (arr.IsGlobal) {
                    var field = this.Reader(Template.CallField);
                    field = field.Replace("{type}", this.ToCILVariableType(arr.DataType));
                    field = field.Replace("{name}", arr.Name);
                    writeArr = this._operationDictionary[ILOperation.WriteField] + this.Offset +field +this.Offset;
                }
                else {
                    writeArr = this._operationDictionary[ILOperation.WriteLocalVariable] + this.Offset + arr.Number;
                }
                return arrSize + arrDecl + this.LineNumber + writeArr;
            }
            if (node is ReturnNode) {
                var returnVal = "";
                var ret = (ReturnNode) node;

                if (ret.DataType != Type.Void) {
                    returnVal = this.ExpressionToIL(ret.ReturnedValue) + Environment.NewLine;
                }

                return returnVal + this.LineNumber + this._operationDictionary[ILOperation.Ret];
            }
            if (node is IfNode) {
                var ifNode = (IfNode) node;
                var cond = this.ExpressionToIL(ifNode.Condition) + Environment.NewLine;
                var goTo = this.LineNumber + this.Offset + "brfalse"; //Сюда еще бы доваить ссылку на елс

                var body = this.ParseBody(ifNode.Body);


                var elseBody = "";
                goTo += this.Offset + this.PreLineNumber;
                if (ifNode.ElseBody != null) {
                    body += this.LineNumber + this.Offset + "br" + this.Offset;
                    goTo += this.Counter + Environment.NewLine;
                    elseBody = this.ParseBody(ifNode.ElseBody);
                    body += this.PreLineNumber + this.Counter;
                }
                else {
                    goTo += this.Counter + Environment.NewLine;
                }
                
                body += Environment.NewLine;
                return cond + goTo + body + elseBody;
            }
            if (node is ForLoop) {
                var forNode = (ForLoop) node;
                var varE = this.ExpressionToIL(forNode.VarNode) + Environment.NewLine;
                var goToCondition = this.LineNumber + "br" + this.Offset;
                var body = this.ParseBody(forNode.Body);
                var counter = this.GetLineNumber(body);
                var incremental = this.ExpressionToIL(forNode.Incremental) + Environment.NewLine;
                goToCondition += this.PreLineNumber + this.Counter + Environment.NewLine;
                var condition = this.ExpressionToIL(forNode.CondNode) + Environment.NewLine;
                condition += this.LineNumber + this.Offset + "brtrue" + this.Offset + this.PreLineNumber + counter;
                return varE + goToCondition + body + incremental + condition;
            }
            if (node is DoLoop) {
                return this.GenerateILDoLoop((DoLoop) node);
            }
            if (node is WhileLoop) {
                return this.GenerateILWhileLoop((WhileLoop) node);
            }
            return null;
        }

        private string GenerateILWhileLoop(WhileLoop whileNode) {
            var template = this.Reader(Template.While);
            template = template.Replace("{start line}", this.LineNumber);
            var loopBody = this.ParseBody(whileNode.Body);
            var counter = GetLineNumber(loopBody);
            template = template.Replace("{cond line}", this.PreLineNumber + this.Counter);
            var cond = this.ExpressionToIL(whileNode.Condition);
            template = template.Replace("{condition}", cond);
            template = template.Replace("{end line}", this.LineNumber);
            template = template.Replace("{body line}", this.PreLineNumber + counter);
            return template.Replace("{body}", loopBody);
        }

        private string GetLineNumber(string text) {
            var res = "";
            for (var i = 0; i < text.Length; i++) {
                if (text[i] == '_') {
                    for (var j = i + 1; j < text.Length; j++) {
                        if (text[j] == ':') {
                            return res;
                        }
                        res += text[j];
                    }
                }
            }
            return null;
        }

        private string ParseBody(Body body) {
            var expressions = new StringBuilder();
            //Начинаем парсить выражения
            foreach (var node in body.Nodes) {
                var result = this.ExpressionToIL(node);

                if (!string.IsNullOrEmpty(result)) {
                    expressions.AppendLine(result);
                }
            }
            return expressions.ToString();
        }

        public string ActionExprToIL(Expression node) {
            switch (node.ExprToken) {
                case ExprToken.IsEqual: {
                    var exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    var exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    var temp = "";
                    if (node.LeftNode.DataType == Type.VarString) {
                        temp = this.LineNumber + "call bool [mscorlib]System.String::op_Equality(string,string)" + Environment.NewLine;
                        return exprl + exprr + temp;
                    }
                    var op = this.LineNumber + this._operationDictionary[ILOperation.Neg];
                    return exprl + exprr + op;
                }
                case ExprToken.IsLess: {
                    var exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    var exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    var op = this.LineNumber + this._operationDictionary[ILOperation.Less];
                    return exprl + exprr + op;
                }
                case ExprToken.IsMore: {
                    var exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    var exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    var op = this.LineNumber + this._operationDictionary[ILOperation.More];
                    return exprl + exprr + op;
                }
                case ExprToken.IsLessOrEqual: {
                    var exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    var exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    var op = this.LineNumber + this._operationDictionary[ILOperation.More] + Environment.NewLine;
                    var ln = this.LineNumber + "ldc.i4 0" + Environment.NewLine;
                    var ope = this.LineNumber + this._operationDictionary[ILOperation.Neg];
                    return exprl + exprr + op + ln + ope;
                }
                case ExprToken.IsMoreOrEqual: {
                    var exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    var exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    var op = this.LineNumber + this._operationDictionary[ILOperation.Less] + Environment.NewLine;
                    var ln = this.LineNumber + "ldc.i4 0" + Environment.NewLine;
                    var ope = this.LineNumber + this._operationDictionary[ILOperation.Neg];
                    return exprl + exprr + op + ln + ope;
                }
                case ExprToken.Add:
                    return this.GenerateAddExpr(node);
                case ExprToken.Sub:
                    return this.GenerateSubExpr(node);
                case ExprToken.Mult:
                    return this.GenerateMultExpr(node);
                case ExprToken.Div:
                    return this.GenerateDivExpr(node);
                case ExprToken.Conj:
                    return this.GenerateConjExpr(node);
                case ExprToken.Dij:
                    return this.GenerateConjExpr(node);
                case ExprToken.Neg: {
                    var expr = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    var lineNum = this.LineNumber;
                    var ln = lineNum + "ldc.i4 0" + Environment.NewLine;
                    expr = expr.Replace("{end line}", lineNum.Replace(":", ""));
                    var op = this.LineNumber + this._operationDictionary[ILOperation.Neg];
                    return expr + ln + op;
                }
                case ExprToken.Ass:
                    return this.AssignExprToIL(node);
                case ExprToken.Error:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return null;
        }

        public string AssignExprToIL(Expression node) {
            var assignString = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            var writeOpertion = "";
            if (node.LeftNode is ArrCall) {
                var arr = (ArrCall) node.LeftNode;
                string arrCall;
                if (arr.Arr.IsGlobal) {
                    var field = this.Reader(Template.CallField);
                    field = field.Replace("{type}", this.ToCILVariableType(arr.Arr.DataType));
                    field = field.Replace("{name}", arr.Arr.Name);
                    arrCall = this.LineNumber + this._operationDictionary[ILOperation.ReadField] + this.Offset + field + 
                              Environment.NewLine;
                }
                else {
                    if (arr.Arr.IsMethodArg) {
                        arrCall = this.LineNumber + this._operationDictionary[ILOperation.ReadMethodArg] + this.Offset +
                                  arr.Arr.Number + Environment.NewLine;
                    }
                    else {
                        arrCall = this.LineNumber + this._operationDictionary[ILOperation.ReadLocalVariable] +
                                  this.Offset +
                                  arr.Arr.Number + Environment.NewLine;
                    }
                }

                var index = this.ExpressionToIL(arr.Index) + Environment.NewLine;
                var righte = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                string write;
                if (arr.Arr.DataType == Type.ArrString) {
                    write = this._operationDictionary[ILOperation.WriteArrRefElement];
                }
                else {
                    write = this._operationDictionary[ILOperation.WriteArrStructElement];
                }

                return arrCall + index + righte + this.LineNumber + write;
            }

            if (node.LeftNode is ArrNode) {
                var arrl = (ArrNode) node.LeftNode;
                var arrr = (ArrNode) node.RightNode;
                string loadRight;
                if (arrr.IsGlobal) {
                    var field = this.Reader(Template.CallField);
                    field = field.Replace("{type}", this.ToCILVariableType((node.LeftNode as ArrNode).DataType));
                    field = field.Replace("{name}", (node.LeftNode as ArrNode).Name);
                    loadRight = this.LineNumber + this._operationDictionary[ILOperation.ReadField] + this.Offset + field;
                }
                else {
                    if (arrr.IsMethodArg) {
                        loadRight = this.LineNumber + this._operationDictionary[ILOperation.ReadMethodArg] + this.Offset +
                                    arrr.Number + Environment.NewLine;
                    }
                    else {
                        loadRight = this.LineNumber + this._operationDictionary[ILOperation.ReadLocalVariable] +
                                    this.Offset +
                                    arrr.Number + Environment.NewLine;
                    }
                }
                string loadLeft;
                if (arrl.IsGlobal) {
                    var field = this.Reader(Template.CallField);
                    field = field.Replace("{type}", this.ToCILVariableType((node.LeftNode as ArrNode).DataType));
                    field = field.Replace("{name}", (node.LeftNode as ArrNode).Name);
                    loadLeft = this.LineNumber + this._operationDictionary[ILOperation.WriteField] + this.Offset + field;
                }
                else {
                    if (arrl.IsMethodArg) {
                        loadLeft = this.LineNumber + this._operationDictionary[ILOperation.WriteMethodArg] + this.Offset +
                                   arrr.Number + Environment.NewLine;
                    }
                    else {
                        loadLeft = this.LineNumber + this._operationDictionary[ILOperation.WriteLocalVariable] +
                                   this.Offset +
                                   arrr.Number + Environment.NewLine;
                    }
                }
                return loadRight + loadLeft;
            }

            var writeLineNumber = "";
            if ((node.LeftNode as VariableNode).IsGlobal) {
                var field = this.Reader(Template.CallField);
                field = field.Replace("{type}", this.ToCILVariableType((node.LeftNode as VariableNode).DataType));
                field = field.Replace("{name}", (node.LeftNode as VariableNode).Name);
                writeLineNumber = this.LineNumber;
                writeOpertion = writeLineNumber + this._operationDictionary[ILOperation.WriteField] + this.Offset +
                                field;
            }

            else {
                writeLineNumber = this.LineNumber;
                if ((node.LeftNode as VariableNode).IsMethodArg) {
                    writeOpertion = writeLineNumber + this._operationDictionary[ILOperation.WriteMethodArg];
                }
                else {
                    writeOpertion = writeLineNumber + this._operationDictionary[ILOperation.WriteLocalVariable];
                }
                writeOpertion += this.Offset + (node.LeftNode as VariableNode).Number;
            }
            assignString = assignString.Replace("{end line}", writeLineNumber.Replace(":", ""));
            var writeAssignString = writeOpertion;
            return assignString + writeAssignString;
        }

        private string GenerateAddExpr(Expression node) {
            var left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            var right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right + this.LineNumber + this._operationDictionary[ILOperation.Add];
        }

        private string GenerateSubExpr(Expression node) {
            var left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            var right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right + this.LineNumber + this._operationDictionary[ILOperation.Sub];
        }

        private string GenerateMultExpr(Expression node) {
            var left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            var right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right + this.LineNumber + this._operationDictionary[ILOperation.Mul];
        }

        private string GenerateDivExpr(Expression node) {
            var left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            var right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right + this.LineNumber + this._operationDictionary[ILOperation.Div];
        }

        private string GenerateConstIL(Literals literal) {
            var result = "";

            switch (literal.DataType) {
                case Type.VarInt:
                    result = this._operationDictionary[ILOperation.IntConstLoad] + this.Offset + literal.Value;
                    break;
                case Type.VarFloat:
                    break;
                case Type.VarString:
                    return this._operationDictionary[ILOperation.StringConstLoad] + this.Offset + literal.Value;
                case Type.VarChar:
                    return this._operationDictionary[ILOperation.IntConstLoad] + this.Offset +
                           (int) (char) literal.Value;
                case Type.VarBool:
                    var boolRes = literal.Value.ToString() == "False" ? "0" : "1";
                    return this._operationDictionary[ILOperation.IntConstLoad] + this.Offset + boolRes;
                default:
                    throw new ArgumentOutOfRangeException($"GenerateConstIL странный тип {literal.DataType}");
            }


            return result;
        }

        #endregion
    }
}