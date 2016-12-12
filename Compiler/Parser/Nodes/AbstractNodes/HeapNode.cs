using System;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes.AbstractNodes
{
    [Serializable]
    public abstract class HeapNode:VariableNode
    {
        public abstract bool IsInstantience { get; }

        protected HeapNode(string name, string dataType, BodyTable wrapBodyTable) : base(name, dataType, wrapBodyTable) {
            
        }
        protected HeapNode(string name, string dataType, BodyTable wrapBodyTable, Node assExpr) : base(name, dataType, wrapBodyTable, assExpr)
        {

        }
    }
}
