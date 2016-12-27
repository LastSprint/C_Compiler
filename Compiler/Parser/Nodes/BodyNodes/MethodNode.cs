using System.Collections.Generic;
using System.Xml;

namespace CompilerConsole.Parser.Nodes.BodyNodes
{
    public enum MethodType {
        Libr,
        Cust
    }

    public class MethodNode:BodyNode
    {
        public List<VariableNode> ArgList { get; set; }
        public MethodType MethodType { get; set; }


        public MethodNode(string name, Type returnType, Body body, List<VariableNode> args, MethodType methodType = MethodType.Cust) : base(name, returnType, body) {
            this.ArgList = args;
            this.MethodType = methodType;
        }

        public MethodNode() {
            this.ArgList = new List<VariableNode>();
        }

        public override void WriteXml(XmlWriter writer) {

            if (this.Body == null || this.MethodType == MethodType.Libr) {
                return;
            }

            writer.WriteStartElement("MethodNode");
            writer.WriteAttributeString("MethodType", this.MethodType.ToString());
            base.WriteXml(writer);
            writer.WriteStartElement("Args");
            foreach (var node in this.ArgList) {
                node.WriteXml(writer);
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        /// <summary>
        /// Проверяет, является ли данная переменная яргументом данного метода
        /// Сравнение выполняется с помощью Equals
        /// </summary>
        /// <param name="variableNode">Переменная, которую необходимо проверить на принадлежность к аргументам данного метода</param>
        /// <returns>Возвращает true если переменная принадлежит к аргументам метода</returns>
        public bool IsArg(VariableNode variableNode) {

            foreach (var node in this.ArgList) {
                if (node.Equals(variableNode)) {
                    return true;
                }
            }
            return false;
        }

    }
}
