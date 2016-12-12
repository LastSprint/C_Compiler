using System;
using System.Collections.Generic;
using CompilerConsole.Parser.Interfaces;
using CompilerConsole.Parser.Nodes;
using CompilerConsole.Parser.Nodes.AbstractNodes;

namespace CompilerConsole.Parser.Utils
{
    public enum BodyTableType {
        Class,
        Method,
        Struct,
        Loop,
        Main
    }

    [Serializable]
    public class BodyTable {
        /// <summary>
        /// Коллекция узлов, содержащихся в таблице тела
        /// </summary>
        public List<Node> BodyNodes { get; }

        public BodyTable ParentTable { get; }

        /// <summary>
        /// Тип таблицы. То есть чья она - таблица класса, или таблица метода
        /// </summary>
        public BodyTableType TableType { get; }

        public BodyTable(IList<Node> bodyNodes, BodyTable parentTable) {
            this.BodyNodes = new List<Node>(bodyNodes);
            this.ParentTable = parentTable;
        }

        /// <summary>
        /// Добавляет узел в коллекцию узлов
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(Node node) {
            this.BodyNodes.Add(node);
        }

        public BodyTable() {
            
        }

        /// <summary>
        /// Выполняет поиск только в текущей таблице
        /// </summary>
        /// <param name="variableName"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        [Obsolete]
        public VariableNode FindVariableNode(string variableName)
        {
            foreach (var node in this.BodyNodes)
            {
                if (node is VariableNode && String.CompareOrdinal(variableName, node.Name) == 0)
                {
                    //Если узел - переменная и их имена совпадают, то ништяк - вываливаемся.
                    return node as VariableNode;
                }
            }
            return null;
        }

        /// <summary>
        /// Выполняет поиск метода с таким именем в текущей таблице
        /// </summary>
        /// <param name="methodName"></param>
        /// <returns></returns>
        [Obsolete]
        public MethodNode FindMethodNode(string methodName) {
            foreach (var node in this.BodyNodes) {
                if (node is MethodNode && String.CompareOrdinal(methodName, node.Name) == 0) {
                    //Если узел - переменная и их имена совпадают, то ништяк - вываливаемся.
                    return node as MethodNode;
                }
            }
            return null;
        }

        /// <summary>
        /// Выполняет поиск узла с именем nodeName в конкретной таблице
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        public T FindNode<T>(string nodeName) where T: Node {
            foreach (var node in this.BodyNodes)
            {
                if (node is T && String.CompareOrdinal(nodeName, node.Name) == 0)
                {
                    //Если узел - переменная и их имена совпадают, то ништяк - вываливаемся.
                    return node as T;
                }
            }
            return null;
        }

        #region Static Methods

        /// <summary>
        /// Выполняет поиск по таблице table и продолжает рекурсивный поиск по таблицам, содержащим table
        /// </summary>
        /// <param name="variableName"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public static VariableNode FindVariable(string variableName, BodyTable table) {
            if (table == null) {
                return null;
            }
            foreach (var node in table.BodyNodes) {
                if (node is VariableNode && String.CompareOrdinal(variableName, node.Name) == 0) {
                    //Если узел - переменная и их имена совпадают, то ништяк - вываливаемся.
                    return node as VariableNode;
                }
            }
            return FindVariable(variableName, table.ParentTable);
        }

        public static Node FindHeapNode(string objectType, BodyTable table) {
            if (table == null)
            {
                return null;
            }
            foreach (var node in table.BodyNodes)
            {
                if (node is IStructNode && String.CompareOrdinal(objectType, node.Name) == 0)
                {
                    //Если узел - переменная и их имена совпадают, то ништяк - вываливаемся.
                    return node;
                }
            }
            return FindHeapNode(objectType, table.ParentTable);
        }

        /// <summary>
        /// Выполняет поиск узла с именем nodeName в конкретной таблице
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nodeName"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public static  T FindNode<T>(string nodeName, BodyTable table) where T : Node
        {
            foreach (var node in table.BodyNodes)
            {
                if (node is T && String.CompareOrdinal(nodeName, node.Name) == 0)
                {
                    //Если узел - переменная и их имена совпадают, то ништяк - вываливаемся.
                    return node as T;
                }
            }
            return null;
        }


        public static MethodNode FindMethod(string methodName, BodyTable table) {
            if (table == null)
            {
                return null;
            }
            foreach (var node in table.BodyNodes)
            {
                if (node is MethodNode && String.CompareOrdinal(methodName, node.Name) == 0)
                {
                    //Если узел - переменная и их имена совпадают, то ништяк - вываливаемся.
                    return node as MethodNode;
                }
            }
            return FindMethod(methodName, table.ParentTable);
        }
#endregion
    }
}

