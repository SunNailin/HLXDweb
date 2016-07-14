using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using Model;

namespace HLXDweb
{
    public partial class manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                        
        }



        #region 添加类别
        //添加类别
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = txtNTPName.Text.Trim();
            NewsTypeManager ntpm = new NewsTypeManager();

            //先判断类别名是否已经存在
            if (ntpm.IsExists(name))
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('类别名称已经存在，请重新输入！');</script>");
                txtNTPName.Text = "";
                return;
            }
            bool b = ntpm.Insert(name);
            if (b)
            {
                //清空文本框
                txtNTPName.Text = "";
                //添加成功，重新绑定类别列表
                DataTable dt = ntpm.SelectAll();
                gvNTP.DataSource = dt;
                gvNTP.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('类别添加失败，请联系开发人员！');</script>");

            }
        }
        #endregion

        #region 删除类别
        protected void lkbtnDelNTP_Click(object sender, EventArgs e)
        {
            NewsTypeManager ntpm = new NewsTypeManager();
            LinkButton lb = (LinkButton)sender;
            string id = lb.CommandArgument;
            bool b = ntpm.Delete(id);
            if (b)
            {
                DataTable dt = ntpm.SelectAll();
                gvNTP.DataSource = dt;
                gvNTP.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('类别删除失败，请联系开发人员！');</script>");

            }
        }
        #endregion


        protected void lkbtnUpdNTP_Click(object sender, GridViewEditEventArgs e)
        {
            this.gvNTP.EditIndex = e.NewEditIndex;
            GView();
        }

        private void GView()
        {
            NewsTypeManager ntpm = new NewsTypeManager();
            DataTable dt = ntpm.SelectAll();
            gvNTP.DataSource = dt;
            gvNTP.DataBind();
        }


        protected void gvNTP_RowEditing(object sender, GridViewEditEventArgs e)
        {//激活编辑button的事件  
            this.gvNTP.EditIndex = e.NewEditIndex;
            GView();
        }
        protected void gvNTP_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {//取消编辑状态的事件  
            gvNTP.EditIndex = -1;
            GView();
        }

        protected void gvNTP_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {//执行更新
            NewsTypeManager ntpm = new NewsTypeManager();
            NewsType ntp = new NewsType();

            string cell1 = ((TextBox)(gvNTP.Rows[e.RowIndex].Cells[0].Controls[0])).Text.ToString().Trim();//第一列注意这种写法很重要
            string cell2 = ((TextBox)(gvNTP.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();//第二列注意这种写法很重要
            ntp.Id = cell1;
            ntp.NewsTypeName = cell2;
            ntpm.Update(ntp);
            gvNTP.EditIndex = -1;
            GView();
        }

      
    }
}
