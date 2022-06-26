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
    public partial class FormUserBorrow : Form
    {
        string uid;
        public FormUserBorrow(string uid)
        {
            InitializeComponent();
            this.uid = uid;

            init();
        }

        void init()
        {
            dataGridView1.Rows.Clear();
            DAO dao = new DAO();
            string sql = $"SELECT book.isbn, book.name, author,press, state FROM record, book where book.isbn=record.bookisbn and record.userid='{uid}'";
            IDataReader dc = dao.read(sql);
            int i = 0;
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
                if (dc[4].ToString() == "逾期")
                {
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
                i++;
            
            }
            dc.Close();
            dao.daoClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("确认撤销申请", "信息提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string sql = $"delete from record where bookisbn='{isbn}' and userid='{uid}'";
                DAO dao = new DAO();
                if (dao.execute(sql) > 0)
                {
                    MessageBox.Show("借书申请撤销成功");

                }
                else
                {
                    MessageBox.Show("借书申请撤销失败");
                }
                dao.daoClose();
                init();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isbn = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("确认还书", "信息提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string sql = $"UPDATE `bookms`.`record` SET `state` = '还书' WHERE (`userid` = '{uid}') and (`bookisbn` = '{isbn}');";
                DAO dao = new DAO();
                dao.execute(sql);
                dao.daoClose();
                init();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
