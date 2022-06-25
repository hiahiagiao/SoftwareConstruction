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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                if (radioButtonAdmin.Checked == true)
                {
                    admin1 a = new admin1();
                    this.Hide();
                    a.ShowDialog();
                }
                else
                {
                    user1 u = new user1(ID_textBox.Text);
                    this.Hide();
                    u.ShowDialog();
                }
            }

        }

        public bool verify()
        {
            if (radioButtonAdmin.Checked == true)
            {
                DAO dao = new DAO();
                string sql = $"select * from admin where id='{ID_textBox.Text}' and password='{psw_textBox.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    //MessageBox.Show(dc[0].ToString(), dc["name"].ToString());
                    //MessageBox.Show("登录成功");
                   
                    return true;
                }
                else
                {
                    MessageBox.Show("账号密码输入错误");
                    return false;
                }
                dc.Close();
                dao.daoClose();
            }
            if (radioButtonUser.Checked == true)
            {
                DAO dao = new DAO();
                string sql = $"select * from user where id='{ID_textBox.Text}' and password='{psw_textBox.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    //MessageBox.Show(dc[0].ToString(), dc["name"].ToString());
                   // MessageBox.Show("登录成功");
                    return true;
                }
                else
                {
                    MessageBox.Show("账号密码输入错误");
                    return false;
                }
                dc.Close();
                dao.daoClose();

            }
            else
            {
                MessageBox.Show("请选择登录选项");
                return false;
            }
        }

        
    }
}
