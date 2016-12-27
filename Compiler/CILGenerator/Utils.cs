using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.CallNode;
using Type = CompilerConsole.Parser.Nodes.Type;

namespace CompilerConsole.CILGenerator {

    public enum ILOperation {
        /// <summary>
        /// CIL синтаксис: ldc.i4 someLiterals(hex)
        /// </summary>
        IntConstLoad,

        /// <summary>
        /// CIL синтаксис:  ldloc.{variableNumber}
        /// </summary>
        ReadLocalVariable,

        /// <summary>
        /// CIL синтаксис:  stloc.{variableNumber}
        /// </summary>
        WriteLocalVariable,

        /// <summary>
        /// CIL синтаксис:  ldarg.{variableNumber}
        /// </summary>
        ReadMethodArg,

        /// <summary>
        /// CIL синтаксис:  ldloc.{variableNumber}
        /// </summary>
        WriteMethodarg,
        Add,
        Sub,
        Div

    }

    public static class Utils {
        private static Dictionary<ILOperation, string> _operationDictionary;

        static Utils() {
            _operationDictionary = new Dictionary<ILOperation, string>() {
                {ILOperation.IntConstLoad, "ldc.i4"},
                {ILOperation.ReadLocalVariable, "ldloc"},
                {ILOperation.WriteLocalVariable, "stloc"},
                {ILOperation.Add, "add"},
                {ILOperation.Sub, "sub"},
                {ILOperation.Div, "div"}
            };
        }

        public static string ActionAxprToIL(Expression node) {
            switch (node.ExprToken) {
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
                    return AssignExprToIL(node);
                    break;
                case ExprToken.Error:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return null;

        }

        public static string AssignExprToIL(Expression node) {
            string assignString = ExpressionToIL(node.RightNode) + Environment.NewLine;
            string writeAssignString = _operationDictionary[ILOperation.WriteLocalVariable] + Generator.Offset + (node.LeftNode as VariableNode).Number + Environment.NewLine;
            return assignString + writeAssignString;
        }

        public static string ExpressionToIL(Node node) {
            if (node is StructVariableNode) {
                throw new NotImplementedException(@"Парсинг переменных в IL пока не реализован");
            }

            if (node is ArrCall) {
                throw new NotImplementedException(@"Парсинг обращения к массиву в IL пока не реализован");
            }

            if (node is MethCall) {
                throw new NotImplementedException(@"Парсинг вызова метода в IL пока не реализован");
            }

            if (node is Expression) {
                throw new NotImplementedException(@"Парсинг выражений в IL пока не реализован");
            }

            if (node is Literals) {
                return GenerateConstIL(node as Literals);
            }

            throw new SyntaxErrorException(@"Случилась какая-то неведомая хуйня при парсинге выражения в IL");
        }

        private static string GenerateConstIL(Literals literal) {
            string result = "";

            switch (literal.DataType) {
                case Type.VarInt:
                    result = _operationDictionary[ILOperation.IntConstLoad] + Generator.Offset + literal.Value.ToString();
                    break;
                case Type.VarFloat:
                    break;
                case Type.VarString:
                    break;
                case Type.VarChar:
                    break;
                case Type.VarBool:
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"GenerateConstIL странный тип {literal.DataType}");
            }


            return result;
        }
    }
}
