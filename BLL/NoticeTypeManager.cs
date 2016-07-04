
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
    public class NoticeTypeManager
    {
        private NoticeTypeDAO nttpdao = null;
        public NoticeTypeManager()
        {
            nttpdao = new NoticeTypeDAO();
        }

        #region 增加公告类别
        /// <summary>
        ///增加公告类别
        /// </summary>
        /// <param name="tpName">公告类别名称</param>
        /// <returns></returns>
        public bool Insert(string tpName)
        {
            return nttpdao.Insert(tpName);
        }
        #endregion

        #region 修改类别
        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <param name="tpName">类别名称</param>
        /// <returns></returns>
        public bool Update(NoticeType tp)
        {
            return nttpdao.Update(tp);
        }
        #endregion

        #region 判断类别名称是否已经存在
        /// <summary>
        /// 判断类别名称是否已经存在
        /// </summary>
        /// <param name="tpName">公告类别名称</param>
        /// <returns></returns>
        public bool IsExists(string tpName)
        {
            return nttpdao.IsExists(tpName);
        }
        #endregion

        #region 取出所有公告类别
        /// <summary>
        /// 取出所有公告类别
        /// </summary>
        /// <returns>返回查询到的数据</returns>
        public DataTable SelectAll()
        {
            return nttpdao.SelectAll();
        }
        #endregion

        #region 删除公告类别（连同其下的公告一同删除）
        /// <summary>
        /// 删除公告类别（连同其下的公告一同删除）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            return nttpdao.Delete(id);
        }
        #endregion
    }
}
