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
    public partial class FormAdminMain : Form
    {
        public FormAdminMain()
        {
            InitializeComponent();
        }

        private void admin1_Load(object sender, EventArgs e)
        {
           
        }


        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminManage a2 = new FormAdminManage();
            
            a2.ShowDialog();
        }

        private void 借书申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminLend a3 = new FormAdminLend();
           
            a3.Show();
        }
    }
}
