using System.Collections.Generic;
using System.Xml;

namespace CompilerConsole.Parser.Nodes
{
    public class MethodNode:BodyNode
    {
        public List<VariableNode> ArgList { get; set; }

        public MethodNode(string name, Type returnType, Body body, List<VariableNode> args) : base(name, returnType, body) {
            this.ArgList = args;
        }

        public MethodNode() {
            this.ArgList = new List<VariableNode>();
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("MethodNode");
            base.WriteXml(writer);
            writer.WriteStartElement("Args");
            foreach (var node in this.ArgList) {
                node.WriteXml(writer);
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
