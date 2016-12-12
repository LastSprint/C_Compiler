using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerConsole.Parser.Nodes {
    enum ExprToken {
        IsEqual,
        IsLess,
        IsMore,
        IsLessOrEqual,
        IsMoreOrEqual,
        Add,
        Sub,
        Mult,
        Div,
        Conj,
        Dij,
        Neg,
        Ass
    }

    class Expression : Node {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }

        public ExprToken ExprToken { get; set; }

        public bool IsValid => this.DataType != Type.Error;

        public Expression(Node leftNode, Node rightNode, ExprToken exprToken) {
            this.LeftNode = leftNode;
            this.RightNode = rightNode;
            this.ExprToken = exprToken;
            this.Name = "expr";
            this.DataType = leftNode.DataType == rightNode.DataType ? leftNode.DataType : Type.Error;
        }

        public void ChecValidExpr() {
            if (this.LeftNode.DataType != this.RightNode.DataType) {
                this.DataType = Type.Error;
                return;
            }
            else {
                this.DataType = this.LeftNode.DataType;
            }

            switch (this.ExprToken) {
                case ExprToken.IsEqual: {
                    bool type = this.DataType == Type.VarBool;
                    type = type || this.DataType == Type.VarChar;
                    type = type || this.DataType == Type.VarFloat;
                    type = type || this.DataType == Type.VarInt;
                    if (!type) {
                        this.DataType = Type.Error;
                    }
                    break;
                }
                case ExprToken.IsLess: {
                    bool type = this.DataType == Type.VarChar;
                    type = type || this.DataType == Type.VarFloat;
                    type = type || this.DataType == Type.VarInt;
                    if (!type) {
                        this.DataType = Type.Error;
                    }
                    break;
                }
                case ExprToken.IsMore: {
                    bool type = this.DataType == Type.VarChar;
                    type = type || this.DataType == Type.VarFloat;
                    type = type || this.DataType == Type.VarInt;
                    if (!type) {
                        this.DataType = Type.Error;
                    }
                    break;
                }
                case ExprToken.IsLessOrEqual: {
                    bool type = this.DataType == Type.VarChar;
                    type = type || this.DataType == Type.VarFloat;
                    type = type || this.DataType == Type.VarInt;
                    if (!type) {
                        this.DataType = Type.Error;
                    }
                    break;
                }
                case ExprToken.IsMoreOrEqual: {
                    bool type = this.DataType == Type.VarChar;
                    type = type || this.DataType == Type.VarFloat;
                    type = type || this.DataType == Type.VarInt;
                    if (!type) {
                        this.DataType = Type.Error;
                    }
                    break;
                }
                case ExprToken.Add: {
                    bool type = this.DataType == Type.VarChar;
                    type = type || this.DataType == Type.VarFloat;
                    type = type || this.DataType == Type.VarInt;
                    if (!type) {
                        this.DataType = Type.Error;
                    }
                    break;
                }
                case ExprToken.Sub: {
                    bool type = this.DataType == Type.VarChar;
                    type = type || this.DataType == Type.VarFloat;
                    type = type || this.DataType == Type.VarInt;
                    if (!type) {
                        this.DataType = Type.Error;
                    }
                    break;
                }
                case ExprToken.Mult: {
                    bool type = this.DataType == Type.VarChar;
                    type = type || this.DataType == Type.VarFloat;
                    type = type || this.DataType == Type.VarInt;
                    if (!type) {
                        this.DataType = Type.Error;
                    }
                    break;
                }
                case ExprToken.Div: {
                    bool type = this.DataType == Type.VarChar;
                    type = type || this.DataType == Type.VarFloat;
                    type = type || this.DataType == Type.VarInt;
                    if (!type) {
                        this.DataType = Type.Error;
                    }
                    break;
                }
                case ExprToken.Conj: {
                    if (this.DataType != Type.VarBool) {
                        this.DataType = Type.Error;
                    }
                    break;
                }
                case ExprToken.Dij: {
                    if (this.DataType != Type.VarBool) {
                        this.DataType = Type.Error;
                    }
                    break;
                }
                case ExprToken.Neg: {

                    if (this.DataType != Type.VarBool) {
                        this.DataType = Type.Error;
                    }
                    break;
                }
                case ExprToken.Ass: {
                    break;
                }
            }
        }
    }
}
