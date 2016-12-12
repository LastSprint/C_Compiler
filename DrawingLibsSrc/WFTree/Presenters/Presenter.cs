using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using AstTreeLib;

namespace WFTree.Presenters
{
    class Presenter
    {
        private Form _view { get; }
        private Models.ModelTree _model { get; set; }


        public Presenter(Form view) {
            this._view = view;
        }

        private void Draw(Node currentNode) {
            if (currentNode.Parent == null) {
                
            }
        }
    }
}
