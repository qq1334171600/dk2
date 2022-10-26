using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dk2.util
{
    public class DBUtil
    {
        public static string address = "server=120.48.99.11;port=3306;user=dk2;password=5845331588Zjqq@; database=dk2;";
        public MySqlConnection GetCon()
        {
            return new MySqlConnection(address);
        }
        public int sqlExcute(string cmdstr)
        {
            MySqlConnection con = GetCon();//连接数据库
            con.Open();//打开连接
            MySqlCommand cmd = new MySqlCommand(cmdstr, con);
            try
            {
                cmd.ExecuteNonQuery();//执行SQL 语句并返回受影响的行数
                return 1;//成功返回１
            }
            catch (Exception e)
            {
                return 0;//失败返回０
            }
            finally
            {
                con.Dispose();//释放连接对象资源
            }
        }
        public DataTable selectReturnDataTable(string cmdstr, string tableName)
        {
            MySqlConnection con = GetCon();
            MySqlDataAdapter da = new MySqlDataAdapter(cmdstr, con);
            DataSet ds = new DataSet();
            da.Fill(ds, tableName);
            con.Dispose();
            return (ds.Tables[0]);
        }
        public MySqlDataReader selectReturnDataReader(string str)
        {
            MySqlConnection conn = GetCon();//连接数据库
            conn.Open();//并打开了连接
            MySqlCommand com = new MySqlCommand(str, conn);
            MySqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
            conn.Dispose();
            return dr;//返回SqlDataReader对象dr
        }
    }
}
