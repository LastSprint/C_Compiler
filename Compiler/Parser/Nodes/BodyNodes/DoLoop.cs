using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CompilerConsole.Parser.Nodes.BodyNodes
{
    class DoLoop:BodyNode
    {
        public Node Condition { get; set; }

        public DoLoop(Body body) : base("DoLoop", Type.NotAType, body) {
        }

        public override void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("DoLoop");
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
