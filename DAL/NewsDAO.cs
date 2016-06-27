/*
 * 创建人：孙乃麟
 * 创建时间：2016年5月
 * 说明：新闻内容操作类
 * 
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

        #region 选择最新10条新闻
        /// <summary>
        /// 取出最新的10条新闻（所属分类，新闻标题，发布时间，发布者）
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewestNews()
        {
            return sqlhelper.ExecuteQuery("procNewsSelectNewestNews", CommandType.StoredProcedure);
        }
        #endregion

        #region 根据新闻类别ID选择新闻
        /// <summary>
        /// 根据类别ID取出该类别下的新闻
        /// </summary>
        /// <param name="typeID">新闻类别ID</param>
        /// <returns></returns>
        public DataTable SelectNewsByTypeID(string typeID)
        {
            DataTable dt = new DataTable();
            string cmdText = "procNewsSelectByTypeID";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@news_type_id",typeID),
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;

        }
        #endregion

        #region 根据新闻ID查看新闻主体
        /// <summary>
        /// 根据新闻ID取出该条新闻的主体内容
        /// </summary>
        /// <param name="id">新闻ID</param>
        /// <returns></returns>
        public News SelectByID(string id)
        {
            DataTable dt = new DataTable();
            News n = new News();
            string cmdText = "procNewsSelectNewsByID";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@news_id",id),
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            n.Id = id;
            n.Title = dt.Rows[0]["news_title"].ToString();
            n.Content = dt.Rows[0]["news_content"].ToString();
            n.Publisher = dt.Rows[0]["news_publisher"].ToString();
            n.Time = dt.Rows[0]["news_time"].ToString();
            n.Typeid = dt.Rows[0]["news_typerid"].ToString();
            return n;
        }
        #endregion

        #region 插入新闻
        /// <summary>
        /// 增加新闻
        /// </summary>
        /// <param name="n">新闻对象</param>
        /// <returns></returns>
        public bool InsertNews(News n)
        {
            bool flag = false;
            string cmdText = "procNewsInsert";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@title",n.Title),
            new SqlParameter("@content",n.Content),
            new SqlParameter("@typeid",n.Typeid),
            new SqlParameter("@publisherid",n.Publisher),
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 修改新闻
        /// <summary>
        /// 修改新闻
        /// </summary>
        /// <param name="n">新闻实体对象</param>
        /// <returns></returns>
        public bool UpdateNews(News n)
        {
            bool flag = false;
            string cmdText = "procNewsUpdate";
            SqlParameter[] paras = new SqlParameter[]{
                new  SqlParameter("@id",n.Id),
                new SqlParameter("@title",n.Title),
                new SqlParameter("@content",n.Content),
                new SqlParameter("@typeid",n.Typeid),
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 删除新闻
        /// <summary>
        /// 删除新闻
        /// </summary>
        /// <param name="id">新闻的ID</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string cmdText = "procNewsDelete";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@id",id),
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 选择10条热点新闻
        /// <summary>
        /// 取出10条最热新闻
        /// </summary>
        /// <returns></returns>
        public DataTable SelectHotestNews()
        {
            DataTable dt = new DataTable();
            dt = sqlhelper.ExecuteQuery("procNewsSelectHotestNews", CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region 根据标题查找新闻（暂未实现）
        /// <summary>
        /// 根据标题搜索新闻  视频15，25分钟处（暂无）
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public DataTable SelectByTitle(string title)
        {
            //TODO:根据标题搜索新闻
            DataTable dt = new DataTable();
            return dt;
        }
        #endregion

        #region 根据内容查找新闻（暂未实现）
        /// <summary>
        /// 根据内容搜索新闻  视频15，25分钟处（暂无）
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public DataTable SelectByContent(string content)
        {
            //TODO:根据内容搜索新闻
            DataTable dt = new DataTable();
            return dt;
        }
        #endregion
    }
}
