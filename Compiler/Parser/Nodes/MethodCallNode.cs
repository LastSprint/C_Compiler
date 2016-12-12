using System;
using System.Collections.Generic;
using System.Text;
using CompilerConsole.Parser.Nodes.AbstractNodes;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes
{
    /// <summary>
    /// Вспомогательный класс - обертка.
    /// Возможно вообще нужен не будет
    /// </summary>
    [Serializable]
    class MethodCallNode:Node
    {
        public MethodNode Method { get; }
        public IList<Node> ArgList { get; }

        protected MethodCallNode(string name, string dataType, BodyTable wrapBodyTable) : base(name, dataType, wrapBodyTable) {
        }

        public MethodCallNode(MethodNode node, BodyTable wrapBodyTable, IList<Node> argList ) : this(node.Name, node.DataType, wrapBodyTable) {
            this.Method = node;
            this.ArgList = argList;
        }
    }
}
