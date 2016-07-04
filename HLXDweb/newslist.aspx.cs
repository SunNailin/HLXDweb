using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using DAL;

namespace HLXDweb
{
    public partial class newslist : System.Web.UI.Page
    {

        #region 将指定字符串按指定长度进行剪切
        /// <summary>
        /// 将指定字符串按指定长度进行剪切
        /// </summary>
        /// <param name="oldStr">需要截取的长度</param>
        /// <param name="maxLength">字符串的最大长度</param>
        /// <param name="endWith">超过长度的后缀</param>
        /// <returns>如果超过最大长度，返回截断后得新字符串加上后缀，否则，返回原字符串</returns>
        public static string StringTruncate(string oldStr, int maxLength, string endWith)
        {
            if (string.IsNullOrEmpty(oldStr))
                //throw new NullReferenceException("原字符串不能为空");
                return oldStr + endWith;
            if (maxLength < 1)
                throw new Exception("返回的字符串长度必须大于[0]");
            if (oldStr.Length > maxLength)
            {
                string strTmp = oldStr.Substring(0, maxLength);
                if (string.IsNullOrEmpty(endWith))
                    return strTmp;
                else
                    return strTmp + endWith;
            }

            return oldStr;
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                //第一次进入该页面时
                //绑定所有新闻
                string news_type_id = Request.QueryString["news_type_id"];
                if (news_type_id ==null)
                {
                    gvAllNews.DataSource = new NewsManager().SelectAllNews();
                    gvAllNews.DataBind();
                }
                else
                {
                    gvAllNews.DataSource = new NewsManager().SelectNewsByTypeID(news_type_id);
                    gvAllNews.DataBind();
                }
            }
        }

    }
}