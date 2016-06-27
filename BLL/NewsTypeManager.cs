/*
 * 新闻类别表的业务类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;
using DAL;

namespace BLL
{
    public class NewsTypeManager
    {
        private NewsTypeDAO ntpdao = null;
        public NewsTypeManager()
        {
            ntpdao = new NewsTypeDAO();
        }
        #region 增加新闻类别
        /// <summary>
        ///增加新闻类别
        /// </summary>
        /// <param name="tpName">新闻类别名称</param>
        /// <returns></returns>
        public bool Insert(string tpName)
        {
            return ntpdao.Insert(tpName);
        }
        #endregion

        #region 修改类别
        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <param name="tpName">类别名称</param>
        /// <returns></returns>
        public bool Update(NewsType tp)
        {
            return ntpdao.Update(tp);
        }
        #endregion

        #region 判断类别名称是否已经存在
        /// <summary>
        /// 判断类别名称是否已经存在
        /// </summary>
        /// <param name="tpName">新闻类别名称</param>
        /// <returns></returns>
        public bool IsExists(string tpName)
        {
            return ntpdao.IsExists(tpName);
        }
        #endregion

        #region 取出所有新闻类别
        /// <summary>
        /// 取出所有新闻类别
        /// </summary>
        /// <returns>返回查询到的数据</returns>
        public DataTable SelectAll()
        {
            return ntpdao.SelectAll();
        }
        #endregion

        #region 删除新闻类别（连同其下的新闻一同删除）
        /// <summary>
        /// 删除新闻类别（连同其下的新闻一同删除）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            return ntpdao.Delete(id);
        }
        #endregion
    }
}
