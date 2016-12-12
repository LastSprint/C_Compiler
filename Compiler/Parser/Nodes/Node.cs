using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CompilerConsole.Parser.Nodes {
    [Serializable]
    public enum Type {
        VarInt,
        VarFloat,
        VarString,
        VarChar,
        VarBool,

        ArrInt,
        ArrFloat,
        ArrString,
        ArrChar,
        ArrBool,

        Void,

        Error
    }

    [Serializable]
    public abstract class Node : IXmlSerializable {
        public Type DataType { get; set; }
        public string Name { get; set; }

        protected Node(string name, Type type) {
            this.Name = name;
            this.DataType = type;
        }

        protected Node() {

        }

        public virtual XmlSchema GetSchema() {
            return null;
        }

        public virtual void ReadXml(XmlReader reader) {
            throw new NotImplementedException();
        }

        public virtual void WriteXml(XmlWriter writer) {
            writer.WriteAttributeString("Name", this.Name);
            writer.WriteAttributeString("DataType", this.DataType.ToString());
        }
    }

}
