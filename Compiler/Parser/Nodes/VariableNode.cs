using System;
using System.Xml;

namespace CompilerConsole.Parser.Nodes
{
    public abstract class VariableNode:Node
    {
        /// <summary>
        /// Указывает на то, является ли переменная аргументом функции
        /// </summary>
        public bool IsMethodArg { get; set; }
        /// <summary>
        /// Указывает на то, что эта переменная является глобальной в смысле разрабатываемого языка
        /// </summary>
        public bool IsGlobal { get; set; }

        public int Number { get; set; }

        public VariableNode(string name, Type type, bool isMethodArg) : base(name, type) {
            this.IsMethodArg = isMethodArg;
            this.IsGlobal = false;
        }

        public VariableNode():base() {
            
        }

        public virtual Node Assign { get; set; }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteAttributeString("IsMethodArg", this.IsMethodArg.ToString());
            base.WriteXml(writer);
        }
    }
}
