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
    public partial class user1 : Form
    {
        string uid;
        public user1(string uid)
        {
            InitializeComponent();
            this.uid = uid;
        }

        private void 书籍查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user11 u11 = new user11(uid);
            u11.Show();
            
        }

        private void 借书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user12 u12 = new user12(uid);
            u12.Show();
            
        }
    }
}
