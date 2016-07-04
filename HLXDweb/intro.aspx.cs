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
            string intro_id = "3";

            intro = introm.SelectByID(intro_id);
            //绑定简介类别分类
            repNewsType.DataSource = introm.SelectAll();
            repNewsType.DataBind();
            //联系我们边栏
            string webinfo_id = "1";
            string content = intro.Content;
            //index_address = sqlstr1;
            webinfo = wim.SelectByID(webinfo_id);
            Label6.Text = webinfo.Address;
            Label7.Text = webinfo.Postcode;
            Label8.Text = content;
            Label4.Text = webinfo.Contactor;
            // Label5.Text = webinfo.Email;        
        }
    }
}