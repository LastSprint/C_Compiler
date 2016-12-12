using System;
using CompilerConsole.Parser.Interfaces;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes
{
    /// <summary>
    /// Узел для класса
    /// </summary>
    [Serializable]
    public class ClassNode:BodyNode, IStructNode
    {
        public ClassNode(string name, BodyTable body, BodyTable wrapBody, string dataType = "class") : base(name, dataType, body, wrapBody) {
        }

        public ClassNode() {
            
        }

    }
}
