using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;


namespace HLXDweb.Control
{
    public partial class Footer : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = "1";
            WebInfo webinfo = new WebInfo();
            WebInfoManager wim = new WebInfoManager();
            webinfo = wim.SelectByID(id);
            Label8.Text = webinfo.Phone;
            Label9.Text = webinfo.Contactor;

        }
    }
}