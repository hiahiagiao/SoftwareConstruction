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
    public partial class user12 : Form
    {
        string uid;
        public user12(string uid)
        {
            InitializeComponent();
            this.uid = uid;

            init();
        }

        void init()
        {
            dataGridView1.Rows.Clear();
            DAO dao = new DAO();
            string sql = $"SELECT book.isbn, name, author,press, rdate FROM request, book where book.isbn=request.isbn and request.id='{uid}'";
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
            string isbn = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("确认撤销申请", "信息提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string sql = $"delete from request where isbn='{isbn}' and id='{uid}'";
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
    }
}
