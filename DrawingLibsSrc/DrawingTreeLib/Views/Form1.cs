using System;
using System.Drawing;
using System.Windows.Forms;
using Antlr.Runtime.Tree;
using DrawingTreeLib.Presenters;

namespace DrawingTreeLib.Views
{
    public static class DrawingTreeLib {
        [STAThread]
        public static void Initialize(ITree astTree) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Form1();
            form.Initialize(astTree);
            Application.Run(form);
        }
    }

    public partial class Form1 : Form {
        public float PictureBoxWidth => this.pictureBox1.Width;
        public float PictureBoxHeight => this.pictureBox1.Height;
        public PictureBox PictureBoxGraphics => this.pictureBox1;
        private Presenters.Presenter _presenter;
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
            this.pictureBox1.Width = 5000;
            this.pictureBox1.Height = 5000;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this._presenter.OnViewLoaded();
        }

        public void Initialize(ITree astTree) {
            this._presenter = new Presenter(this,astTree);
        }
        
    }
}
