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
    public partial class FormUserMain : Form
    {
        string uid;
        public FormUserMain(string uid)
        {
            InitializeComponent();
            this.uid = uid;
        }

        private void 书籍查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserQuery u11 = new FormUserQuery(uid);
            u11.Show();
            
        }

        private void 借书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserBorrow u12 = new FormUserBorrow(uid);
            u12.Show();
            
        }
    }
}
