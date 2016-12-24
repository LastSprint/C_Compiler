using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CompilerConsole.Parser.Nodes
{
    public class ArrNode : VariableNode
    {
        public Node Length { get; set; }

        public ArrNode(string name, Type type, Node length) : base(name, type) {
            this.Length = length;
        }

        public ArrNode() {
            
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("ArrayNode");
            writer.WriteAttributeString("Name", this.Name);
            writer.WriteAttributeString("DataType", this.DataType.ToString());
            writer.WriteStartElement("Length");
            this.Length?.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
