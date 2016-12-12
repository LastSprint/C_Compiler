using System.Collections.Generic;

namespace CompilerConsole.Parser.Utils {

    #region Enums

    public enum DeclareToken {
        ClassDecl,
        StructDecl,
        VarDecl,
        MethDecl,
        Body,
        ArrDecl
    }

    public enum MathOperatorToken {
        Ass,
        Add,
        Sub,
        Div,
        Mult
    }

    #endregion

    /// <summary>
    /// Создержит все необходимое для обеспечения работы парсера
    /// Функционал вынесен в отдельный класс т.к. KISS и Single Responsibility Principle
    /// Да и вообще так логичнее и правильнее!
    /// </summary>
    internal class Utils {
        #region Singleton part

        private static Utils _instantience;

        public static Utils Instantience {
            get {
                if (_instantience == null) {
                    _instantience = new Utils();
                }
                return _instantience;
            }
        }

        #endregion

        /// <summary>
        /// Словарь, содержащий токены декларации по ключам - именам узлов дерева, возвращаемого ANTLR
        /// </summary>
        public Dictionary<string, DeclareToken> DeclareTokensDict { get; private set; }

        public Dictionary<string, MathOperatorToken> MathOperatorTokensDict { get; private set; }

        private Utils() {
            this.InitDeclareDictionary();
            this.InitMathOperatorTokensDict();
        }

        private void InitDeclareDictionary() {
            this.DeclareTokensDict = new Dictionary<string, DeclareToken>();

            this.DeclareTokensDict.Add("class", DeclareToken.ClassDecl);
            this.DeclareTokensDict.Add("struct", DeclareToken.StructDecl);
            this.DeclareTokensDict.Add("VAR_DECL", DeclareToken.VarDecl);
            this.DeclareTokensDict.Add("METH_DECL", DeclareToken.MethDecl);
            this.DeclareTokensDict.Add("ARR_DECL", DeclareToken.ArrDecl);
            this.DeclareTokensDict.Add("BODY", DeclareToken.Body);
        }

        private void InitMathOperatorTokensDict() {
            this.MathOperatorTokensDict = new Dictionary<string, MathOperatorToken>();

            this.MathOperatorTokensDict.Add("=", MathOperatorToken.Ass);
            this.MathOperatorTokensDict.Add("/", MathOperatorToken.Div);
            this.MathOperatorTokensDict.Add("-", MathOperatorToken.Sub);
            this.MathOperatorTokensDict.Add("+", MathOperatorToken.Add );
            this.MathOperatorTokensDict.Add("*", MathOperatorToken.Mult);
        }
    }
}
