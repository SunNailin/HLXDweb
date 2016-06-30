using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace HLXDweb
{
    public partial class newslist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //第一次进入该页面时
                //绑定新闻分类
                repNewsType.DataSource = new NewsTypeManager().SelectAll();
                repNewsType.DataBind();
                //绑定所有新闻
                gvAllNews.DataSource = new NewsManager().SelectAllNews();
                gvAllNews.DataBind();
            }
        }
    }
}