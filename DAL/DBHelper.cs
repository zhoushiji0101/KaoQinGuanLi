using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class DBHelper
    {
        //静态的数据库连接字符串
        public static string connStr = "Data Source=.;Initial Catalog=Attendance;Integrated Security=True";
        //公共的链接对象
        public static SqlConnection conn = new SqlConnection(connStr);
        //如果conn的状态是关闭的，打开连接
        public static void Open()
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        //如果conn的状态是打开的，关闭连接
        public static void Closed()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }


        //公共的查询方法
        public static DataTable comSelect(string sql)
        {
            //命令对象，检查sql语句和连接对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            //if (sp != null)
            //{
            //    cmd.Parameters.AddRange(sp);
            //}
            //适配器，检查sql语句和连接对象
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //定义数据表格
            DataTable dt = new DataTable();
            //把表格填充到适配器
            sda.Fill(dt);
            return dt;//返回表格
        }


        //增删改公用方法
        public static int insertUpDel(string sql)
        {
            try
            {
                Open();//打开连接
                //命令对象，检查sql语句和连接对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                //if (sp!=null)
                //{
                //    cmd.Parameters.AddRange(sp);
                //}
                //执行sql语句，并返回影响记录行数
                return  cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally {
                Closed();//最后关闭连接
            }            
        }






    }
}