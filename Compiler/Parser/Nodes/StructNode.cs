using System;
using CompilerConsole.Parser.Interfaces;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes {
    [Serializable]
    class StructNode : BodyNode, IStructNode
    {

        public StructNode(string name, BodyTable body, BodyTable wrapBody, string dataType = "struct") : base(name, dataType, body, wrapBody) {
        } 
           

        public StructNode() {
            
        }
    }
}
