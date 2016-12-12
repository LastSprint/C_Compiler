using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WFTree
{
    public partial class Form1 : Form {
        public float PictureBoxWidth => this.pictureBox1.Width;
        public float PictureBoxHeight => this.pictureBox1.Height;
        public Graphics PictureBoxGraphics => this.pictureBox1.CreateGraphics();

        public Form1()
        {
            InitializeComponent();
        }
    }
}
