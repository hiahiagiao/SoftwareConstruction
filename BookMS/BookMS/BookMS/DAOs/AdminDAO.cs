using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMS.DAOs
{
    class AdminDAO
    {
        MySqlConnection connection;
        public MySqlConnection connect()
        {
            string str = "datasource=localhost;username=root;" + "password=123456;database=bookms;charset=utf8";
            connection = new MySqlConnection(str);
            connection.Open();
            return connection;
        }

        public MySqlCommand command(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, connect());
            return cmd;
        }

        public int execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        public MySqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
        public void daoClose()
        {
            connection.Close();
        }

       
    }
}
