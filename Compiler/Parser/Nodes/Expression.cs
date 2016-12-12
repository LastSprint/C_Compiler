using System;
using System.Collections.Generic;
using System.Text;
using CompilerConsole.Parser.Nodes.AbstractNodes;

namespace CompilerConsole.Parser.Nodes {
    [Serializable]
    public class Expression : Node {
        //Результирующийтип выражения

        private Node node1;
        private Node node2;

        public string Node1Type => this.node1.DataType;
        public string Node2Type => this.node2.DataType;

        public Expression(Node node1, Node node2, string operation) {
            base.Name = operation;
            this.node1 = node1;
            this.node2 = node2;
            base.DataType = this.IsValidTypes ? node1.DataType : "InvalidType";
        }

        //Проверяет соттветсвие типов между объектами операции
        public bool IsValidTypes {
            get { return String.Compare(node1.DataType, node2.DataType, StringComparison.Ordinal) == 0; }
        }

        public bool IsOperationValid() {
            return this.CheckOperationValid();
        }

        private bool CheckOperationValid() {
            if (!this.IsValidTypes) {
                return false;
            }
            else {
                //Эти операции определены только для базовых типов
                if (this.IsBaseType()) {
                    switch (base.Name) {
                        case "-":
                        case "+": {
                            if (this.IsChar() || this.IsDouble() || this.IsFloat() || this.IsInt() || this.IsString()) {
                                return true;
                            }
                            return false;
                        }
                        case "*":
                        case "/": {
                            if (this.IsDouble() || this.IsFloat() || this.IsInt()) {
                                return true;
                            }
                            return false;
                        }

                        case "||":
                        case "&&":
                        case "!": {
                            if (this.IsBool()) {
                                return true;
                            }
                            return false;
                        }
                    }
                }
                //Равно определеана для всех типов
                if (String.CompareOrdinal(this.DataType, "=") == 0) {
                    return true;
                }
                return false;
            }
        }

#region Types definition methods
        private bool IsInt() {
            return String.CompareOrdinal("int", this.DataType) == 0;
        }

        private bool IsString() {
            return String.CompareOrdinal("string", this.DataType) == 0;
        }

        private bool IsDouble() {
            return String.CompareOrdinal("double", this.DataType) == 0;
        }

        private bool IsFloat() {
            return String.CompareOrdinal("float", this.DataType) == 0;
        }

        private bool IsChar() {
            return String.CompareOrdinal("char", this.DataType) == 0;
        }

        private bool IsBool() {
            return String.CompareOrdinal("bool", this.DataType) == 0;
        }
#endregion
    }
}
