using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CompilerConsole.Parser.Nodes
{
    public abstract class BodyNode:Node
    {
        public Body Body { get; set; }

        protected BodyNode(string name, Type type, Body body) : base(name, type) {
            this.Body = body;
        }

        protected BodyNode() {
            
        }

        public override void WriteXml(XmlWriter writer) {
            base.WriteXml(writer);
            this.Body.WriteXml(writer);
        }
    }
}
