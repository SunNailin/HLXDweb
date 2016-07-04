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
    public partial class noticelist : System.Web.UI.Page
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
                //绑定新闻分类
                repNoticeType.DataSource = new NoticeTypeManager().SelectAll();
                repNoticeType.DataBind();
                //绑定所有新闻
                //联系我们边栏
                string id = "1";
                WebInfo webinfo = new WebInfo();
                WebInfoManager wim = new WebInfoManager();
                //index_address = sqlstr1;
                webinfo = wim.SelectByID(id);
                Label6.Text = webinfo.Address;
                Label7.Text = webinfo.Postcode;
                Label4.Text = webinfo.Contactor;
                Label8.Text = webinfo.Phone;
               Label9.Text = webinfo.Contactor;
                //第一次进入该页面时
                //绑定所有公告
                string notice_type_id = Request.QueryString["notice_type_id"];
                if (notice_type_id == null)
                {
                    gvAllNotice.DataSource = new NoticeManager().SelectAllNotice();
                    gvAllNotice.DataBind();
                }
                else
                {
                    gvAllNotice.DataSource = new NoticeManager().SelectNoticeByTypeID(notice_type_id);
                    gvAllNotice.DataBind();
                }
            }
        }
    }
}