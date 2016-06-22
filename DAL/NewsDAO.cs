/*
 * 创建人：孙乃麟
 * 创建时间：2016年5月
 * 说明：新闻内容操作类
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
    public class NewsDAO
    {
        private SQLHelper sqlhelper;
        public NewsDAO()
        {
            sqlhelper = new SQLHelper();
        }

        /// <summary>
        /// 取出最新的10条新闻（所属分类，新闻标题，发布时间，发布者）
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewestNews()
        {
            return sqlhelper.ExecuteQuery("procNewsSelectNewestNews",CommandType.StoredProcedure);
        }
        //根据类别ID取出该类别下的新闻
        public DataTable SelectNewsByTypeID(string typeID)
        {
            //TODO:根据类别ID取出该类别下的新闻
            DataTable dt = new DataTable();
            return dt;

        }

        //根据新闻ID取出该条新闻的主题内容        
        public News SelectByID(string id)
        {
            //TODO:根据新闻ID取出该条新闻的主题内容
            News n = new News();
            return n;
        }
        
        //增加新闻
        public bool InsertNews(News n)
        {
            //TODO:增加新闻
            bool flag = false;
            return flag;
        }

        //修改新闻
        public bool UpdateNews(News n)
        {
            //TODO:修改新闻
            bool flag = false;
            return flag;
        }

        /// <summary>
        /// 删除新闻
        /// </summary>
        /// <param name="id">新闻的ID</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string sql = "delete from news where news_id= @id";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@id",id)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras,CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        //根据标题搜索新闻
        public DataTable SelectByTitle(string title)
        {
            //TODO:根据标题搜索新闻
            DataTable dt = new DataTable();
            return dt;
        }
        //根据内容搜索新闻
        public DataTable SelectByContent(string content)
        {
            //TODO:根据内容搜索新闻
            DataTable dt = new DataTable();
            return dt;
        }
        //取出最热的10条新闻
        public DataTable SelectHotestNews()
        {
            //TODO:取出最热的10条新闻
            DataTable dt = new DataTable();
            return dt;
        }
    }
}
