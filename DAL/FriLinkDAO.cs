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
            int res = sqlhelper.ExecuteNonQuery(sql, paras);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        
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
            int res = sqlhelper.ExecuteNonQuery(sql, paras);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 判断类别名称是否已经存在
        /// </summary>
        /// <param name="tpName">简介类别名称</param>
        /// <returns></returns>
        public bool IsExists(string tpName)
        {
            bool flag = false;
            string sql = "select * from intro_type where [intro_type_name]='" + tpName + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 取出所有新闻类别
        /// </summary>
        /// <returns>返回查询到的数据</returns>
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            string sql = "select * from news_type";
            dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }

        /// <summary>
        /// 删除新闻类别（连同其下的新闻一同删除）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string sql = "delete from news_type where news_type_id= @id";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@id",id)
            };
            int res = sqlhelper.ExecuteNonQuery(sql, paras);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
    }
}
