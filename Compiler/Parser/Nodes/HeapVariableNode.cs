using System;
using CompilerConsole.Parser.Nodes.AbstractNodes;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes {
    [Serializable]
    class HeapVariableNode : HeapNode {
        public HeapVariableNode(string name, string dataType, BodyTable wrapBodyTable)
            : base(name, dataType, wrapBodyTable) {
        }

        public HeapVariableNode(string name, string dataType, BodyTable wrapBodyTable, Node assExpr)
            : base(name, dataType, wrapBodyTable, assExpr) {
        }

        public override bool IsInstantience {
            get { return this.AssignExpression == null; }
        }

        public override Node AssignExpression { get; set; }
    }
}