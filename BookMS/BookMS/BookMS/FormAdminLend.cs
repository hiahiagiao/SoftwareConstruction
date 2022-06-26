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
    public partial class FormAdminLend : Form
    {
        public FormAdminLend()
        {
            InitializeComponent();
            init();
        }

        void init()
        {
            dataGridView1.Rows.Clear();
            DAO dao = new DAO();
            string sql = $"select record.userid, user.name, state,book.isbn,book.name,book.number" +
                $" from book, record, user where user.id=record.userid and record.bookisbn=book.isbn";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.daoClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string isbn= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            DAO dao = new DAO();
            string sql = $"UPDATE `bookms`.`record` SET `state` = '出借' " +
                $"WHERE (`userid` = '{userid}') and (`bookisbn` = '{isbn}');";
            dao.execute(sql);
            string sql2 = $"UPDATE `bookms`.`book` SET `number` = 'number'-1 WHERE `isbn` = '{isbn}';";
            dao.daoClose();
            init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string isbn = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            DAO dao = new DAO();
            string sql = $"UPDATE `bookms`.`record` SET `state` = '被拒' " +
                $"WHERE (`userid` = '{userid}') and (`bookisbn` = '{isbn}');";
            dao.execute(sql);
            dao.daoClose();
            init();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string userid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string isbn = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            DAO dao = new DAO();
            string sql = $"UPDATE `bookms`.`record` SET `state` = '入库' " +
                $"WHERE (`userid` = '{userid}') and (`bookisbn` = '{isbn}');";
            dao.execute(sql);
            dao.daoClose();
            init();
        }

        
    }
}
