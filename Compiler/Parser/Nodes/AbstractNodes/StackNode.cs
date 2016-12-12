using System;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes.AbstractNodes
{
    /// <summary>
    /// Узел для описания узлов, которые хранятся в стэке
    /// </summary>
    [Serializable]
    public abstract class StackNode : VariableNode
    {
        protected StackNode(string name, string dataType, BodyTable wrapBodyTable) : base(name, dataType, wrapBodyTable)
        {
        }
    }
}
