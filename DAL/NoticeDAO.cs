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
    public class NoticeDAO
    {
        private SQLHelper sqlhelper;
        public NoticeDAO()
        {
            sqlhelper = new SQLHelper();
        }

        #region 选择最新几条公告
        /// <summary>
        /// 选择最新几条公告
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewestNotice()
        {
            return sqlhelper.ExecuteQuery("procNoticeSelectNewestNotice", CommandType.StoredProcedure);
        }
        #endregion

        #region 选择全部公告
        /// <summary>
        /// 选择全部公告
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllNotice()
        {
            DataTable dt = new DataTable();
            dt = sqlhelper.ExecuteQuery("procNoticeSelectAllNotice", CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region 根据公告类别ID选择公告
        /// <summary>
        /// 根据公告类别ID选择公告
        /// </summary>
        /// <param name="typeID"></param>
        /// <returns></returns>

        public DataTable SelectNoticeByTypeID(string typeID)
        {
            DataTable dt = new DataTable();
            string cmdText = "procNoticeSelectByTypeID";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@notice_type_id",typeID),
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region 根据公告ID选择公告
        /// <summary>
        /// 根据公告ID选择公告
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Notice SelectByID(string id)
        {
            DataTable dt = new DataTable();
            Notice nt = new Notice();
            string cmdText = "procNoticeSelectNoticeByID";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@notice_id",id),
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            nt.Id = id;
            nt.Title = dt.Rows[0]["notice_title"].ToString();
            nt.Content = dt.Rows[0]["notice_content"].ToString();
            //n.Publisher = dt.Rows[0]["news_publisher"].ToString();
            nt.Time = dt.Rows[0]["notice_time"].ToString();
            nt.Typeid = dt.Rows[0]["notice_typeid"].ToString();
            return nt;
        }
        #endregion

        #region 插入公告
        /// <summary>
        /// 增加公告
        /// </summary>
        /// <param name="nt">公告对象</param>
        /// <returns></returns>
        public bool InsertNotice(Notice nt)
        {
            bool flag = false;
            string cmdText = "procNoticeInsert";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@title",nt.Title),
            new SqlParameter("@content",nt.Content),
            new SqlParameter("@typeid",nt.Typeid),
            new SqlParameter("@publisherid",nt.Publisherid),
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 修改公告
        /// <summary>
        /// 修改公告
        /// </summary>
        /// <param name="nt">公告实体对象</param>
        /// <returns></returns>
        public bool UpdateNotice(Notice n)
        {
            bool flag = false;
            string cmdText = "procNoticeUpdate";
            SqlParameter[] paras = new SqlParameter[]{
                new  SqlParameter("@id",n.Id),
                new SqlParameter("@title",n.Title),
                new SqlParameter("@content",n.Content),
                new SqlParameter("@typeid",n.Typeid),
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 删除公告
        /// <summary>
        /// 删除公告
        /// </summary>
        /// <param name="id">公告ID</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string cmdText = "procNoticeDelete";
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


    }
}
