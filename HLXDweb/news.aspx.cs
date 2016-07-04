using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace HLXDweb
{
    public partial class news : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            News ns = new News();
            NewsManager nsm = new NewsManager();
            if (!Page.IsPostBack)
            {
                string news_id = Request.QueryString["news_id"];
                if (news_id ==null)
                {
                  
                }
                else
                {
                    ns = nsm.SelectByID(news_id);
                    Label1.Text = ns.Time;
                    Label2.Text = ns.Content;
                    Label3.Text = ns.Title;
                }
            }
            ////第一次进入该页面时
            ////绑定新闻分类
            ////repNewsType.DataSource = new NewsTypeManager().SelectAll();
            ////repNewsType.DataBind();
            ////绑定所有新闻
            ////联系我们边栏
            //string id = "1";
            //WebInfo webinfo = new WebInfo();
            //WebInfoManager wim = new WebInfoManager();
            ////index_address = sqlstr1;
            //webinfo = wim.SelectByID(id);
            //Label6.Text = webinfo.Address;
            //Label7.Text = webinfo.Postcode;
            //Label8.Text = webinfo.Phone;
            //Label4.Text = webinfo.Contactor;
            //// Label5.Text = webinfo.Email;
            ////Label6.Text = webinfo.Phone;
            //Label9.Text = webinfo.Contactor;
        }
    }
}