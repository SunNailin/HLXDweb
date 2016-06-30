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
    public class WebInfoManager
    {
        private WebInfoDAO widao = null;
        public WebInfoManager()
        {
            widao = new WebInfoDAO();
        }

        #region 更新网页信息
        /// <summary>
        /// 更新webInfo信息
        /// </summary>
        /// <param name="webInfo"></param>
        /// <returns></returns>
        public bool Update(WebInfo webInfo,string id)
        {
            return widao.Update(webInfo,id);
        }
        #endregion

        #region 取出网页信息
        /// <summary>
        /// 取出网页信息
        /// </summary>
        /// <param name="id">网页信息ID</param>
        /// <returns></returns>
        public WebInfo SelectByID(string id)
        {
            return widao.SelectByID(id);
        }
        #endregion

    }
}
