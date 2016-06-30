/*
 *创建人：孙乃麟
 *说明：新闻表的类别类
 *版权所有：
*/
using System;
using System.Collections.Generic;using BLL;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;
using Model;
using System.Linq;
using System.Text;
using System.Data;


namespace BLL
{
    public class NewsManager
    {
        private NewsDAO ndao = null;
        public NewsManager()
        {
            ndao = new NewsDAO();
        }

        #region 选择最新10条新闻
        /// <summary>
        /// 取出最新的10条新闻（所属分类，新闻标题，发布时间，发布者）
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewestNews()
        {
            return ndao.SelectNewestNews();
        }
        #endregion

        #region 取出全部新闻
        /// <summary>
        /// 取出全部新闻（所属分类，新闻标题，发布时间，发布者）
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllNews()
        {
            return ndao.SelectAllNews();
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
            return ndao.SelectNewsByTypeID(typeID);

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
            return ndao.SelectByID(id);
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
            return ndao.InsertNews(n);
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
            return ndao.UpdateNews(n);
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
            return ndao.Delete(id);
        }
        #endregion

        #region 选择10条热点新闻
        /// <summary>
        /// 取出10条最热新闻
        /// </summary>
        /// <returns></returns>
        public DataTable SelectHotestNews()
        {
            return ndao.SelectHotestNews();
        }
        #endregion

    }
}
