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
    public partial class user11 : Form
    {
        string uid;
        public user11(string uid)
        {
            InitializeComponent();
            this.uid = uid;
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            DialogResult dr = MessageBox.Show("确认申请借书", "信息提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string sql = $"INSERT INTO request (`id`, `isbn`, `rdate`) VALUES ('{uid}', '{isbn}', '{DateTime.Now.ToString()}')";
                DAO dao = new DAO();
                if (dao.execute(sql) > 0)
                {
                    MessageBox.Show("借书申请成功");
               
                }
                else
                {
                    MessageBox.Show("借书申请失败");
                }
                dao.daoClose();
            }
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

        private void button6_Click(object sender, EventArgs e)
        {
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
