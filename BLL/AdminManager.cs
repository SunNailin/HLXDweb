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
    public class AdminManager
    {
        private AdminDAO adao = null;
        public AdminManager()
        {
            adao = new AdminDAO();
        }

        #region 增加管理员
        /// <summary>
        /// 增加管理员
        /// </summary>
        /// <param name="admin">管理员对象</param>
        /// <returns></returns>
        public bool InsertNotice(Admin admin)
        {
            return adao.Insert(admin);
        }
        #endregion

        #region 删除管理员
        /// <summary>
        /// 删除管理员
        /// </summary>
        /// <param name="id">管理员ID</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            return adao.Delete(id);
        }
        #endregion

        #region 修改管理员
        /// <summary>
        /// 修改管理员
        /// </summary>
        /// <param name="admin">管理员实体对象</param>
        /// <returns></returns>
        public bool UpdateAdmin(Admin admin)
        {
            return adao.UpdateAdmin(admin);
        }
        #endregion

        #region 根据管理员类别ID选择管理员
        /// <summary>
        /// 根据管理员类别ID选择管理员
        /// </summary>
        /// <param name="typeID"></param>
        /// <returns></returns>

        public DataTable SelectAdminByTypeID(string typeID)
        {
            return adao.SelectAdminByTypeID(typeID);
        }
        #endregion

        #region 选择全部管理员
        /// <summary>
        /// 选择全部管理员
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllAdmin()
        {
            return adao.SelectAllAdmin();
        }
        #endregion
    }
}
