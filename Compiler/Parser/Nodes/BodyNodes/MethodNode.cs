using System.Collections.Generic;
using System.Xml;

namespace CompilerConsole.Parser.Nodes.BodyNodes
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
