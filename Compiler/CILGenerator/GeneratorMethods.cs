﻿using System;
using System.Collections.Generic;
using System.Data;
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

        /// <summary>
        /// IL_
        /// </summary>
        public static string PreLineNumber = "IL_";
        /// <summary>
        /// Это символ табуляции
        /// </summary>
        public static string Offset = "\t";

        /// <summary>
        /// Генерирует IL код для методы
        /// </summary>
        /// <param name="method">Метод, для которого нужно сгенерировать IL код</param>
        /// <returns></returns>
        private string GenerateCILMethod(MethodNode method) {

            StringBuilder methodCIL = new StringBuilder();
            string startMethodCIL;

            #region Method start
            if (method.Name == "main") {
                startMethodCIL = this.Reader(Template.DeclMainFunc);
            }
            else {
                startMethodCIL = this.Reader(Template.StartFuncDecl);
            }
          
            startMethodCIL = startMethodCIL.Replace(this.cilReplacedToken[CILReplacedToken.MethodName], method.Name);
            //Генерирем аргументы и включаем их в шаблон
            startMethodCIL = startMethodCIL.Replace(this.cilReplacedToken[CILReplacedToken.MethodArgs], this.GenerateArgs(method));
#endregion

            #region Methpd body
            methodCIL.AppendLine(startMethodCIL);
            //Генерация декларации локальных переменных
            methodCIL.AppendLine(this.GenerateLocalVariableDeclaration(method));
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
                args.Append(Generator.Offset + this.GenerateFuncArg(variableNode));
                if (method.ArgList.Count > 1 && i != method.ArgList.Count - 1)
                {
                    args.Append(",");
                }
                args.AppendLine();
            }

            return args.ToString();
        }

        /// <summary>
        /// Гененрирует IL код, отвечающий за объявление локальныхп еременных в функции
        /// </summary>
        /// <param name="method">Метод, для которого нужно сгенерировать IL</param>
        /// <returns>Сгенерированный IL код</returns>
        private string GenerateLocalVariableDeclaration(MethodNode method) {
            //Пока будем парсить только делкарацию локальных переменных в методе (CIL код понятнее чем то говно, которое у меня в XML генерится)
            StringBuilder localVariables = new StringBuilder();

            List<VariableNode> variables = new List<VariableNode>();
            //Сначала выбираем все объявления переменных
            foreach (var bodyNode in method.Body.Nodes)
            {
                if (bodyNode is VariableNode && !(bodyNode as VariableNode).IsMethodArg)
                {
                    variables.Add(bodyNode as VariableNode);
                }
            }
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

            string localVardeclTemplate = this.Reader(Template.LocalvariableDeclaration);
            return localVardeclTemplate.Replace(this.cilReplacedToken[CILReplacedToken.Variables], localVariables.ToString());
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

       /* private string GenerateExpresseionFromNode(Node node) {
            if (node is Expression)
            {
                return this.ActionExprToIL(node as Expression);
            }
            else if (node is MethCall) {
                var methCallNode = node as MethCall;
                StringBuilder methodCall = new StringBuilder();
                foreach (var sendArg in methCallNode.SendArgs) {
                    methodCall.AppendLine(this.ExpressionToIL(sendArg));
                }

                if (methCallNode.Method.Name == Parser.Parser.WriteMethodName) {
                    methodCall.AppendLine(this._operationDictionary[ILOperation.Call] + Generator.Offset +  this.Reader(Template.ConsoleWriteLine)
                        .Replace("{type}", this.ToCILVariableType(methCallNode.SendArgs[0].DataType)));

                }
                else if (methCallNode.Method.Name == Parser.Parser.ReadMethodName) {
                    //Если вызываем ввод из консоли
                    throw new NotImplementedException(@"Сори, но ввода в консоль пока нету (:");
                }
                else {
                    throw new NotImplementedException(@"Сорян, но вызывать свой метод не получтся пока (:");
                    //Костомный метод
                }
                return methodCall.ToString();
            }

            return null;
        }
        */

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
            return $"{Generator.Offset} [{node.Number}] {this.ToCILVariableType(node.DataType)} {node.Name}";
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
                methodCall.AppendLine(this.ExpressionToIL(sendArg));

            }

            if (methCallNode.Method.Name.Contains(Parser.Parser.WriteMethodName)) {
                string t = this.Reader(Template.ConsoleWriteLine);
                methodCall.Append(this._operationDictionary[ILOperation.Call] + Generator.Offset + this.Reader(Template.ConsoleWriteLine)
                    .Replace("{type}", this.ToCILVariableType(methCallNode.SendArgs[0].DataType)));
                t = methodCall.ToString();
            }
            else if (methCallNode.Method.Name == Parser.Parser.ReadMethodName)
            {
                //Если вызываем ввод из консоли
                methodCall.AppendLine(this._operationDictionary[ILOperation.Call] + Generator.Offset +
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
                methodCall.AppendLine(this._operationDictionary[ILOperation.Call] + Generator.Offset + method);
            }
            return methodCall.ToString();
        }

#region Utils
        public string ExpressionToIL(Node node)
        {
            if (node is StructVariableNode)
            {
                var varNode = (VariableNode) node;
                if (varNode.IsGlobal) {
                    string field = this.Reader(Template.CallField);
                    field = field.Replace("{type}", this.ToCILVariableType(varNode.DataType));
                    field = field.Replace("{name}", varNode.Name);
                    return this._operationDictionary[ILOperation.ReadField] + Generator.Offset + field;
                }
                var operation = varNode.IsMethodArg ? this._operationDictionary[ILOperation.ReadMethodArg] : this._operationDictionary[ILOperation.ReadLocalVariable];

                return operation + Generator.Offset + varNode.Number;
            }

            if (node is ArrCall)
            {
                /* 
                 *         ldloc.0   - Загружаем массив
                 IL_0009:  ldc.i4.0  - Индекс по которому обращаемся
                 IL_000c:  stelem.i4    - записываем 
                */
                var arr = (ArrCall) node;
                string arrCall;
                if (arr.Arr.IsGlobal) {
                    arrCall = this._operationDictionary[ILOperation.ReadField] + Generator.Offset + arr.Name +
                              Environment.NewLine;
                }
                else {
                    arrCall = this._operationDictionary[ILOperation.ReadLocalVariable] + Generator.Offset +
                              arr.Arr.Number + Environment.NewLine;
                }
                string index = this.ExpressionToIL(arr.Index) + Environment.NewLine;
                string load;
                if (arr.Arr.DataType == Type.ArrString) {
                    load = this._operationDictionary[ILOperation.ReadArrRefElement];
                }
                else {
                    load = this._operationDictionary[ILOperation.ReadArrStructElement];
                }

                
                return arrCall + index + load;
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
                return this.GenerateConstIL((Literals) node);
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
                arrDecl = arrDecl.Replace("{type}", t) + Environment.NewLine;
                string writeArr = "";
                if (arr.IsGlobal) {
                    writeArr = this._operationDictionary[ILOperation.WriteField] + Generator.Offset + arr.Name + Environment.NewLine;
                }
                else {
                    writeArr = this._operationDictionary[ILOperation.WriteLocalVariable] + Generator.Offset + arr.Number + Environment.NewLine;
                }
                return Environment.NewLine +  arrSize + arrDecl + writeArr;
            }
            return null;
        }

        public string ActionExprToIL(Expression node)
        {
            switch (node.ExprToken)
            {
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
                    return this.GenerateAddExpr(node);
                case ExprToken.Sub:
                    return this.GenerateSubExpr(node);
                case ExprToken.Mult:
                    return this.GenerateMultExpr(node);
                case ExprToken.Div:
                    return this.GenerateDivExpr(node);
                case ExprToken.Conj:
                    break;
                case ExprToken.Dij:
                    break;
                case ExprToken.Neg:
                    break;
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
            string assignString = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            string writeOpertion = "";

            if (node.LeftNode is ArrCall)
            {
                var arr = (ArrCall)node.LeftNode;
                string arrCall;
                if (arr.Arr.IsGlobal)
                {
                    arrCall = this._operationDictionary[ILOperation.ReadField] + Generator.Offset + arr.Name +
                              Environment.NewLine;
                }
                else
                {
                    arrCall = this._operationDictionary[ILOperation.ReadLocalVariable] + Generator.Offset +
                              arr.Arr.Number + Environment.NewLine;
                }
                string index = this.ExpressionToIL(arr.Index) + Environment.NewLine;
                string righte = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                string write;
                if (arr.Arr.DataType == Type.ArrString) {
                    write = this._operationDictionary[ILOperation.WriteArrRefElement] + Environment.NewLine;
                }
                else {
                    write = this._operationDictionary[ILOperation.WriteArrStructElement] + Environment.NewLine;
                }
                
                return arrCall + index + righte + write;

            }


            if ((node.LeftNode as VariableNode).IsGlobal) {
                string field = this.Reader(Template.CallField);
                field = field.Replace("{type}", this.ToCILVariableType((node.LeftNode as VariableNode).DataType));
                field = field.Replace("{name}", (node.LeftNode as VariableNode).Name);
                writeOpertion = this._operationDictionary[ILOperation.WriteField] + Generator.Offset + field;
            }
            else {
                if ((node.LeftNode as VariableNode).IsMethodArg)
                {
                    writeOpertion = this._operationDictionary[ILOperation.WriteMethodArg];
                }
                else
                {
                    writeOpertion = this._operationDictionary[ILOperation.WriteLocalVariable];
                }
                writeOpertion += Generator.Offset + (node.LeftNode as VariableNode).Number;
            }

            string writeAssignString = writeOpertion;
            return assignString + writeAssignString;
        }

        private string GenerateAddExpr(Expression node) {
            var left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            string right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right +  this._operationDictionary[ILOperation.Add];
        }

        private string GenerateSubExpr(Expression node)
        {
            string left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            string right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right +  this._operationDictionary[ILOperation.Sub];
        }

        private string GenerateMultExpr(Expression node)
        {
            string left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            string right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right + this._operationDictionary[ILOperation.Mul];
        }

        private string GenerateDivExpr(Expression node)
        {
            string left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            string right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right + this._operationDictionary[ILOperation.Div];
        }

        private string GenerateConstIL(Literals literal)
        {
            string result = "";

            switch (literal.DataType)
            {
                case Type.VarInt:
                    result = this._operationDictionary[ILOperation.IntConstLoad] + Generator.Offset + literal.Value.ToString();
                    break;
                case Type.VarFloat:
                    break;
                case Type.VarString:
                    return  this._operationDictionary[ILOperation.StringConstLoad] + Generator.Offset + literal.Value.ToString();
                case Type.VarChar:
                    return  this._operationDictionary[ILOperation.IntConstLoad] + Generator.Offset +
                           ((int) ((char) literal.Value)).ToString();
                case Type.VarBool:
                    string boolRes = literal.Value.ToString() == "False" ? "0" : "1";
                    return this._operationDictionary[ILOperation.IntConstLoad] + Generator.Offset + boolRes;
                default:
                    throw new ArgumentOutOfRangeException($"GenerateConstIL странный тип {literal.DataType}");
            }


            return result;
        }

        #endregion
    }
}
