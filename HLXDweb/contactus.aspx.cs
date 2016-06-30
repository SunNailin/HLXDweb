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
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebInfo webinfo = new WebInfo();
            WebInfoManager wim = new WebInfoManager();
            string id = "1";
            webinfo = wim.SelectByID(id);
            Label1.Text = webinfo.Phone;
            Label2.Text = webinfo.Contactor;
        }
    }
}