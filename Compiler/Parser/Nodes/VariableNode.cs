using System;
using System.Xml;

namespace CompilerConsole.Parser.Nodes
{
    [Serializable]
    public class VariableNode:Node
    {
        public VariableNode(string name, Type type) : base(name, type) {
        }

        public VariableNode():base() {
            
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("VariableNode");
            base.WriteXml(writer);
            writer.WriteEndElement();
        }
    }
}
