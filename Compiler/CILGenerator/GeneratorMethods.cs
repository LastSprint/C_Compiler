using System.Collections.Generic;
using System.Text;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.BodyNodes;
using Type = CompilerConsole.Parser.Nodes.Type;

namespace CompilerConsole.CILGenerator
{

    public partial class Generator {
        /// <summary>
        /// IL_
        /// </summary>
        public static string PreLineNumber = "IL_";
        /// <summary>
        /// Это 4 пробела
        /// </summary>
        public static string Offset = "\t";
        private string GenerateCILMethod(MethodNode method) {
            StringBuilder methodCIL = new StringBuilder();
            string startMethodCIL;
            if (method.Name == "main") {
                startMethodCIL = this.Reader(Template.DeclMainFunc);
            }
            else {
                startMethodCIL = this.Reader(Template.StartFuncDecl);
            }
          
            startMethodCIL = startMethodCIL.Replace(this.cilReplacedToken[CILReplacedToken.MethodName], method.Name);
            //Парсим аргументы
            StringBuilder args = new StringBuilder();
            for (int i = 0; i < method.ArgList.Count; i++) {
                var variableNode = method.ArgList[i];
                args.Append("\t" + this.GenerateFuncArg(variableNode));
                if (method.ArgList.Count > 1 && i != method.ArgList.Count-1) {
                    args.Append(",");
                }
                args.AppendLine();
            }
            startMethodCIL = startMethodCIL.Replace(this.cilReplacedToken[CILReplacedToken.MethodArgs], args.ToString());
            methodCIL.AppendLine(startMethodCIL);
            //Генерация декларации локальных переменных
            methodCIL.AppendLine(this.GenerateLocalVariableDeclaration(method));
            //Генерация IL кода для выражений
            methodCIL.AppendLine(this.GenerateExpression(method));
            //Генерация IL кода для окончания декларации метода
            string methodEnd = this.Reader(Template.DeclFuncFinich);
            methodCIL.AppendLine(methodEnd);
            return methodCIL.ToString();
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
            foreach (Node node in method.Body.Nodes)
            {
                if (node is Expression)
                {
                    expressions.Append(Utils.ActionAxprToIL(node as Expression));
                }
            }
            return expressions.ToString();
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
            return $"\t [{node.Number}] {this.ToCILVariableType(node.DataType)} {node.Name}";
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
            }
            return null;
        }
    }
}
