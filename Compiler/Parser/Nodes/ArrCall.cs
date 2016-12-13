using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CompilerConsole.Parser.Nodes
{
    public class ArrCall:Node
    {
        public ArrNode Arr { get; set; }

        public Node Index { get; set; }

        public ArrCall(ArrNode arr) : base("ArrCall"+arr.Name, Node.ArrTypeToVarType(arr.DataType)) {
            this.Arr = arr;
        }

        public ArrCall() {
            
        }
        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("ArrCallNode");
            writer.WriteAttributeString("DataType", this.DataType.ToString());
            writer.WriteAttributeString("Arr", this.Arr.Name);
            writer.WriteStartElement("Index");
            this.Index.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
