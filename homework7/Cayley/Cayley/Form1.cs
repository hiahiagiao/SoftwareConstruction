using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cayley
{
    public partial class Form1 : Form
    {
        private Cayley tree;
        public Form1()
        {
            InitializeComponent();
            tree = new Cayley();
        }


        private void colorButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Brush brush = new SolidBrush(this.colorDialog1.Color);
                this.tree.Color = new Pen(brush);
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            if (this.tree.Graphics == null)
            {
                this.tree.Graphics = this.drawPanel.CreateGraphics();
            }
            this.tree.N = int.Parse(this.nTextBox.Text);
            this.tree.Per1 = double.Parse(this.per1TextBox.Text);
            this.tree.Per2 = double.Parse(this.per2TextBox.Text);
            this.tree.Th1 = double.Parse(this.th1TextBox.Text);
            this.tree.Th2 = double.Parse(this.th2TextBox.Text);
            this.tree.Leng = double.Parse(this.lengTextBox.Text);

            this.drawPanel.Refresh();
            this.tree.drawCayley(this.tree.N, 200, 310, this.tree.Leng, -Math.PI / 2);
        }
    }
}
