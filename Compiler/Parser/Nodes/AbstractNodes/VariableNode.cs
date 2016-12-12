using System;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes.AbstractNodes {
    [Serializable]
    public abstract class VariableNode : Node {

        private static int _counter;
        public virtual Node AssignExpression { get; set; }
        public int VariableId { get; set; }


        protected VariableNode(string name, string dataType, BodyTable wrapBodyTable)
            : base(name, dataType, wrapBodyTable) {
        }

        protected VariableNode(string name, string dataType, BodyTable wrapBodyTable, Node assExpr)
            : this(name, dataType, wrapBodyTable) {
            this.AssignExpression = assExpr;
        }
    }
}
