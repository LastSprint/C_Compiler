using System;
using CompilerConsole.Parser.Nodes.AbstractNodes;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes
{
    [Serializable]
    public class ArrayNode:HeapNode
    {
        public string VariableType { get; }
        public override bool IsInstantience => this.AssignExpression != null;

        public Node[] Array { get; }

        public ArrayNode(string name, string dataType, BodyTable wrapBodyTable, Node expr = null) : base(name, dataType+"_", wrapBodyTable) {
            this.AssignExpression = expr;
            this.VariableType = dataType;
        }

        public void Instantience(Node length) {
            this.AssignExpression = length;
        }

        public override Node AssignExpression { get; set; }
    }
}
