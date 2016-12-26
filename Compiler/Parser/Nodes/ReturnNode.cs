using System.Xml;

namespace CompilerConsole.Parser.Nodes
{
    public class ReturnNode:Node {

        /// <summary>
        /// Значение, которое должно вернуться из функции
        /// </summary>
        private Node ReturnedValue { get; set; }

        public ReturnNode(Type type,Node returndValue, string name = "return") : base(name, type) {
            this.ReturnedValue = returndValue;
        }

        public ReturnNode() {
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("ReturnNode");
            base.WriteXml(writer);
            writer.WriteStartElement("ReturnedValue");
            this.ReturnedValue.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
