using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CompilerConsole.Parser.Nodes
{
    public class MethCall:Node
    {
        public MethodNode Method { get; set; }

        public List<Node> SendArgs { get; set; }

        public MethCall(MethodNode method) : base("MethCall"+ method.Name, method.DataType) {
            this.Method = method;
            this.SendArgs = new List<Node>();
        }

        public MethCall() {
        }


        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("MethCallNode");
            writer.WriteAttributeString("DataType", this.DataType.ToString());
            writer.WriteAttributeString("Method", this.Method.Name);
            writer.WriteStartElement("SendArgs");
            foreach (var sendArg in this.SendArgs) {
                sendArg.WriteXml(writer);
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
