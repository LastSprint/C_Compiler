using System.Xml;

namespace CompilerConsole.Parser.Nodes.BodyNodes
{
    public class IfNode:BodyNode
    {
        public Node Condition { get; set; }

        public IfNode(Body body) : base("IfNode", Type.NotAType, body) {
        }

        public IfNode() {
            
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("IfNode");
            writer.WriteStartElement("Condition");
            this.Condition.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteStartElement("Body");
            this.Body.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
