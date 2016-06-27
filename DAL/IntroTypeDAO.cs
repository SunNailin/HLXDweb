/*
 * 创建人：孙乃麟
 * 创建时间：2016年5月
 * 说明：公司简介类别表操作类
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 公司简介表操作类
    /// </summary>
    public class IntroTypeDAO
    {
        private SQLHelper sqlhelper = null;
        public IntroTypeDAO()
        {
            sqlhelper = new SQLHelper();
        }

        #region 增加简介类别
        /// <summary>
        /// 增加类别
        /// </summary>
        /// <param name="tpName">简介类别名称</param>
        /// <returns></returns>
        public bool Insert(string tpName)
        {
            bool flag = false;
            string sql = "insert into intro_type(intro_type_name) values(@tpName)";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@tpName",tpName)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 修改简介类别
        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <param name="tpName">类别名称</param>
        /// <returns></returns>
        public bool Update(string id, string tpName)
        {
            bool flag = false;
            string sql = "update intro_type set [intro_type_name]=@tpName where intro_type_id=@id";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@tpName",tpName),
                  new SqlParameter("@id",id)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 判断类别名称是否存在
        /// <summary>
        /// 判断类别名称是否已经存在
        /// </summary>
        /// <param name="tpName">简介类别名称</param>
        /// <returns></returns>
        public bool IsExists(string tpName)
        {
            bool flag = false;
            string sql = "select * from intro_type where [intro_type_name]='" + tpName + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql, CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 取出所有简介类别
        /// <summary>
        /// 取出所有简介类别
        /// </summary>
        /// <returns>返回查询到的数据</returns>
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            string sql = "select * from intro_type";
            dt = sqlhelper.ExecuteQuery(sql, CommandType.Text);
            return dt;
        }
        #endregion
    }
}
