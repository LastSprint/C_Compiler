using System;
using System.Xml;

namespace CompilerConsole.Parser.Nodes
{
    public abstract class VariableNode:Node
    {
        public VariableNode(string name, Type type) : base(name, type) {
        }

        public VariableNode():base() {
            
        }

        public virtual Node Assign { get; set; }

        public override void WriteXml(XmlWriter writer) {
            base.WriteXml(writer);
        }
    }
}
