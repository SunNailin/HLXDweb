/*
 *创建人：孙乃麟
 *创建时间：
 *说明：
 *版权所有：
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
    public class AdminDAO
    {
        private SQLHelper sqlhelper = null;
        public AdminDAO()
        {
            sqlhelper = new SQLHelper();
        }

        #region 增加管理员
        /// <summary>
        /// 增加管理员
        /// </summary>
        /// <param name="admin">管理员对象</param>
        /// <returns></returns>
        public bool Insert(Admin admin)
        {
            bool flag = false;
            string cmdText = "procAdminInsert";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("Loginname",admin.Loginname),
            new SqlParameter("Password",admin.Password),
            new SqlParameter("Typeid",admin.Typeid),
            new SqlParameter("Realname",admin.Realname),
             new SqlParameter("Email",admin.Email),
              new SqlParameter("Bywhom",admin.Bywhom),            
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
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
            bool flag = false;
            string cmdText = "procAdminDelete";
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

        #region 修改管理员
        /// <summary>
        /// 修改管理员
        /// </summary>
        /// <param name="admin">管理员实体对象</param>
        /// <returns></returns>
        public bool UpdateAdmin(Admin admin)
        {
            bool flag = false;
            string cmdText = "procAdminUpdate";
            SqlParameter[] paras = new SqlParameter[]{
              new  SqlParameter("@id",admin.Id),
              new SqlParameter("Loginname",admin.Loginname),
              new SqlParameter("Password",admin.Password),
              new SqlParameter("Typeid",admin.Typeid),
              new SqlParameter("Realname",admin.Realname),
              new SqlParameter("Email",admin.Email),
              new SqlParameter("Lastip",admin.Lastip),
              new SqlParameter("Lasttime",admin.Lasttime),
              new SqlParameter("Status",admin.Status),               
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
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
            DataTable dt = new DataTable();
            string cmdText = "procAdminSelectByTypeID";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@admin_type_id",typeID),
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region 选择全部管理员
        /// <summary>
        /// 选择全部管理员
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllAdmin()
        {
            DataTable dt = new DataTable();
            dt = sqlhelper.ExecuteQuery("procAdminSelectAllAdmin", CommandType.StoredProcedure);
            return dt;
        }
        #endregion


    }
}
