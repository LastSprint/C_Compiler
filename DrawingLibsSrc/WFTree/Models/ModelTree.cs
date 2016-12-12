using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms.VisualStyles;
using Antlr.Runtime.Tree;
using AstTreeLib;

namespace WFTree.Models
{
    /// <summary>
    /// Расширенный класс узла, позволяющий рисовать себя
    /// </summary>
    class DrawingNode : Node {
        public const int EllipseRadious = 25;

        private Rectangle _rect;
        private Bitmap _nodeImg;
        public new DrawingNode Parent { get; set; }

        private string _val;

        public override string Value {
            get { return this._val; }
            set {
                this._val = value;
                if (this._nodeImg != null) {
                    this.FillImg();
                }
            }
        }

        public PointF Position { get; set; }

        public DrawingNode() {
            
        }

        public DrawingNode(string value, Node parent) : base(value, parent)
        {
            this._rect = new Rectangle(0,0,EllipseRadious, EllipseRadious);
            this._nodeImg = new Bitmap(EllipseRadious, EllipseRadious);
            this.FillImg();
        }

        private void FillImg() {
            using (Graphics g = Graphics.FromImage(this._nodeImg)) {
                g.FillEllipse(Brushes.Yellow, this._rect);
                g.DrawEllipse(Pens.Red, this._rect);
                g.DrawString(this.Value,SystemFonts.DefaultFont,Brushes.Black,0,EllipseRadious/2f);
            }
        }

        public void DrawNode(Graphics g) {
            g.DrawImage(this._nodeImg,this.Position);
        }
    }
    class ModelTree {
        private Tree<DrawingNode> _tree;
        private const int WhiteSpace = DrawingNode.EllipseRadious;
        public ModelTree(ITree ASTTree) {
            this._tree = new Tree<DrawingNode>(ASTTree);
        }

        public void DrawTree(int frameWidth, int frameHeight, Graphics g) {
            Action<DrawingNode> action = (node) => {
                if (node.Parent == null) {
                    node.Position = new Point(frameWidth/2, frameHeight);
                    node.DrawNode(g);
                }
                else {
                    int fillSquare = node.NextNodes.Count*DrawingNode.EllipseRadious + node.NextNodes.Count + WhiteSpace;
                    float xCoord = node.Parent.Position.X - fillSquare/2f + node.Parent.NextNodes.IndexOf(node)*(DrawingNode.EllipseRadious+WhiteSpace);
                    float yCoord = DrawingNode.EllipseRadious*2;
                    node.Position = new PointF(xCoord,yCoord);
                    node.DrawNode(g);
                }
            };
            this._tree.DeepWalking(action);
        }

    }
}
