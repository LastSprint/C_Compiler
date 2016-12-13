using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Antlr.Runtime.Tree;
using AstTreeLib;

namespace DrawingTreeLib.Models
{
    /// <summary>
    /// Расширенный класс узла, позволяющий рисовать себя
    /// </summary>
    class DrawingNode : Node
    {
        public const int EllipseRadious = 25;

        public RectangleF Rect { get; set; }
        private Bitmap _nodeImg;
    

        private int _nodeLevel = -1;

        public int NodeLevel
        {
            get
            {
                return this._nodeLevel;
            }
            set
            {
                this._nodeLevel = value;
                this.FillImg();
            }
        }

        public float RectWidth => this.Rect.Width;

        public DrawingNode Parent
        {
            get { return base.Parent as DrawingNode; }
        }

        private string _val;

        public override string Value
        {
            get { return this._val; }
            set
            {
                this._val = value;
                const int minWidth = 30;
                int rectWidth = value.Length*12;
                if (rectWidth < minWidth)
                {
                    rectWidth = minWidth;
                }
                this.Rect = new Rectangle(0, 0, rectWidth, EllipseRadious);
                this._nodeImg = new Bitmap(rectWidth + 5, EllipseRadious + 5);
                this.FillImg();
                if (this._nodeImg != null)
                {
                    this.FillImg();
                }
            }
        }

        public PointF Position { get; set; }

        public DrawingNode()
        {

        }

        public DrawingNode(string value, Node parent) : base(value, parent)
        {
            float rectWidth = value.Length/2;
            this.Rect = new RectangleF(0, 0, rectWidth, EllipseRadious);
            this._nodeImg = new Bitmap((int)rectWidth, EllipseRadious);
            this.FillImg();
        }

        private void FillImg()
        {
            using (Graphics g = Graphics.FromImage(this._nodeImg))
            {
                g.FillRectangle(Brushes.Yellow, this.Rect);
                g.DrawRectangle(Pens.Red,this.Rect.X, this.Rect.Y, this.Rect.Width, this.Rect.Height);
                Font t = SystemFonts.DefaultFont;
                t = new Font(t.FontFamily,8);
                g.DrawString(this.Value, t, Brushes.Black, 5, 5);
               // g.DrawString(this._nodeLevel.ToString(), SystemFonts.DefaultFont,Brushes.Red,this._rect.Width-10,5);
            }
        }

        public void DrawNode(Graphics g)
        {
            g.DrawImage(this._nodeImg, this.Position);
        }
    }

    class DrawingEdge {
        public DrawingNode Node1 { get; set; }
        public DrawingNode Node2 { get; set; }

        public DrawingEdge(DrawingNode node1, DrawingNode node2) {
            this.Node1 = node1;
            this.Node2 = node2;
        }

        public void Draw(Graphics g) {
            float posX1 = this.Node1.Position.X + this.Node1.Rect.Width/2f;
            float posY1 = this.Node1.Position.Y;

            float posX2 = this.Node2.Position.X + this.Node2.Rect.Width / 2f;
            float posY2 = this.Node2.Position.Y;

            g.DrawLine(Pens.Black, posX1, posY1, posX2, posY2);
        }
    }

    class ModelTree
    {
        private Tree<DrawingNode> _tree;
        private const int WhiteSpace = DrawingNode.EllipseRadious;
        public List<DrawingNode> Nodes { get; set; }
        public List<DrawingEdge> Edges { get; set; }

        public ModelTree(ITree ASTTree)
        {
            this._tree = new Tree<DrawingNode>(ASTTree);
            this.Nodes = new List<DrawingNode>();
            this.Edges = new List<DrawingEdge>();
            this._tree.DeepWalking(node => {
                this.Nodes.Add(node);
            });
            this.CreateEdge(this._tree.Root);
        }

        public void DrawTree(float frameWidth, float frameHeight, Graphics g)
        {
            Action<DrawingNode> action = (node) =>
            {
                if (node.Parent == null)
                {
                    node.Position = new PointF(frameWidth/2, 0);
                    node.DrawNode(g);
                }
               float allNodeWidth = 0; //ширина всех узлов вместе с пробелами между прямоугольниками
                if (node.NextNodes.Count != 1)
                {
                    for (int i = 0; i < node.NextNodes.Count; i++)
                    {
                        allNodeWidth += (node.NextNodes[i] as DrawingNode).RectWidth + WhiteSpace;
                    }
                }

                float xStartCoord = node.Position.X + node.RectWidth/2f - allNodeWidth/2f;
                    //ниже и левее на половину общей ширины от предка
                float yCoord = node.Position.Y + DrawingNode.EllipseRadious*2; //для всех потомков одно и то же
                for (int i = 0; i < node.NextNodes.Count; i++)
                {
                    //Вычисляем координаты потомков
                    var dNode = node.NextNodes[i] as DrawingNode;
                    dNode.Position = new PointF(xStartCoord - dNode.RectWidth/2f, yCoord);
                    xStartCoord += dNode.RectWidth + WhiteSpace;
                    g.DrawLine(Pens.Black, node.Position.X + node.RectWidth/2f,
                        node.Position.Y + DrawingNode.EllipseRadious/2f, dNode.Position.X + dNode.RectWidth/2f,
                        dNode.Position.Y + DrawingNode.EllipseRadious/2f);
                    dNode.DrawNode(g);
                }
            };
            this._tree.DeepWalking(action);
           // this._tree.DeepWalking((node) => { node.DrawNode(g); });           
            this._tree.DeepWalking((node) =>
            {
                if (node.Parent == null)
                {
                    node.NodeLevel = 0;
                }
                else
                {
                    node.NodeLevel = node.Parent.NodeLevel + 1;
                }

            });
            this._tree.DeepWalking((node) => { node.DrawNode(g); });
            IList<IList<DrawingNode>> nodesList = new List<IList<DrawingNode>>();
            this._tree.DeepWalking((node) =>
            {
                if (node.NodeLevel != 0)
                {
                    if (node.NodeLevel > nodesList.Count)
                    {
                        nodesList.Add(new List<DrawingNode>() {node});
                    }
                    else
                    {
                        nodesList[node.NodeLevel-1].Add(node);
                    }
                }
            });
            this.RePosition(nodesList);
            g.Clear(Color.White);
            this._tree.DeepWalking((node) =>
            {
                foreach (var nextNode in node.NextNodes)
                {
                    DrawingNode dNode = nextNode as DrawingNode;
                    
                    g.DrawLine(Pens.Black, node.Position.X + node.RectWidth / 2f,
                       node.Position.Y + DrawingNode.EllipseRadious / 2f, dNode.Position.X + dNode.RectWidth / 2f,
                       dNode.Position.Y + DrawingNode.EllipseRadious / 2f);
                }
            });
             this._tree.DeepWalking((node) => { node.DrawNode(g); });  
        }

        private void RePosition(IList<IList<DrawingNode>> dnList )
        {
            foreach (IList<DrawingNode> nodeLists in dnList)
            {
                DrawingNode tempNode = null;
                foreach (var node in nodeLists)
                {
                    if (tempNode == null)
                    {
                        tempNode = node;
                    }
                    else
                    {
                        if (tempNode.Position.X + tempNode.RectWidth >= node.Position.X-5)
                        {
                            node.Position = new PointF(tempNode.Position.X+tempNode.RectWidth+WhiteSpace,tempNode.Position.Y);
                        }
                        tempNode = node;
                    }
                }
            }
        }


        private void CreateEdge(DrawingNode node) {
            foreach (var nod in node.NextNodes) {
                this.Edges.Add(new DrawingEdge(node, (DrawingNode)nod));
                this.CreateEdge((DrawingNode) nod);
            }
        }
    }
}
