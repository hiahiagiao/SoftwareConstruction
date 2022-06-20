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
    public partial class admin3 : Form
    {
        public admin3()
        {
            InitializeComponent();
            init();
        }

        void init()
        {
            dataGridView1.Rows.Clear();
            DAO dao = new DAO();
            string sql = $"select request.id, user.name, rdate,book.isbn,book.name,book.number from book, request, user where user.id=request.id and request.isbn=book.isbn";
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

        }

        
    }
}
