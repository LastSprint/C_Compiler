using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using CompilerConsole.Parser.Nodes;

namespace CompilerConsole.Parser {
    public class Body : IXmlSerializable {
        public List<Node> Nodes { get; set; }

        public Body WrapBody { get; set; }

        public Body() {
            this.Nodes = new List<Node>();
        }

        public Body(List<Node> nodes) {
            this.Nodes = nodes;
        }

        public Body(List<Node> nodes, Body wrapBody) : this(nodes) {
            this.WrapBody = wrapBody;
        }

        public XmlSchema GetSchema() {
            return null;
        }

        public void ReadXml(XmlReader reader) {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("Body");
            foreach (var node in this.Nodes) {
                node.WriteXml(writer);
            }
            writer.WriteEndElement();
        }

        public T FindNodeByName<T>(string name) where T : Node {
            foreach (var node in this.Nodes) {
                if (node.Name == name) {
                    return (T) node;
                }
            }
            return null;
        }

        public static T FindNodeByName<T>(string name, Body body) where T : Node {
            if (body == null) {
                return null;
            }

            foreach (var node in body.Nodes) {
                if (node.Name == name) {
                    return (T) node;
                }
            }

            return FindNodeByName<T>(name, body.WrapBody);
        }

    }

}