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
            lbl_address.Text = webinfo.Address;
            lbl_contactor.Text = webinfo.Contactor;
            lbl_email.Text = webinfo.Email;
            lbl_phone.Text = webinfo.Phone;
            lbl_postcode.Text = webinfo.Postcode;
     
        }
    }
}