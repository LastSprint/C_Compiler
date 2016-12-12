using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CompilerConsole.Parser.Nodes.AbstractNodes;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes {
    [Serializable]
    class ArrCallNode : VariableNode {
        public Node IndexExpression { get; set; }

        protected ArrCallNode(string name, string dataType, BodyTable wrapBodyTable) : base(name, dataType, wrapBodyTable) {
        }

        protected ArrCallNode(string name, string dataType, BodyTable wrapBodyTable, Node assExpr)
            : base(name, dataType, wrapBodyTable, assExpr) {
        }

        public ArrCallNode(ArrayNode arr, Node indexExpr, BodyTable table) : this(arr.Name, arr.VariableType, table, null) {
            this.IndexExpression = indexExpr;
        }

        public ArrCallNode(ArrayNode arr, Node indexExpr, Node assExpr, BodyTable table)
            : this(arr.Name, arr.VariableType, table, assExpr) {
            this.IndexExpression = indexExpr;
        }

        public override Node AssignExpression { get; set; }
    }
}
