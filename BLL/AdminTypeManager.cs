/*
 * 
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
    public class AdminTypeManager
    {
        private AdminTypeDAO atpdao = null;
        public AdminTypeManager()
        {
            atpdao = new AdminTypeDAO();
        }

        #region 增加管理员类别
        /// <summary>
        ///增加管理员类别
        /// </summary>
        /// <param name="tpName">管理员类别名称</param>
        /// <returns></returns>
        public bool Insert(string tpName, int auth)
        {
            return atpdao.Insert(tpName,auth);
        }
        #endregion

        #region 删除管理员类别（连同其下的管理员一同删除）
        /// <summary>
        /// 删除管理员类别（连同其下的管理员一同删除）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            return atpdao.Delete(id);
        }
        #endregion

        #region 修改类别
        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <param name="tpName">类别名称</param>
        /// <returns></returns>
        public bool Update(AdminType tp)
        {
            return atpdao.Update(tp);
        }
        #endregion

        #region 取出所有管理员类别
        /// <summary>
        /// 取出所有管理员类别
        /// </summary>
        /// <returns>返回查询到的数据</returns>
        public DataTable SelectAll()
        {
            return atpdao.SelectAll();
        }
        #endregion

        #region 判断类别名称是否已经存在
        /// <summary>
        /// 判断类别名称是否已经存在
        /// </summary>
        /// <param name="tpName">管理员类别名称</param>
        /// <returns></returns>
        public bool IsExists(string tpName)
        {
            return atpdao.IsExists(tpName);
        }
        #endregion

    }
}
