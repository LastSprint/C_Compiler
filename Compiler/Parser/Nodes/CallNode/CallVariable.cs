using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CompilerConsole.Parser.Nodes.CallNode
{
    public class CallVariable:Node
    {
        public VariableNode LeftNode { get; set; }
        public Node RightNode { get; set; }

        public CallVariable(Type type,VariableNode leftNode, Node rightNode, string name = "CallVariable") : base(name, type) {
            this.LeftNode = leftNode;
            this.RightNode = rightNode;
        }

        public CallVariable() {
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("CallVariable");
            writer.WriteAttributeString("Type", base.DataType.ToString());
            writer.WriteStartElement("LeftNode");
            this.LeftNode.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteStartElement("RightNode");
            this.RightNode.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
