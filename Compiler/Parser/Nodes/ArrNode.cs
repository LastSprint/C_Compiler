using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CompilerConsole.Parser.Nodes
{
    public class ArrNode : VariableNode
    {
        public int Length { get; set; }

        public ArrNode(string name, Type type, int length) : base(name, type) {
            this.Length = length;
        }


        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("ArrayNode");
            writer.WriteAttributeString("Name", this.Name);
            writer.WriteAttributeString("DataType", this.DataType.ToString());
            writer.WriteAttributeString("Length", this.Length.ToString());
            writer.WriteEndElement();
        }
    }
}
