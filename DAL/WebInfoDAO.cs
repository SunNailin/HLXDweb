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
        public bool Update(WebInfo webInfo,string id)
        {
            bool flag = false;
            string sql = "update webinfo set webinfo_clicks=@clicks where webinfo_id=@id";
            SqlParameter[] paras = new SqlParameter[]{
                  new SqlParameter("@id",id),
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

        #region 取出网页信息
        /// <summary>
        /// 取出网页信息
        /// </summary>
        /// <param name="id">网页信息ID</param>
        /// <returns></returns>
        public WebInfo SelectByID(string id)
        {
            DataTable dt = new DataTable();
            WebInfo wi = new WebInfo();
            string cmdText = "procWebinfoSelectWebinfoByID";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@webinfo_id",id),
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            wi.Id = id;
            wi.Keywords = dt.Rows[0]["webinfo_keywords"].ToString();
            wi.Logo = dt.Rows[0]["webinfo_logo"].ToString();
            wi.Phone = dt.Rows[0]["webinfo_phone"].ToString();
            wi.Pic1 = dt.Rows[0]["webinfo_pic1"].ToString();
            wi.Pic2 = dt.Rows[0]["webinfo_pic2"].ToString();
            wi.Pic3 = dt.Rows[0]["webinfo_pic3"].ToString();
            wi.Pic4 = dt.Rows[0]["webinfo_pic4"].ToString();
            wi.Pic5 = dt.Rows[0]["webinfo_pic5"].ToString();
            wi.Postcode = dt.Rows[0]["webinfo_postcode"].ToString();
            wi.Address = dt.Rows[0]["webinfo_address"].ToString();
            //wi.Clicks = (double)dt.Rows[0]["webinfo_clicks"];
            wi.Contactor = dt.Rows[0]["webinfo_contactor"].ToString(); 
            wi.Email = dt.Rows[0]["webinfo_email"].ToString();
            wi.Fax = dt.Rows[0]["webinfo_fax"].ToString();
           
            return wi;
        }
        #endregion


    }
}
