using System;
using System.Collections.Generic;
using Antlr.Runtime.Tree;

namespace AstTreeLib
{
    /// <summary>
    /// Вспомогательный класс для дерева
    /// </summary>
    public class Node {
        public IList<Node> NextNodes { get;private set; }
        public virtual string Value { get; set; }
        public Node Parent { get; set; }

        public Node() {
            this.NextNodes = new List<Node>();
        }

        public Node(string value, Node parent) {
            this.Value = value;
            this.NextNodes = new List<Node>();
            this.Parent = parent;
        }
    }
    /// <summary>
    /// Класс AST дерева.
    /// </summary>
    public class Tree<T> where T:Node, new()
    {
        public T Root { get;}

        public Tree(ITree antlrASTTree) {
            this.Root = new T() {Value = antlrASTTree.Text, Parent = null};
            this.CreateTree(antlrASTTree, this.Root);
        }

        private void CreateTree(ITree root, T node) {
            var nodes = new List<Node>();
            for (int i = 0; i < root.ChildCount; i++) {
                T tempNode = new T() { Value=root.GetChild(i).Text, Parent = node};
                node.NextNodes.Add(tempNode);
                CreateTree(root.GetChild(i), tempNode);
            }
        }
        /// <summary>
        /// Осуществляет поиск в глубину и применяет делегат action к каждому узлу дерева
        /// </summary>
        /// <param name="action"></param>
        public void DeepWalking(Action<T> action) {
            this.DeepWalking(action, this.Root);
        }

        private void DeepWalking(Action<T> action, T currenNode) {
            action(currenNode);
            for (int i = 0; i < currenNode.NextNodes.Count; i++) {
                DeepWalking(action, currenNode.NextNodes[i] as T);
            }
        }
    }
}
