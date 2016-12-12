using System;
using CompilerConsole.Parser.Utils;

namespace CompilerConsole.Parser.Nodes.AbstractNodes {
    /// <summary>
    /// Абстрактный класс узла
    /// </summary>
    [Serializable]
    public abstract class Node {
        /// <summary>
        /// Имя токена в AST-дереве
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Тип данных, характеризующий токен
        /// </summary>
        public string DataType { get; protected set; }

        /// <summary>
        /// Тело, включающее этот узел
        /// </summary>
        public BodyTable WrapBody { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя токена</param>
        /// <param name="dataType">Тип данных</param>
        protected Node(string name, string dataType, BodyTable wrapBodyTable) {
            this.Name = name;
            this.DataType = dataType;
            this.WrapBody = wrapBodyTable;
        }

        public Node() {

        }

        /// <summary>
        /// Проверяет, является ли узел базовым типом
        /// </summary>
        /// <returns></returns>
        public virtual bool IsBaseType() {
            switch (this.DataType) {
                case "int":
                case "double":
                case "float":
                case "string":
                case "char":
                case "bool": {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Проверяет, является ли узел экземпляром класса или структуры
        /// </summary>
        /// <returns></returns>
        public virtual bool IsObject() {
            if (this.IsBaseType()) {
                return false;
            }

            if (this is ArrayNode) {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Проверяет, является ли узел базовым типом
        /// </summary>
        /// <returns></returns>
        public static bool IsBaseType(string type) {
            switch (type) {
                case "int":
                case "double":
                case "float":
                case "string":
                case "char":
                case "bool": {
                    return true;
                }
            }
            return false;
        }

    }
}
