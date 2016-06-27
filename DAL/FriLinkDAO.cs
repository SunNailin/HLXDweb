/*
 * 创建人：孙乃麟
 * 创建时间：2016年5月
 * 说明：友情链接表操作类
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
   public class FriLinkDAO
    {
       private SQLHelper sqlhelper = null;
        public FriLinkDAO()
        {
            sqlhelper = new SQLHelper();
        }
        
       #region 增加友情链接
        /// <summary>
        /// 增加友情链接
        /// </summary>
        /// <param name="friLink">友情链接对象</param>
        /// <returns></returns>
        public bool Insert(FriendLink friLink)
        {
            bool flag = false;
            string sql = "insert into frilink (frilink_title,frilink_url,frilink_sortid,frilink_pic,frilink_clicks) values(@fltitle,@flurl,@flsortid,@flpic,@flclicks)";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@fltitle",friLink.FLTitle),
                  new SqlParameter("@flurl",friLink.FLURL),
                  new SqlParameter("@flsortid",friLink.FLSortID),
                  new SqlParameter("@flpic",friLink.FLPic),
                  new SqlParameter("@flclicks",friLink.FLClicks),
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 修改友情链接
        /// <summary>
       /// 修改友情链接
       /// </summary>
       /// <param name="friLink">友情链接对象</param>
       /// <returns></returns>
        public bool Update(FriendLink friLink)
        {
            bool flag = false;
            string sql = "update frilink set [intro_type_name]=@tpName where intro_type_id=@id";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@fltitle",friLink.FLTitle),
                  new SqlParameter("@flurl",friLink.FLURL),
                  new SqlParameter("@flsortid",friLink.FLSortID),
                  new SqlParameter("@flpic",friLink.FLPic),
                  new SqlParameter("@flclicks",friLink.FLClicks),
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 判断友情链接名称是否已经存在
        /// <summary>
        /// 判断友情链接名称是否已经存在
        /// </summary>
        /// <param name="flTitle">友情链接名称</param>
        /// <returns></returns>
        public bool IsExists(string flTitle)
        {
            bool flag = false;
            string sql = "select * from frilink where [frilink_title]=@flTitle ";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@flTitle",flTitle)
            };
            DataTable dt = sqlhelper.ExecuteQuery(sql, CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 取出所有友情链接
        /// <summary>
        /// 取出所有友情链接
        /// </summary>
        /// <returns>返回查询到的数据</returns>
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            string sql = "select * from frilink";
            dt = sqlhelper.ExecuteQuery(sql,CommandType.Text);
            return dt;
        }
        #endregion

        #region 删除友情链接
        /// <summary>
        /// 删除友情链接
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string sql = "delete from frilink where frilink_id= @id";
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
