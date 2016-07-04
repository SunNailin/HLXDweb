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
    public class NoticeTypeDAO
    {
        private SQLHelper sqlhelper = null;
        public NoticeTypeDAO()
        {
            sqlhelper = new SQLHelper();
        }

        #region 增加公告类别
        /// <summary>
        ///增加公告类别
        /// </summary>
        /// <param name="tpName">公告类别名称</param>
        /// <returns></returns>
        public bool Insert(string tpName)
        {
            bool flag = false;
            string sql = "insert into notice_type(notice_type_name) values(@tpName)";
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

        #region 修改类别
        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <param name="tpName">类别名称</param>
        /// <returns></returns>
        public bool Update(NoticeType tp)
        {
            bool flag = false;
            string sql = "update notice_type set [notice_type_name]=@tpName where notice_type_id=@id";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@tpName",tp.Name),
                  new SqlParameter("@id",tp.Id)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
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
            bool flag = false;
            string sql = "select * from notice_type where [notice_type_name]='" + tpName + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql, CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 取出所有公告类别
        /// <summary>
        /// 取出所有公告类别
        /// </summary>
        /// <returns>返回查询到的数据</returns>
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            string sql = "select * from notice_type";
            dt = sqlhelper.ExecuteQuery(sql, CommandType.Text);
            return dt;
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
            bool flag = false;
            string sql = "delete from notice_type where news_type_id= @id";
            SqlParameter[] paras = new SqlParameter[]{
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
    }
}
