using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Antlr.Runtime.Tree;
using CompilerConsole.Parser.Exceptions;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.BodyNodes;
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
        #region Consts
        public const string WriteMethodName = "print";
        public const string ReadMethodName = "read";
        #endregion


        #region Base

        public Body MainBody { get; set; }
        public ITree Root { get; set; }

        private Dictionary<string, Token> _tokensDictionary;
        private Dictionary<string, ExprToken> _exprTokensDictionary;

        public Parser(ITree root) {
            this.MainBody = new Body();
            this.Root = root;
            this.InitDictionary();
            this.InitBaseFunction();
        }

        private void InitDictionary() {

            #region _tokensDictionary initialize
            this._tokensDictionary = new Dictionary<string, Token>();
            this._tokensDictionary.Add("VAR_DECL", Token.VAR_DECL);
            this._tokensDictionary.Add("METH_CALL", Token.METH_CALL);
            this._tokensDictionary.Add("ARR_DECL", Token.ARR_DECL);
            this._tokensDictionary.Add("ARR_CALL", Token.ARR_CALL);
            this._tokensDictionary.Add("if", Token.IF);
            this._tokensDictionary.Add("BODY", Token.BODY);

            this._tokensDictionary.Add("for", Token.FOR);
            this._tokensDictionary.Add("while", Token.WHILE);
            this._tokensDictionary.Add("do", Token.DO);
            this._tokensDictionary.Add("INC", Token.INC);
            this._tokensDictionary.Add("DEC", Token.DEC);
            this._tokensDictionary.Add("METH_DECL", Token.METH_DECL);
            this._tokensDictionary.Add("return", Token.RETURN);
            #endregion

            #region exprTokensDictionary initialize
            this._exprTokensDictionary = new Dictionary<string, ExprToken>();
            this._exprTokensDictionary.Add("+", ExprToken.Add);
            this._exprTokensDictionary.Add("-", ExprToken.Sub);
            this._exprTokensDictionary.Add("*", ExprToken.Mult);
            this._exprTokensDictionary.Add("/", ExprToken.Div);
            this._exprTokensDictionary.Add("=", ExprToken.Ass);
            this._exprTokensDictionary.Add("==", ExprToken.IsEqual);
            this._exprTokensDictionary.Add("<", ExprToken.IsLess);
            this._exprTokensDictionary.Add(">", ExprToken.IsMore);
            this._exprTokensDictionary.Add("<=", ExprToken.IsLessOrEqual);
            this._exprTokensDictionary.Add(">=", ExprToken.IsMoreOrEqual);
            this._exprTokensDictionary.Add("&&", ExprToken.Conj);
            this._exprTokensDictionary.Add("||", ExprToken.Dij);
            this._exprTokensDictionary.Add("!", ExprToken.Neg);
            #endregion
        }

        private void InitBaseFunction() {
            this.MainBody.Nodes.Add(new MethodNode(WriteMethodName + "i", Type.Void,new Body(), new List<VariableNode>() {new StructVariableNode("var", Type.VarInt)}, MethodType.Libr));
            this.MainBody.Nodes.Add(new MethodNode(WriteMethodName + "c", Type.Void, new Body(), new List<VariableNode>() {new StructVariableNode("var", Type.VarChar)}, MethodType.Libr));
            this.MainBody.Nodes.Add(new MethodNode(WriteMethodName + "b", Type.Void, new Body(), new List<VariableNode>() {new StructVariableNode("var", Type.VarBool)}, MethodType.Libr));
            this.MainBody.Nodes.Add(new MethodNode(WriteMethodName + "f",Type.Void, new Body(), new List<VariableNode>() {new StructVariableNode("var", Type.VarFloat)}, MethodType.Libr));
            this.MainBody.Nodes.Add(new MethodNode(WriteMethodName + "s", Type.Void, new Body(), new List<VariableNode>() {new StructVariableNode("var", Type.VarString)}, MethodType.Libr));
            this.MainBody.Nodes.Add(new MethodNode(ReadMethodName, Type.VarString, new Body(),new List<VariableNode>(), MethodType.Libr));
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

        private bool IsExpr(string text) {
            ExprToken token;

            if (this._exprTokensDictionary.TryGetValue(text, out token)) {
                return true;
            }
            return false;
        }

        private ExprToken GetExpr(string expr) {
            ExprToken token;

            if (this._exprTokensDictionary.TryGetValue(expr, out token))
            {
                return token;
            }
            return ExprToken.Error;
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

        private static MethodNode _currentMethod;

        public void Pars() {
            this.RecPars(this.Root.GetChild(0), this.MainBody);
        }

        private void RecPars(ITree tree, Body body) {
            Token token;
            if (this.IsExpr(tree.Text)) {
                body.Nodes.Add(this.ParsExpr(tree, body));
                return;
            }

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
                    body.Nodes.Add(this.ParseMethCall(treeNode, body));
                    break;
                case Token.ARR_DECL: {
                    var arr = this.PareArrDecl(treeNode, body);
                    body.Nodes.Add(arr);
                    break;
                }
                case Token.IF:
                    var ifN = this.ParseIf(treeNode, body);
                    body.Nodes.Add(ifN);
                    break;
                case Token.BODY: {
                    //Подразумевается, что таблица создана зранее
                    for (int i = 0; i < treeNode.ChildCount; i++) {
                        this.RecPars(treeNode.GetChild(i), body);
                    }
                    break;
                }
                case Token.FOR:
                    var tF = this.ParseForLoop(treeNode, body);
                    body.Nodes.Add(tF);
                    break;
                case Token.WHILE:
                    var tW = this.ParseWhileLoop(treeNode, body);
                    body.Nodes.Add(tW);
                    break;
                case Token.DO:
                    var tD = this.ParseDoLoop(treeNode, body);
                    body.Nodes.Add(tD);
                    break;
                case Token.INC:
                    var t3 = this.ParseIncDec(treeNode, body, ExprToken.Add);
                    body.Nodes.Add(t3);
                    break;

                case Token.DEC:
                    var t4 = this.ParseIncDec(treeNode, body, ExprToken.Sub);
                    body.Nodes.Add(t4);
                    break;
                case Token.METH_DECL: {
                    var meth = this.ParseMethodDeclare(treeNode, body);
                    this.MainBody.Nodes.Add(meth);
                    meth.Body.WrapBody = body;
                    _currentMethod = meth;
                    this.RecPars(treeNode.GetChild(3), meth.Body);
                    _currentMethod = null;
                    if (meth.DataType == Type.Void && !(meth.Body.Nodes[meth.Body.Nodes.Count - 1] is ReturnNode)) {
                        meth.Body.Nodes.Add(new ReturnNode(Type.Void, null));
                    }
                    foreach (var variableNode in meth.ArgList) {
                        meth.Body.Nodes.Remove(variableNode);
                        variableNode.IsMethodArg = true;
                    }

                    break;
                }
                case Token.RETURN: {
                    var ret = this.ParseReturn(treeNode, body);
                    body.Nodes.Add(ret);
                    break;
                }

                default:
                    throw new ArgumentOutOfRangeException(nameof(token), token, null);
            }
        }

        #region After parsing methods
        public void Serialize() {
            using (FileStream fs = new FileStream("code.xml", FileMode.Create)) {
                XmlSerializer serializer = new XmlSerializer(typeof(Body));
                serializer.Serialize(fs, this.MainBody);
            }
        }

        public void NumerateVariable() {
            this.Numerate(this.MainBody);

            foreach (var node in this.MainBody.Nodes) {
                if (node is MethodNode) {
                    this.NumerateLocal((node as MethodNode).Body, 0);
                }
            }
        }

        private void NumerateLocal(Body body, int startNum) {
            foreach (var node in body.Nodes) {
                if (node is VariableNode) {
                    ((VariableNode) node).Number = startNum++;
                }
                if (node is BodyNode) {
                    this.NumerateLocal((node as BodyNode).Body, startNum);
                }
            }
        }

        private void Numerate(Body body) {
            if (body == null) {
                return;
            }

            var i = 0;
            foreach (var node in body.Nodes) {
                if (node is VariableNode) {
                    (node as VariableNode).Number = i++;
                }

                if (node is MethodNode) {
                    this.Numerate((node as MethodNode).Body);

                    if ((node as MethodNode).Body == null) {
                        return;
                    }

                    foreach (var node1 in (node as MethodNode).Body.Nodes) {
                        if (node1 is VariableNode) {
                            (node1 as VariableNode).Number -= (node as MethodNode).ArgList.Count;
                        }
                    }
                    int j = 0;
                    foreach (var variableNode in (node as MethodNode).ArgList) {
                        variableNode.Number = j++;
                        variableNode.IsMethodArg = true;
                    }
                }

            }
        }

        public void MakeGlobalFields() {
            foreach (var node in this.MainBody.Nodes) {
                if (node is VariableNode) {
                    (node as VariableNode).IsGlobal = true;
                }
            }
        }
#endregion
    }
}
