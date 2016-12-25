using System;
using System.Runtime.CompilerServices;
using System.Text;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.BodyNodes;
using Type = CompilerConsole.Parser.Nodes.Type;

namespace CompilerConsole.CILGenerator
{
    public partial class Generator
    {
        private string GenerateCILMethod(MethodNode method) {
            StringBuilder methodCIL = new StringBuilder();
            string startMethodCIL;
            if (method.Name == "Main") {
                startMethodCIL = this.Reader(Template.DeclMainFunc);
            }
            else {
                startMethodCIL = this.Reader(Template.StartFuncDecl);
            }
          
            startMethodCIL = startMethodCIL.Replace(this.cilReplacedToken[CILReplacedToken.MethodName], method.Name);

            StringBuilder args = new StringBuilder();
            for (int i = 0; i < method.ArgList.Count; i++) {
                var variableNode = method.ArgList[i];
                args.Append("\t" + this.GenerateCILFuncArg(variableNode));
                if (method.ArgList.Count > 1 && i != method.ArgList.Count-1) {
                    args.Append(",");
                }
                args.AppendLine();
            }
            startMethodCIL = startMethodCIL.Replace(this.cilReplacedToken[CILReplacedToken.MethodArgs], args.ToString());
            methodCIL.AppendLine(startMethodCIL);
            
            //Пока будем парсить только делкарацию локальных переменных в методе (CIL код понятнее чем то говно, которое у меня в XML генерится)
            StringBuilder localVariables = new StringBuilder();
            for (int i = 0; i < method.Body.Nodes.Count; i++) {
                var node = method.Body.Nodes[i];

                if (node is VariableNode && !method.IsArg(node as VariableNode)) {
                    localVariables.Append(this.GenerateCILVarDecl(node as VariableNode));
                    if (method.Body.Nodes.Count > 1 && i!=method.Body.Nodes.Count-1) {
                        localVariables.Append(",");
                    }
                    localVariables.AppendLine();
                }
            }

            string localVardeclTemplate = this.Reader(Template.LocalvariableDeclaration);
            methodCIL.AppendLine(localVardeclTemplate.Replace(this.cilReplacedToken[CILReplacedToken.Variables],localVariables.ToString()));
            string methodEnd = this.Reader(Template.DeclFuncFinich);

            methodCIL.AppendLine(methodEnd);
            return methodCIL.ToString();
        }

        private string GenerateCILFuncArg(VariableNode variable) {
            if (variable is StructVariableNode) {
                var structVariable = variable as StructVariableNode;
                return $"{this.ToCILVariableType(variable.DataType)} {variable.Name}";
            }
            else {
                var structVariable = variable as ArrNode;
                return $"{this.ToCILVariableType(variable.DataType)} {variable.Name}";
            }
        }

        private string GenerateCILVarDecl(VariableNode node) {
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
