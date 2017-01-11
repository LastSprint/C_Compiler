using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace CompilerConsole.Parser.Nodes.BodyNodes
{
    public abstract class BodyNode:Node, IEnumerable<Node>
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

        public IEnumerator<Node> GetEnumerator() {
            return this.Body.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }
    }
}
