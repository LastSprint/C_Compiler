using System;
using System.Drawing;
using System.Threading;
using Antlr.Runtime.Misc;
using Antlr.Runtime.Tree;
using DrawingTreeLib.Models;
using DrawingTreeLib.Views;

namespace DrawingTreeLib.Presenters
{
    class Presenter
    {
        private Form1 _view { get; }
        private Models.ModelTree _model { get; set; }

        private bool isNodeSelect { get; set; }
        private DrawingNode _selectiedNode { get; set; }
        private Bitmap _bg;

        private Object rootSync;

        public Presenter(Form1 view, ITree astTree) {
            this._view = view;
            this._model = new ModelTree(astTree);
            this._bg = new Bitmap((int)view.PictureBoxWidth, (int)view.PictureBoxHeight);
            view.PictureBoxGraphics.Resize += PictureBoxGraphics_Resize;
            view.PictureBoxGraphics.MouseDown += PictureBoxGraphics_MouseDown;
            view.PictureBoxGraphics.MouseUp += PictureBoxGraphics_MouseUp;
            view.PictureBoxGraphics.MouseMove += PictureBoxGraphics_MouseMove;
        }

        private void PictureBoxGraphics_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            if (this.isNodeSelect) {
                this._selectiedNode.Position = e.Location;
                this.Update();
            }
           
        }

        private void PictureBoxGraphics_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) {
                this._selectiedNode = null;
                this.isNodeSelect = false;
            
           
        }

        private void Update() {
            using (Graphics g = Graphics.FromImage(this._bg)) {
                g.Clear(Color.White);
                foreach (var drawingEdge in this._model.Edges) {
                    drawingEdge.Draw(g);
                }

                foreach (var drawingNode in this._model.Nodes) {
                    drawingNode.DrawNode(g);
                }
            }
            this._view.PictureBoxGraphics.Invoke(new Action(() => { this._view.PictureBoxGraphics.Image = this._bg; }));
        }

        private void PictureBoxGraphics_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            foreach (var drawingNode in this._model.Nodes) {
                bool isWidthHit = drawingNode.Position.X < e.X && drawingNode.Position.X + drawingNode.RectWidth > e.X;
                bool isHeighthHit = drawingNode.Position.Y < e.Y && drawingNode.Position.Y + drawingNode.Rect.Height > e.Y;

                if (isWidthHit && isHeighthHit) {
                    this.isNodeSelect = true;
                    this._selectiedNode = drawingNode;
                    return;
                    
                }
            }
        }

        private void PictureBoxGraphics_Resize(object sender, System.EventArgs e)
        {
            OnViewLoaded();
        }

        public void OnViewLoaded() {
            this._bg = new Bitmap((int)_view.PictureBoxWidth, (int)_view.PictureBoxHeight);
            this._model.DrawTree(_view.PictureBoxWidth, _view.PictureBoxHeight, Graphics.FromImage(_bg));
            this._view.PictureBoxGraphics.Image = _bg;
        }
    }
}
