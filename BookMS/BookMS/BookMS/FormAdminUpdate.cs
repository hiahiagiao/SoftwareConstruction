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
    public partial class FormAdminUpdate : Form
    {
        string isbn;
        public FormAdminUpdate(string name,string isbn,string press,string author,string number )
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = isbn;
            textBox3.Text = press;
            textBox4.Text = author;
            textBox5.Text = number;
            this.isbn = isbn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DAO dao = new DAO();
            string sql = $"update book set name='{textBox1.Text}',isbn='{textBox2.Text}',press='{textBox3.Text}',author='{textBox4.Text}',number='{textBox5.Text}' where isbn='{isbn}'";
            if (dao.execute(sql)>0)
            {
                MessageBox.Show("修改成功");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
