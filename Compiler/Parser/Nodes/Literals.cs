using System;
using System.Xml;

namespace CompilerConsole.Parser.Nodes
{
    class Literals : Node {
        public object Value { get; set; }

        public Literals(string name, Type type, object value) : base(name, type) {
            this.Value = value;
        }

        public string GetString() {
            if (this.DataType == Type.VarString) {
                return (String) this.Value;
            }
            return null;
        }

        public char? GetChar()
        {
            if (this.DataType == Type.VarChar)
            {
                return (Char) this.Value;
            }
            return null;
        }

        public int? GetInt()
        {
            if (this.DataType == Type.VarInt)
            {
                return (int)this.Value;
            }
            return null;
        }

        public float? GetFloatl()
        {
            if (this.DataType == Type.VarBool)
            {
                return (float)this.Value;
            }
            return null;
        }

        public bool? GetBool()
        {
            if (this.DataType == Type.VarBool)
            {
                return (bool)this.Value;
            }
            return null;
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("Literal");
            base.WriteXml(writer);
            writer.WriteAttributeString("Value", this.Value.ToString());
            writer.WriteEndElement();
        }
    }
}
