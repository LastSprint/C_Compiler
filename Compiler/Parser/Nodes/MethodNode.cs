using System;
using System.Collections.Generic;
using CompilerConsole.Parser.Nodes.AbstractNodes;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes
{
    /// <summary>
    /// Узел для описания функции
    /// </summary>
    [Serializable]
    public class MethodNode:BodyNode {
        /// <summary>
        /// Коллекция узлов - аргументов функции
        /// </summary>
        public IList<VariableNode> Args;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя токена</param>
        /// <param name="body">Тело метода</param>
        /// <param name="wrapBody">Тело, в которое вложен метод</param>
        /// <param name="dataType">Возвращаемый тип данных</param>
        /// <param name="args">Коллекция аргументов функции</param>
        public MethodNode(string name, BodyTable body,BodyTable wrapBody, string dataType = "void", IList<VariableNode> args = null ) : base(name, dataType,body, wrapBody) {
            if (args != null) {
                this.Args = args;
            }
            else {
                this.Args = new List<VariableNode>();
            }
        }

        /// <summary>
        /// Добавляет аргумент к коллекции аргументов функции
        /// </summary>
        /// <param name="node"></param>
        public void AddArg(VariableNode node) {
            this.Args.Add(node);
        }

        public MethodNode() {
            
        }
    }
}
