using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace HLXDweb
{
    public partial class intro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //绑定简介类别分类
            repNewsType.DataSource = new IntroManager().SelectAll();
            repNewsType.DataBind();
        }
    }
}