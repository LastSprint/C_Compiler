using System;
using CompilerConsole.Parser.Nodes.AbstractNodes;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes {
    /// <summary>
    /// Узел, содержащий тело
    /// </summary>
    [Serializable]
    public abstract class BodyNode : Node {
        /// <summary>
        /// Тело узла
        /// </summary>
        public BodyTable Body { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя узла</param>
        /// <param name="dataType">Тип данных узла</param>
        /// <param name="body">Тело узла</param>
        /// <param name="wrapBody">Тело, включающее этот узел</param>
        public BodyNode(string name, string dataType, BodyTable body, BodyTable wrapBody) : base(name, dataType, wrapBody) {
            this.Body = body;
        }

        public BodyNode() {
            
        }

    }
}
