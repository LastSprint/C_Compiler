using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CompilerConsole.Parser.Nodes.BodyNodes
{
    class WhileLoop:BodyNode
    {
        public Node Condition { get; set; }

        public WhileLoop(Body body) : base("WhileLoop", Type.NotAType, body) {
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("WhileLoop");
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
