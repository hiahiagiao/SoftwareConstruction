using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMS
{
    public partial class admin1 : Form
    {
        public admin1()
        {
            InitializeComponent();
        }

        private void admin1_Load(object sender, EventArgs e)
        {
           
        }


        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin2 a2 = new admin2();
            
            a2.ShowDialog();
        }

        private void 借书申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin3 a3 = new admin3();
           
            a3.Show();
        }
    }
}
