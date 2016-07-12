using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BLL;
using Model;

namespace HLXDweb
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            LoginManager lgmng = new LoginManager();            
            string name = txtName.Text.Trim();
            string pwd = txtPassword.Text.Trim();
            bool b = lgmng.CheckLogin(name, pwd);
            if (b)
            {
                //登录成功跳转
                Session["admin"] = name;
                Response.Redirect("manage.aspx");
            }
            else 
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('登录失败，用户名或密码输入错误！');</script>");
            }

        }
    }
}