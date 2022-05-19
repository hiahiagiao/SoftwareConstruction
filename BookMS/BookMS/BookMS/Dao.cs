using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookMS
{
    //对数据库进行操作与链接
    class Dao
    {
        public SqlConnection connect()
        {
            string str = @"Data Source=";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }

        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }

        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }

    }
}
