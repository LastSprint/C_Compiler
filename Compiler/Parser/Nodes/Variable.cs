using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CompilerConsole.Parser.Nodes {
    public class StructVariableNode : VariableNode {
        public StructVariableNode(string name, Type type) : base(name, type) {
        }

        public StructVariableNode() : base() {

        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("VariableNode");
            base.WriteXml(writer);
            writer.WriteEndElement();
        }

    }
}
