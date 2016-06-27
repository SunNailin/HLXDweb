using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class WebInfoDAO
    {
        private SQLHelper sqlhelper = null;
        public WebInfoDAO()
        {
            sqlhelper = new SQLHelper();
        }

        #region 更新网页信息
        /// <summary>
        /// 更新webInfo信息
        /// </summary>
        /// <param name="webInfo"></param>
        /// <returns></returns>
        public bool Update(WebInfo webInfo)
        {
            bool flag = false;
            string sql = "update webinfo set webinfo_clicks=@clicks where webinfo_id=@id";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@id",webInfo.Id),
                  new SqlParameter("@keywords",webInfo.Keywords),
                  new SqlParameter("@clicks",webInfo.Clicks),
                  new SqlParameter("@pic1",webInfo.Pic1),
                  new SqlParameter("@pic2",webInfo.Pic2),
                  new SqlParameter("@pic3",webInfo.Pic3),
                  new SqlParameter("@pic4",webInfo.Pic4),
                  new SqlParameter("@pic5",webInfo.Pic5),
                  new SqlParameter("@logo",webInfo.Logo),
                  new SqlParameter("@address",webInfo.Address),
                  new SqlParameter("@postcode",webInfo.Postcode),
                  new SqlParameter("@phone",webInfo.Phone),
                  new SqlParameter("@fax",webInfo.Fax),
                  new SqlParameter("@email",webInfo.Email),
                  new SqlParameter("@cotactor",webInfo.Contactor)
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
