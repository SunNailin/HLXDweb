/*
 *创建人：孙乃麟
 *创建时间：
 *说明：
 *版权所有：
*/
using System;
using System.Collections.Generic;
using BLL;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;
using Model;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class NoticeManager
    {
        private NoticeDAO ntdao = null;
        public NoticeManager()
        {
            ntdao = new NoticeDAO();
        }

        #region 选择最新几条公告
        /// <summary>
        /// 选择最新几条公告
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewestNotice()
        {
            return ntdao.SelectNewestNotice();
        }
        #endregion

        #region 选择全部公告
        /// <summary>
        /// 选择全部公告
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllNotice()
        {
            return ntdao.SelectAllNotice();
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
            return ntdao.SelectNoticeByTypeID(typeID);
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
            return ntdao.SelectByID(id);
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
            return ntdao.InsertNotice(nt);
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
            return ntdao.UpdateNotice(n);
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
            return ntdao.Delete(id);
        }
        #endregion
    }
}
