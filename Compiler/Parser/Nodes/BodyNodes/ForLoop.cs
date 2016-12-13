using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CompilerConsole.Parser.Nodes.BodyNodes
{
    class ForLoop:BodyNode
    {
        public Node VarNode { get; set; }
        public Node CondNode { get; set; }
        public Node Incremental { get; set; }

        public ForLoop(Body body) : base("for", Type.NotAType, body) {
        }

        public override void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("ForLoop");

            writer.WriteStartElement("VarNode");
            this.VarNode.WriteXml(writer);
            writer.WriteEndElement();

            writer.WriteStartElement("CondNode");
            this.CondNode.WriteXml(writer);
            writer.WriteEndElement();

            writer.WriteStartElement("Increment");
            this.Incremental.WriteXml(writer);
            writer.WriteEndElement();

            writer.WriteStartElement("Body");
            this.Body.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

    }
}
