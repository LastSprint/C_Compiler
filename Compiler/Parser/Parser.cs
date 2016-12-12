using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml.Serialization;
using Antlr.Runtime.Tree;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.AbstractNodes;
using CompilerConsole.Parser.Parsers;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser {
    /// <summary>
    /// Принцип работы парсера:
    /// На входе имеет root дерева токенов.
    /// Запускаем парсер:
    /// 1) Смотрим на токен
    ///     -------------------------------------Запись в таблицу-----------------------------------------------
    ///     ->  Class - считываем тип данных классса, создаем таблицу узлов, вызываем делаем шаг в глубину для поддерева
    ///     ->  MethodDeclare - считываем тип возвращаемого значения, имя, записываем принимаемые параметры, делаем шаг в глубину для поддерева
    ///     ->  VariableDeclare - считываем тип переменной, имя и значение, если оно было присвоено. Делаем шаг вверх.
    ///     ->  ArrayDeclare - считываем тип массива, название и инициализацию. Делаем шаг вверх;
    ///     
    ///     ------------------------------------Чтеие из талицы------------------------------------------------
    ///     ->  ArrayCall - 
    ///     ->  MethodCall - 
    ///     ->  VariableCall
    ///     ->  ObjectCall
    ///
    /// </summary>


    [Serializable]
    public class Parser {

        private static Parser _instantience;

        public static Parser Instance {
            get { return _instantience; }
        }


        public Parser() {

        }

        private BodyTable _mainBodyTable;

        [NonSerialized]
        private ITree _tree;

        public Parser(ITree tree) {
            this._tree = tree;
            this._mainBodyTable = new BodyTable(new List<Node>(), null);
            _instantience = this;
        }

        public void Parse() {
            this.ToParse(this._tree.GetChild(0),this._mainBodyTable);
        }

        public void ToParse(ITree tree, BodyTable activeTable) {
            if (tree.IsNil || tree == null) {
                return;
            }
            if (CallParser.Instanience.IsCall(tree)) {
                CallParser.Instanience.ParseCall(tree, activeTable);
                return;
            }

            DeclareToken declareToken;
            if (!Utils.Utils.Instantience.DeclareTokensDict.TryGetValue(tree.Text, out declareToken)) {
                throw new DataException($"Ошибка парсинга токена DeclareToken на узла с именем {tree.Text}");
            }
            this.MakeDeclareAction(declareToken, activeTable, tree);
        }

        /// <summary>
        /// Заплняет таблицу в зависимости от типа поступившего токена
        /// </summary>
        /// <param name="tokem"></param>
        private void MakeDeclareAction(DeclareToken tokem, BodyTable activeTable, ITree tree) {
            switch (tokem) {
                case DeclareToken.Body: {
                    for (int i = 0; i < tree.ChildCount; i++) {
                        this.ToParse(tree.GetChild(i), activeTable);

                    }
                    return;
                }
                case DeclareToken.ClassDecl: {
                    var classNode = DeclareNodeParser.ParseClassDeclare(tree, activeTable);
                    this.ToParse(tree.GetChild(1), classNode.Body);
                    return;
                }
                case DeclareToken.MethDecl: {
                    var methNode = DeclareNodeParser.ParseMethodDeclare(tree, activeTable);
                    this.ToParse(tree.GetChild(3), methNode.Body);
                    return;
                }
                case DeclareToken.VarDecl: {
                    DeclareNodeParser.ParseVariableNodeDeclare(tree, activeTable);
                    return;
                }
                case DeclareToken.ArrDecl: {
                    DeclareNodeParser.ParseVariableNodeDeclare(tree, activeTable);
                    return;
                }
                case DeclareToken.StructDecl: {
                    StructNode structNode =  DeclareNodeParser.ParseStructDeclare(tree, activeTable);
                    this.ToParse(tree.GetChild(1),structNode.Body);
                    return;
                }
                default: {
                    return;
                }
            }
        }

        public void Serialize() {
            XmlSerializer xml = new XmlSerializer(typeof(ClassNode));
            using (FileStream fs = new FileStream("code.xml", FileMode.Create)) {
                xml.Serialize(fs, this._mainBodyTable.BodyNodes[0]);
            }
        }
    }
}
