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
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class IntroManager
    {
        private IntroTypeDAO idao = null;
        public IntroManager()
        {
            idao = new IntroTypeDAO();
        }

        #region 增加简介类别
        /// <summary>
        /// 增加类别
        /// </summary>
        /// <param name="tpName">简介类别名称</param>
        /// <returns></returns>
        public bool Insert(string tpName)
        {
            return idao.Insert(tpName);
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
            return idao.Update(id, tpName);
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
            return idao.IsExists(tpName);
        }
        #endregion

        #region 取出所有简介类别
        /// <summary>
        /// 取出所有简介类别
        /// </summary>
        /// <returns>返回查询到的数据</returns>
        public DataTable SelectAll()
        {
            return idao.SelectAll();
        }
        #endregion

        #region 根据简介ID取出简介主体
        /// <summary>
        /// 根据简介ID取出简介主体
        /// </summary>
        /// <param name="id">简介ID</param>
        /// <returns></returns>
        public Intro SelectByID(string id)
        {
            return idao.SelectByID(id);
        }
        #endregion

    }
}
