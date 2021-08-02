using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        //const string connString = "Data Source=.;Initial Catalog=Attendance;Integrated Security=True";
        ////创建连接对象
        //static SqlConnection conn = new SqlConnection(connString);

        public int login(string username, string userpwd)
        {
            ////实例化数据集对象
            //DataTable dt = new DataTable();
            //创建T-SQL语句
            string sql = string.Format("select * from UserInfo where UserName='{0}' and Password='{1}'", username, userpwd);
            //创建数据适配器对象
            //SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //sda.Fill(dt);
            DataTable dt=DBHelper.comSelect(sql);
            return dt.Rows.Count;
        }
    }
}
