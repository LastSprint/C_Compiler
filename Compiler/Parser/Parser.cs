﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Antlr.Runtime.Tree;
using CompilerConsole.Parser.Exceptions;
using CompilerConsole.Parser.Nodes;
using Type = CompilerConsole.Parser.Nodes.Type;

namespace CompilerConsole.Parser {
    enum Token {
        VAR_DECL,
        METH_CALL,
        ARR_DECL,
        ARR_CALL,
        IF,
        BODY,
        FOR,
        WHILE,
        DO,
        INC,
        DEC,
        METH_DECL,
        RETURN,
    }

    public partial class Parser {
        #region Base

        public Body MainBody { get; set; }
        public ITree Root { get; set; }

        private Dictionary<string, Token> _tokensDictionary;

        public Parser(ITree root) {
            this.MainBody = new Body();
            this.Root = root;
            this.InitDictionary();
        }

        private void InitDictionary() {
            this._tokensDictionary = new Dictionary<string, Token>();

            this._tokensDictionary.Add("VAR_DECL", Token.VAR_DECL);
            this._tokensDictionary.Add("METH_CALL", Token.METH_CALL);
            this._tokensDictionary.Add("ARR_DECL", Token.ARR_DECL);
            this._tokensDictionary.Add("ARR_CALL", Token.ARR_CALL);
            this._tokensDictionary.Add("IF", Token.IF);
            this._tokensDictionary.Add("BODY", Token.BODY);

            this._tokensDictionary.Add("FOR", Token.FOR);
            this._tokensDictionary.Add("WHILE", Token.WHILE);
            this._tokensDictionary.Add("DO", Token.DO);
            this._tokensDictionary.Add("INC", Token.INC);
            this._tokensDictionary.Add("DEC", Token.DEC);
            this._tokensDictionary.Add("METH_DECL", Token.METH_DECL);
            this._tokensDictionary.Add("RETURN", Token.RETURN);
        }

        private bool IsType(string text) {
            switch (text) {
                case "int":
                    return true;
                case "char": {
                    return true;
                }
                case "float": {
                    return true;
                }
                case "string": {
                    return true;
                }
                case "bool": {
                    return true;
                }
                default: {
                    return false;
                }
            }
        }

        private Type GetVarType(string type) {
            switch (type) {
                case "int":
                    return Type.VarInt;
                case "char": {
                    return Type.VarChar;
                }
                case "float": {
                    return Type.VarFloat;
                }
                case "string": {
                    return Type.VarString;
                }
                case "bool": {
                    return Type.VarBool;
                }
                default: {
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
                }
            }
        }

        private Type GetArrType(string type)
        {
            switch (type)
            {
                case "int":
                    return Type.ArrInt;
                case "char":
                    {
                        return Type.ArrChar;
                    }
                case "float":
                    {
                        return Type.ArrFloat;
                    }
                case "string":
                    {
                        return Type.ArrString;
                    }
                case "bool":
                    {
                        return Type.ArrBool;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(type), type, null);
                    }
            }
        }

        #endregion

        public void Pars() {
            this.RecPars(this.Root.GetChild(0), this.MainBody);
        }

        private void RecPars(ITree tree, Body body) {
            Token token;

            if (!this._tokensDictionary.TryGetValue(tree.Text, out token)) {
                throw new UndefinedTokenException($"Для узла {tree.Text} не существует токена");
            }
            this.Action(token, tree, body);
        }

        private void Action(Token token, ITree treeNode, Body body) {
            switch (token) {
                case Token.VAR_DECL: {
                    var vars = this.ParseVarDecl(treeNode, body);

                    foreach (var variable in vars) {
                        body.Nodes.Add(variable);
                    }

                    break;
                }
                case Token.METH_CALL:
                    break;
                case Token.ARR_DECL: {
                    var arr = this.PareArrDecl(treeNode, body);
                    body.Nodes.Add(arr);
                    break;
                }
                case Token.ARR_CALL:
                    break;
                case Token.IF:
                    break;
                case Token.BODY: {
                    //Подразумевается, что таблица создана зранее
                    for (int i = 0; i < treeNode.ChildCount; i++) {
                        this.RecPars(treeNode.GetChild(i), body);
                    }
                    break;
                }
                case Token.FOR:
                    break;
                case Token.WHILE:
                    break;
                case Token.DO:
                    break;
                case Token.INC:
                    break;
                case Token.DEC:
                    break;
                case Token.METH_DECL: {
                    var meth = this.ParseMethodDeclare(treeNode, body);
                    this.MainBody.Nodes.Add(meth);
                    meth.Body.WrapBody = body;
                    this.RecPars(treeNode.GetChild(3), meth.Body);
                    break;
                }
                case Token.RETURN:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(token), token, null);
            }
        }



        public void Serialize() {
            using (FileStream fs = new FileStream("code.xml", FileMode.Create)) {
                XmlSerializer serializer = new XmlSerializer(typeof(Body));
                serializer.Serialize(fs, this.MainBody);
            }
        }
    }
}
