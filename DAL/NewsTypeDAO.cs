/*
 * 创建人：孙乃麟
 * 创建时间：2016年5月
 * 说明：新闻类别表操作类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    /// <summary>
    /// 新闻类别表操作类
    /// </summary>
    public class NewsTypeDAO
    {
        private SQLHelper sqlhelper = null;
        public NewsTypeDAO()
        {
            sqlhelper = new SQLHelper();
        }

        /// <summary>
        /// 增加类别
        /// </summary>
        /// <param name="tpName">新闻类别名称</param>
        /// <returns></returns>
        public bool Insert(string tpName)
        {
            bool flag = false;
            string sql = "insert into news_type(news_type_name) values(@tpName)";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@tpName",tpName)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <param name="tpName">类别名称</param>
        /// <returns></returns>
        public bool Update(NewsType tp)
        {
            bool flag = false;
            string sql = "update news_type set [news_type_name]=@tpName where news_type_id=@id";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@tpName",tp.NewsTypeName),
                  new SqlParameter("@id",tp.Id)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 判断类别名称是否已经存在
        /// </summary>
        /// <param name="tpName">新闻类别名称</param>
        /// <returns></returns>
        public bool IsExists(string tpName)
        {
            bool flag = false;
            string sql = "select * from news_type where [news_type_name]='" + tpName + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 取出所有新闻类别
        /// </summary>
        /// <returns>返回查询到的数据</returns>
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            string sql = "select * from news_type";
            dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }

        /// <summary>
        /// 删除新闻类别（连同其下的新闻一同删除）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string sql = "delete from news_type where news_type_id= @id";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@id",id)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

    }
}

