using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BootstrapTest.Models.SqlServerOperation
{
    public class SqlBasicOperation
    {
        string connstring = ConfigurationManager.ConnectionStrings["SQLserverConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        //打开数据库
        public bool OpenDB()
        {
            conn = new SqlConnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.ConnectionString = connstring;
            }
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //关闭数据库
        public void CloseDB()
        {
            if (conn != null)
            {
                try
                {
                    conn.Close();
                    conn.Dispose();
                    conn = null;
                }
                catch (Exception ex)
                {
                }
            }
        }
        //向数据库插入信息
        public int Insert(string sqlorder)
        {
            OpenDB();//连接数据库

            SqlCommand cmd = new SqlCommand(sqlorder, conn);
            int i = cmd.ExecuteNonQuery();//执行并返回参数
            CloseDB();
            return i;//i为ExecuteNonQuery影响的行数
        }
        //查询数据库信息
        public DataSet Search(string sqlorder)
        {
            OpenDB();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlorder, conn);
            adapter.Fill(ds);
            CloseDB();
            return ds;
        }
        //更新数据库信息
        public int Update(string sqlorder)
        {
            OpenDB();
            SqlCommand cmd = new SqlCommand(sqlorder, conn);
            int i = cmd.ExecuteNonQuery();
            CloseDB();
            return i;          
        }
        //删除数据库信息
        public int Delete(string sqlorder)
        {
            OpenDB();
            SqlCommand cmd = new SqlCommand(sqlorder, conn);
            int i = cmd.ExecuteNonQuery();
            CloseDB();
            return i;
        }

    }
}