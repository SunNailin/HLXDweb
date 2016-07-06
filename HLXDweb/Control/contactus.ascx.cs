using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;


namespace HLXDweb.Control
{
    public partial class contactus : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //绑定新闻分类               
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
                // Label5.Text = webinfo.Email;
                //Label6.Text = webinfo.Phone;
            }
        }
    }
}