using System;
using CompilerConsole.Parser.Interfaces;
using CompilerConsole.Parser.Nodes.AbstractNodes;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes {
    /// <summary>
    /// Описывает узел для переменной
    /// </summary>
    [Serializable]
    public class StackVariableNode : StackNode
    {
        private static long _tempVariableCounter = 0;

        public StackVariableNode(string name, string dataType, BodyTable wrapBodyTable)
            : base(name, dataType, wrapBodyTable) {

        }

        public override Node AssignExpression { get; set; }


#region Fabric
        public static StackVariableNode CreateTempNode(string dataType)
        {
            return new StackVariableNode(_tempVariableCounter++.ToString(), dataType, null);
        }
#endregion
    }
}
