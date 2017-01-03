using System;
using System.Collections.Generic;
using System.Text;
using CompilerConsole.Parser;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.BodyNodes;
using CompilerConsole.Parser.Nodes.CallNode;
using Lang2;
using Type = CompilerConsole.Parser.Nodes.Type;

namespace CompilerConsole.CILGenerator
{

    public partial class Generator {

        public string LineNumber => this.PreLineNumber + this.Counter++ + ":" + this.Offset;

        /// <summary>
        /// IL_
        /// </summary>
        public string PreLineNumber = "IL_";
        /// <summary>
        /// Счетчик строк
        /// </summary>
        public  int Counter = 0;
        /// <summary>
        /// Это символ табуляции
        /// </summary>
        public string Offset = "\t";

        /// <summary>
        /// Генерирует IL код для методы
        /// </summary>
        /// <param name="method">Метод, для которого нужно сгенерировать IL код</param>
        /// <returns></returns>
        private string GenerateCILMethod(MethodNode method) {
            Counter = 0;
            StringBuilder methodCIL = new StringBuilder();
            string startMethodCIL;

            #region Method start
            if (method.Name == "main") {
                startMethodCIL = this.Reader(Template.DeclMainFunc);
            }
            else {
                startMethodCIL = this.Reader(Template.StartFuncDecl);
                startMethodCIL = startMethodCIL.Replace("{type}", this.ToCILVariableType(method.DataType));
            }
          
            startMethodCIL = startMethodCIL.Replace(this.cilReplacedToken[CILReplacedToken.MethodName], method.Name);
            //Генерирем аргументы и включаем их в шаблон
            startMethodCIL = startMethodCIL.Replace(this.cilReplacedToken[CILReplacedToken.MethodArgs], this.GenerateArgs(method));
#endregion

            #region Methpd body
            methodCIL.AppendLine(startMethodCIL);
            //Генерация декларации локальных переменных
            string localVardeclTemplate = this.Reader(Template.LocalvariableDeclaration);
            localVardeclTemplate =  localVardeclTemplate.Replace(this.cilReplacedToken[CILReplacedToken.Variables], this.GenerateLocalVariableDeclaration(method.Body));
            methodCIL.AppendLine(localVardeclTemplate);
            //Генерация IL кода для выражений
            methodCIL.AppendLine(this.GenerateExpression(method));
            #endregion

            #region Method end
            //Генерация IL кода для окончания декларации метода
            string methodEnd = this.Reader(Template.DeclFuncFinich);
            methodCIL.AppendLine(methodEnd);
            #endregion

            return methodCIL.ToString();
        }

        #region Method body decomposition
        /// <summary>
        /// Генерирует IL код, для аргументов метода
        /// </summary>
        /// <param name="method">Метод, для которого нужно сгенерировать аргументы</param>
        /// <returns>Сгенерированный IL код</returns>
        private string GenerateArgs(MethodNode method) {
            StringBuilder args = new StringBuilder();
            for (int i = 0; i < method.ArgList.Count; i++)
            {
                var variableNode = method.ArgList[i];
                args.Append(this.Offset + this.GenerateFuncArg(variableNode));
                if (method.ArgList.Count > 1 && i != method.ArgList.Count - 1)
                {
                    args.Append(",");
                }
                args.AppendLine();
            }

            return args.ToString();
        }

        private List<VariableNode> GetAllLocalVariables(Body body) {
            List<VariableNode> variables = new List<VariableNode>();

            foreach (var node in body.Nodes) {
                if (node is VariableNode) {
                    variables.Add(node as VariableNode);
                }

                if (node is BodyNode) {
                    variables.AddRange(this.GetAllLocalVariables((node as BodyNode).Body));
                }
            }

            foreach (var variableNode in variables)
            {
                if (!(variableNode is ArrNode))
                    body.Nodes.Remove(variableNode);
            }

            return variables;
        }

        /// <summary>
        /// Гененрирует IL код, отвечающий за объявление локальныхп еременных в функции
        /// </summary>
        /// <param name="method">Метод, для которого нужно сгенерировать IL</param>
        /// <returns>Сгенерированный IL код</returns>
        private string GenerateLocalVariableDeclaration(Body body) {
            StringBuilder localVariables = new StringBuilder();

            List<VariableNode> variables = this.GetAllLocalVariables(body);
            //теперь заносим их в IL
            for (int i = 0; i < variables.Count; i++)
            {
                localVariables.Append(this.GenerateVarDecl(variables[i]));
                if (variables.Count > 1 && i < variables.Count - 1)
                {
                    localVariables.Append(",");
                }
                localVariables.AppendLine();
            }

            return localVariables.ToString();
        }

        /// <summary>
        /// Генерирует IL код соответствующи различным операциям
        /// </summary>
        /// <param name="method">Метод, выражения в теле которого необходимо сгенерировать в виде IL кода</param>
        /// <remarks>ЕСТЬ ГЕНЕРАЦИЯ ТОЛЬКО ДЛЯ ПРИСВАИВАНИЯ</remarks>
        /// <returns>IL кода</returns>
        private string GenerateExpression(MethodNode method) {
            StringBuilder expressions = new StringBuilder();
            //Начинаем парсить выражения
            foreach (Node node in method.Body.Nodes) {
                string result = this.ExpressionToIL(node);

                if (!String.IsNullOrEmpty(result)) {
                    expressions.AppendLine(result);
                }
            }
            return expressions.ToString();
        }
#endregion

        /// <summary>
        /// Генерирует IL код для объявления глобальных переменных
        /// </summary>
        /// <param name="body">Тело, из которого нужно извлечь объявление глобальных переменных и сгененрировать для них IL код</param>
        /// <returns>Сгенерированный IL код</returns>
        private string GenerateGlobalVar(Body body) {
            StringBuilder fields = new StringBuilder();
            foreach (var node in body.Nodes) {
                if (node is VariableNode) {
                    if ((node as VariableNode).IsGlobal) {
                        string decl = this.Reader(Template.FieldDecl);
                        decl = decl.Replace("{name}", node.Name);
                        decl = decl.Replace("{type}", this.ToCILVariableType(node.DataType));
                        fields.AppendLine(decl);
                    }
                }
            }
            return fields.ToString();
        }

        private string GenerateFuncArg(VariableNode variable) {
            if (variable is StructVariableNode) {
                var structVariable = variable as StructVariableNode;
                return $"{this.ToCILVariableType(variable.DataType)} {variable.Name}";
            }
            else {
                var structVariable = variable as ArrNode;
                return $"{this.ToCILVariableType(variable.DataType)} {variable.Name}";
            }
        }

        private string GenerateVarDecl(VariableNode node) {
            return $"{this.Offset} [{node.Number}] {this.ToCILVariableType(node.DataType)} {node.Name}";
        }

        /// <summary>
        /// Переводит тип переменной в тип переменной, понятный CILу
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
                //Просто чтоб ошибка не вылетала - нужно дописать
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

        private string MethodCallToIl(MethCall methCallNode) {
            StringBuilder methodCall = new StringBuilder();
            foreach (var sendArg in methCallNode.SendArgs)
            {
                if (sendArg is ArrNode) {
                    methodCall.AppendLine(this.GenerateVariable(sendArg));
                }
                else {
                    methodCall.AppendLine(this.ExpressionToIL(sendArg));
                }               
            }

            if (methCallNode.Method.Name.Contains(Parser.Parser.WriteMethodName)) {
                string t = this.Reader(Template.ConsoleWriteLine);
                methodCall.Append(LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset + this.Reader(Template.ConsoleWriteLine)
                    .Replace("{type}", this.ToCILVariableType(methCallNode.SendArgs[0].DataType)));
                t = methodCall.ToString();
            }
            else if (methCallNode.Method.Name == Parser.Parser.ReadMethodName)
            {
                //Если вызываем ввод из консоли
                methodCall.Append(LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset +
                                      this.Reader(Template.ConsoleReadLine));
            }
            else {
                string method = this.Reader(Template.CallMethod);
                method = method.Replace("{type}", this.ToCILVariableType(methCallNode.Method.DataType));
                method = method.Replace("{name}", methCallNode.Method.Name);

                string args = "";

                for (int i = 0; i < methCallNode.SendArgs.Count; i++) {
                    var sendArg = methCallNode.SendArgs[i];
                    args += this.ToCILVariableType(sendArg.DataType);
                    if (methCallNode.SendArgs.Count > 1 && i != methCallNode.SendArgs.Count-1) {
                        args += ", ";
                    }
                }
                method = method.Replace("{args}", args);
                methodCall.Append(LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset + method);
            }
            return methodCall.ToString();
        }

        private string GenerateConjExpr(Expression expr) {
            string left = this.ExpressionToIL(expr.LeftNode) + Environment.NewLine;

            string op = "";
            if (expr.ExprToken == ExprToken.Conj)
            {
                op = this._operationDictionary[ILOperation.Conj].Replace("{opline}", LineNumber) + Environment.NewLine;
            }
            else if (expr.ExprToken == ExprToken.Dij)
            {
                op = this._operationDictionary[ILOperation.Dij].Replace("{opline}", LineNumber) + Environment.NewLine;
            }
            string right = this.ExpressionToIL(expr.RightNode) + Environment.NewLine;

            string endOp = "";

            if (expr.ExprToken == ExprToken.Conj) {
                /*
                    {br line} br.s {end line}
                    {const line} ldc.i4 0
                    {end}
                 */

                endOp = this.Reader(Template.Conj);

            }
            else if (expr.ExprToken == ExprToken.Dij)
            {
                /*
                    {br line} br.s {end line}
                    {const line} ldc.i4 1
                    {end}
                 */
                endOp = this.Reader(Template.Dij);
            }
            endOp = endOp.Replace("{br line}", LineNumber);
            string constLine = LineNumber;
            op = op.Replace("{const line}", constLine.Replace(":", ""));
            endOp = endOp.Replace("{const line}", constLine);
            endOp = endOp.Replace("{end}", LineNumber + " br {end line}");

            return left + op + right + endOp + Environment.NewLine;
        }

#region Utils

        private string GenerateVariable(Node node) {
            var varNode = (VariableNode)node;
            if (varNode.IsGlobal)
            {
                string field = this.Reader(Template.CallField);
                field = field.Replace("{type}", this.ToCILVariableType(varNode.DataType));
                field = field.Replace("{name}", varNode.Name);
                return this._operationDictionary[ILOperation.ReadField] + this.Offset + field;
            }
            var operation = varNode.IsMethodArg ? this._operationDictionary[ILOperation.ReadMethodArg] : this._operationDictionary[ILOperation.ReadLocalVariable];

            return LineNumber + operation + this.Offset + varNode.Number;
        }

        public string ExpressionToIL(Node node)
        {
            if (node is StructVariableNode)
            {
                var varNode = (VariableNode) node;
                if (varNode.IsGlobal) {
                    string field = this.Reader(Template.CallField);
                    field = field.Replace("{type}", this.ToCILVariableType(varNode.DataType));
                    field = field.Replace("{name}", varNode.Name);
                    return this._operationDictionary[ILOperation.ReadField] + this.Offset + field;
                }
                var operation = varNode.IsMethodArg ? this._operationDictionary[ILOperation.ReadMethodArg] : this._operationDictionary[ILOperation.ReadLocalVariable];

                return  LineNumber + operation + this.Offset + varNode.Number;
            }

            if (node is ArrCall)
            {
                var arr = (ArrCall) node;
                string arrCall;
                if (arr.Arr.IsGlobal) {
                    arrCall = LineNumber +  this._operationDictionary[ILOperation.ReadField] + this.Offset + arr.Name +
                              Environment.NewLine;
                }
                else {
                    if (arr.Arr.IsMethodArg) {
                        arrCall = LineNumber + this._operationDictionary[ILOperation.ReadMethodArg] + this.Offset +
                              arr.Arr.Number + Environment.NewLine;
                    }
                    else {
                        arrCall = LineNumber + this._operationDictionary[ILOperation.ReadLocalVariable] + this.Offset +
                              arr.Arr.Number + Environment.NewLine;
                    }

                    
                }
                string index = this.ExpressionToIL(arr.Index) + Environment.NewLine;
                string load;
                if (arr.Arr.DataType == Type.ArrString) {
                    load = this._operationDictionary[ILOperation.ReadArrRefElement];
                }
                else {
                    load = this._operationDictionary[ILOperation.ReadArrStructElement];
                }

                
                return arrCall + index + LineNumber +load;
            }

            if (node is MethCall) {
                return this.MethodCallToIl((MethCall) node);
            }

            if (node is Expression)
            {
                return this.ActionExprToIL((Expression) node);
            }

            if (node is Literals)
            {
                return LineNumber + this.GenerateConstIL((Literals) node);
            }
            if (node is ArrNode) {
                var arr = (ArrNode) node;
                string arrSize = this.ExpressionToIL(arr.Length) + Environment.NewLine;
                string arrDecl = this.Reader(Template.ArrDecl);
                string t = this.ToCILVariableType(arr.DataType);
                t = t.Replace("[]", "");
                char fc = t[0];
                t = t.Remove(0, 1);
                t = t.Insert(0, char.ToUpper(fc).ToString());
                arrDecl = LineNumber + arrDecl.Replace("{type}", t) + Environment.NewLine;
                string writeArr = "";
                if (arr.IsGlobal) {
                    writeArr = this._operationDictionary[ILOperation.WriteField] + this.Offset + arr.Name;
                }
                else {
                    writeArr = this._operationDictionary[ILOperation.WriteLocalVariable] + this.Offset + arr.Number;
                }
                return  arrSize + arrDecl + LineNumber + writeArr;
            }
            if (node is ReturnNode) {
                string returnVal = "";
                var ret = (ReturnNode) node;

                if (ret.DataType != Type.Void) {
                    returnVal = this.ExpressionToIL(ret.ReturnedValue) + Environment.NewLine;
                }

                return returnVal + LineNumber + this._operationDictionary[ILOperation.Ret];
            }
            if (node is IfNode) {
                var ifNode = (IfNode) node;
                string cond = this.ExpressionToIL(ifNode.Condition) + Environment.NewLine;
                string goTo = LineNumber + Offset + "brfalse";    //Сюда еще бы доваить ссылку на елс

                string body = this.ParseBody(ifNode.Body);


                string elseBody = "";
                goTo += Offset +PreLineNumber + Counter + Environment.NewLine;
                if (ifNode.ElseBody != null) {
                    body += LineNumber + Offset + "br" + Offset;
                    elseBody = this.ParseBody(ifNode.ElseBody);
                    body += PreLineNumber+ Counter;
                }
                body += Environment.NewLine;
                return cond + goTo + body + elseBody;
            }
            if (node is ForLoop) {
                /*
                     IL_000b:  ldc.i4.0
                     IL_000c:  stloc.3
                     IL_000d:  br.s IL_0019
                     IL_000f:  ldloc.3
                     IL_0010:  call void [mscorlib]System.Console::WriteLine(int32)
                     IL_0015:  ldloc.3
                     IL_0016:  ldc.i4.1
                     IL_0017:  add
                     IL_0018:  stloc.3
                     IL_0019:  ldloc.3
                     IL_001a:  ldc.i4.s 10
                     IL_001c:  blt.s IL_000f    
                */
                var forNode = (ForLoop) node;
                string varE = this.ExpressionToIL(forNode.VarNode) + Environment.NewLine;
                string goToCondition = LineNumber + "br" + Offset;
                string body = this.ParseBody(forNode.Body);
                string counter = this.GetLineNumber(body);
                string incremental = this.ExpressionToIL(forNode.Incremental) + Environment.NewLine;
                goToCondition += PreLineNumber + Counter + Environment.NewLine;
                string condition = this.ExpressionToIL(forNode.CondNode) + Environment.NewLine;
                condition += LineNumber + Offset + "brtrue" + Offset + PreLineNumber + counter;
                return varE + goToCondition + body + incremental + condition;
            }

            return null;
        }

        private string GetLineNumber(string text) {
            string res = "";
            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '_') {
                    for (int j = i+1; j < text.Length; j++) {
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
            StringBuilder expressions = new StringBuilder();
            //Начинаем парсить выражения
            foreach (Node node in body.Nodes) {
                string result = this.ExpressionToIL(node);

                if (!String.IsNullOrEmpty(result)) {
                    expressions.AppendLine(result);
                }
            }
            return expressions.ToString();
        }

        public string ActionExprToIL(Expression node)
        {
            switch (node.ExprToken) {
                case ExprToken.IsEqual: {
                    string exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    string exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    string op = LineNumber + this._operationDictionary[ILOperation.Neg];
                    return exprl + exprr + op;
                }
                case ExprToken.IsLess: {
                    string exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    string exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    string op = LineNumber + this._operationDictionary[ILOperation.Less];
                    return exprl + exprr + op;
                }
                case ExprToken.IsMore: {
                    string exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    string exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    string op = LineNumber + this._operationDictionary[ILOperation.More];
                    return exprl + exprr + op;
                }
            case ExprToken.IsLessOrEqual: {
                string exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                string exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                string op = LineNumber + this._operationDictionary[ILOperation.More] + Environment.NewLine;
                string ln = LineNumber + "ldc.i4 0" + Environment.NewLine;
                string ope = LineNumber + this._operationDictionary[ILOperation.Neg];
                return exprl + exprr + op + ln + ope;
            }
                case ExprToken.IsMoreOrEqual: {
                    string exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    string exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    string op = LineNumber + this._operationDictionary[ILOperation.Less] + Environment.NewLine;
                        string ln = LineNumber + "ldc.i4 0" + Environment.NewLine;
                    string ope = LineNumber + this._operationDictionary[ILOperation.Neg];
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
                    string expr = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    string lineNum = LineNumber;
                    string ln = lineNum + "ldc.i4 0" + Environment.NewLine;
                    expr = expr.Replace("{end line}", lineNum.Replace(":", ""));
                    string op = LineNumber + this._operationDictionary[ILOperation.Neg];
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

        public string AssignExprToIL(Expression node)
        {
            string assignString = this.ExpressionToIL( node.RightNode) + Environment.NewLine;
            string writeOpertion = "";
            if (node.LeftNode is ArrCall)
            {
                var arr = (ArrCall)node.LeftNode;
                string arrCall;
                if (arr.Arr.IsGlobal)
                {
                    arrCall = LineNumber + this._operationDictionary[ILOperation.ReadField] + this.Offset + arr.Name +
                              Environment.NewLine;
                }
                else
                {
                    if (arr.Arr.IsMethodArg)
                    {
                        arrCall = LineNumber + this._operationDictionary[ILOperation.ReadMethodArg] + this.Offset +
                              arr.Arr.Number + Environment.NewLine;
                    }
                    else
                    {
                        arrCall = LineNumber + this._operationDictionary[ILOperation.ReadLocalVariable] + this.Offset +
                              arr.Arr.Number + Environment.NewLine;
                    }
                }
                string index = this.ExpressionToIL(arr.Index) + Environment.NewLine;
                string righte = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                string write;
                if (arr.Arr.DataType == Type.ArrString) {
                    write = this._operationDictionary[ILOperation.WriteArrRefElement];
                }
                else {
                    write = this._operationDictionary[ILOperation.WriteArrStructElement];
                }
                
                return arrCall + index + righte + LineNumber + write;

            }
            string writeLineNumber = "";
            if ((node.LeftNode as VariableNode).IsGlobal) {
                string field = this.Reader(Template.CallField);
                field = field.Replace("{type}", this.ToCILVariableType((node.LeftNode as VariableNode).DataType));
                field = field.Replace("{name}", (node.LeftNode as VariableNode).Name);
                writeLineNumber = LineNumber;
                writeOpertion = writeLineNumber + this._operationDictionary[ILOperation.WriteField] + this.Offset + field;
            }

            else {
                writeLineNumber = LineNumber;
                if ((node.LeftNode as VariableNode).IsMethodArg)
                {
                    writeOpertion = writeLineNumber + this._operationDictionary[ILOperation.WriteMethodArg];
                }
                else
                {
                    writeOpertion = writeLineNumber + this._operationDictionary[ILOperation.WriteLocalVariable];
                }
                writeOpertion += this.Offset + (node.LeftNode as VariableNode).Number;
            }
            assignString = assignString.Replace("{end line}", writeLineNumber.Replace(":", ""));
            string writeAssignString = writeOpertion;
            return assignString + writeAssignString;
        }

        private string GenerateAddExpr(Expression node) {
            var left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            string right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right +  LineNumber + this._operationDictionary[ILOperation.Add];
        }

        private string GenerateSubExpr(Expression node)
        {
            string left =  this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            string right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right +  LineNumber + this._operationDictionary[ILOperation.Sub];
        }

        private string GenerateMultExpr(Expression node)
        {
            string left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            string right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right + LineNumber + this._operationDictionary[ILOperation.Mul];
        }

        private string GenerateDivExpr(Expression node)
        {
            string left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            string right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right +LineNumber+ this._operationDictionary[ILOperation.Div];
        }

        private string GenerateConstIL(Literals literal)
        {
            string result = "";

            switch (literal.DataType)
            {
                case Type.VarInt:
                    result = this._operationDictionary[ILOperation.IntConstLoad] + this.Offset + literal.Value.ToString();
                    break;
                case Type.VarFloat:
                    break;
                case Type.VarString:
                    return this._operationDictionary[ILOperation.StringConstLoad] + this.Offset + literal.Value.ToString();
                case Type.VarChar:
                    return this._operationDictionary[ILOperation.IntConstLoad] + this.Offset +
                           ((int) ((char) literal.Value)).ToString();
                case Type.VarBool:
                    string boolRes = literal.Value.ToString() == "False" ? "0" : "1";
                    return this._operationDictionary[ILOperation.IntConstLoad] + this.Offset + boolRes;
                default:
                    throw new ArgumentOutOfRangeException($"GenerateConstIL странный тип {literal.DataType}");
            }


            return result;
        }

        #endregion
    }
}
