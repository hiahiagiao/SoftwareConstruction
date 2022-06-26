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
    public partial class FormAdminManage : Form
    {
        public FormAdminManage()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            dataGridView1.Rows.Clear();
            DAO dao = new DAO();
            string sql = "select * from book";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.daoClose();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.ToString();
            dataGridView1.Rows.Clear();
            DAO dao = new DAO();
            string sql = $"select * from book where isbn='{str}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.daoClose();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminAdd a21 = new FormAdminAdd();
            a21.ShowDialog();
            if (a21.DialogResult == DialogResult.OK)
            {
                init();
            }
        }
        //todo: 数据库书籍为空怎么办
        private void button4_Click(object sender, EventArgs e)
        {
            init();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string isbn = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            DialogResult dr = MessageBox.Show("确认删除","信息提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string sql = $"delete from book where isbn='{isbn}'";
                DAO dao = new DAO();
                if (dao.execute(sql)>0)
                {
                    MessageBox.Show("删除成功");
                    init();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        } 

        private void button2_Click(object sender, EventArgs e)

        {
            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string isbn = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string press = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string author = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string number = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            FormAdminUpdate a22 = new FormAdminUpdate(name,isbn,press,author,number);
            a22.ShowDialog();
            if (a22.DialogResult == DialogResult.OK)
            {
                init();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //todo:查不到报错
            string str = textBox2.Text.ToString();
            dataGridView1.Rows.Clear();
            DAO dao = new DAO();
            string sql = $"select * from book where name='{str}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.daoClose();
            textBox2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string condition = textBox3.Text;
            string sql=$"SELECT* FROM bookms.book order by {condition}";
            dataGridView1.Rows.Clear();
            DAO dao = new DAO();
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.daoClose();
        }
    }
}
