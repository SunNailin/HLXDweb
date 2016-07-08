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
    public partial class intro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebInfo webinfo = new WebInfo();
            WebInfoManager wim = new WebInfoManager();
            Intro intro = new Intro();
            IntroManager introm = new IntroManager();
            if (!Page.IsPostBack)
            {

                //第一次进入该页面时
                //绑定所有新闻
                string intro_id = Request.QueryString["intro_id"];
                if (intro_id == null)
                {
                    intro = introm.SelectByID("3");
                    Label8.Text = intro.Content;
                    Label9.Text = intro.Title;  
                }
                else
                {
                    intro = introm.SelectByID(intro_id);
                    Label8.Text = intro.Content;
                    Label9.Text = intro.Title;
                }


                //绑定简介类别分类
                repNewsType.DataSource = introm.SelectAll();
                repNewsType.DataBind();
                //联系我们边栏
                string webinfo_id = "1";
               //index_address = sqlstr1;
                webinfo = wim.SelectByID(webinfo_id);
                Label6.Text = webinfo.Address;
                Label7.Text = webinfo.Postcode;
                Label4.Text = webinfo.Contactor;
                
                // Label5.Text = webinfo.Email;        
            }
        }
    }
}