using System.Drawing;
using Antlr.Runtime.Tree;
using DrawingTreeLib.Models;
using DrawingTreeLib.Views;

namespace DrawingTreeLib.Presenters
{
    class Presenter
    {
        private Form1 _view { get; }
        private Models.ModelTree _model { get; set; }


        public Presenter(Form1 view, ITree astTree) {
            this._view = view;
            this._model = new ModelTree(astTree);
            view.PictureBoxGraphics.Resize += PictureBoxGraphics_Resize;   
        }

        private void PictureBoxGraphics_Resize(object sender, System.EventArgs e)
        {
            OnViewLoaded();
        }

        public void OnViewLoaded() {
            Bitmap btmp = new Bitmap((int)_view.PictureBoxWidth, (int)_view.PictureBoxHeight);
            this._model.DrawTree(_view.PictureBoxWidth, _view.PictureBoxHeight, Graphics.FromImage(btmp));
            this._view.PictureBoxGraphics.Image = btmp;
        }
    }
}
