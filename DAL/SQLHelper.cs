using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class SQLHelper
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataReader sdr = null;

        /// <summary>
        /// SQLHelper类的构造函数
        /// </summary>
        public SQLHelper()
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            conn = new SqlConnection(connStr);
        }
        /// <summary>
        /// 数据库链接
        /// </summary>
        /// <returns></returns>
        private SqlConnection GetConn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        /// <summary>
        /// 该方法执行传入的增删改SQL语句
        /// </summary>
        /// <param name="sql">要执行的增删改SQL语句</param>
        /// <returns>返回更新的记录数</returns>
        public int ExecuteNonQuery(string sql)
        {
            int res;
            try
            {
                cmd = new SqlCommand(sql, GetConn());
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return res;
        }
        /// <summary>
        ///  执行带参数的SQL增删改语句
        /// </summary>
        /// <param name="sql">SQL增删改语句</param>
        /// <param name="paras">参数集合</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql, SqlParameter[] paras)
        {
            int res;
            using (cmd = new SqlCommand(sql, GetConn()))
            {
                //利用传参一定程度上避免SQL注入
               // cmd.Parameters.Add(new SqlParameter("@tpName","豪联夏都"));
                cmd.Parameters.AddRange(paras);
                res = cmd.ExecuteNonQuery();
            }
            return res;
        }

        /// <summary>
        /// 该方法执行传入的查询SQL语句
        /// </summary>
        /// <param name="sql">sql查询语句</param>
        /// <returns>返回查询结果</returns>
        public DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand(sql, GetConn());
            using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dt.Load(sdr);
            }
            return dt;
        }
    }
}
