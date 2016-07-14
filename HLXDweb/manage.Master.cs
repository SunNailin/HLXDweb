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
    public partial class manage1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region 每次进入页面的时候判断是否登录(Session内是否存在管理员)
            // 
            LoginManager lgm = new LoginManager();
            if (Session["admin"] != null && lgm.isLogined(Session["admin"].ToString()))
            {
                //Response.Write("登录成功！");
                if (!Page.IsPostBack)
                {
                    //页面第一次加载时，绑定类别列表                    
                    LoadTree();
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }

       
            #endregion
        }

        #region 导航加载
        protected void LoadTree()
        {
            //管理导航一级菜单
            trManage.Nodes.Clear();
            TreeNode node1 = new TreeNode();
            node1.Text = "管理操作说明";
            trManage.Nodes.Add(node1);
            TreeNode node2 = new TreeNode();
            node2.Text = "网站信息管理";
            trManage.Nodes.Add(node2);
            TreeNode node3 = new TreeNode();
            node3.Text = "管理员管理";
            trManage.Nodes.Add(node3);
            TreeNode node4 = new TreeNode();
            node4.Text = "新闻管理";
            trManage.Nodes.Add(node4);
            TreeNode node5 = new TreeNode();
            node5.Text = "公告管理";
            trManage.Nodes.Add(node5);
            TreeNode node6 = new TreeNode();
            node6.Text = "产品管理";
            trManage.Nodes.Add(node6);
            TreeNode node7 = new TreeNode();
            node7.Text = "葡萄酒博物馆管理";
            trManage.Nodes.Add(node7);
            TreeNode node8 = new TreeNode();
            node8.Text = "采摘乐园管理";
            trManage.Nodes.Add(node8);


            //管理员管理二级菜单
            TreeNode node31 = new TreeNode();
            node31.Text = "管理员类别管理";
            node3.ChildNodes.Add(node31);
            TreeNode node32 = new TreeNode();
            node32.Text = "管理员详情管理";
            node3.ChildNodes.Add(node32);

            //新闻管理二级菜单
            TreeNode node41 = new TreeNode();
            node41.Text = "新闻类别管理";
            node4.ChildNodes.Add(node41);
            TreeNode node42 = new TreeNode();
            node42.Text = "新闻详情管理";
            node4.ChildNodes.Add(node42);
            TreeNode node43 = new TreeNode();
            node43.Text = "发布新闻";
            node4.ChildNodes.Add(node43);

            //公告管理二级菜单
            TreeNode node51 = new TreeNode();
            node51.Text = "公告类别管理";
            node5.ChildNodes.Add(node51);
            TreeNode node52 = new TreeNode();
            node52.Text = "公告详情管理";
            node5.ChildNodes.Add(node52);
            TreeNode node53 = new TreeNode();
            node53.Text = "发布公告";
            node5.ChildNodes.Add(node53);

            //产品管理二级菜单
            TreeNode node61 = new TreeNode();
            node61.Text = "公告类别管理";
            node6.ChildNodes.Add(node61);
            TreeNode node62 = new TreeNode();
            node62.Text = "公告详情管理";
            node6.ChildNodes.Add(node62);
            TreeNode node63 = new TreeNode();
            node63.Text = "发布公告";
            node6.ChildNodes.Add(node63);

            //葡萄酒博物馆管理二级菜单

            //采摘乐园管理二级菜单



        }
        #endregion

        #region 导航选择
        protected void trManage_select(object sender, EventArgs e)
        {
            string selectedtext = trManage.SelectedNode.Text.Trim();

            switch (selectedtext)
            {
                case "管理操作说明": Response.Redirect("~/manage.aspx");
                    break;
                case "网站信息管理": Response.Redirect("~/webinfo_manage.aspx");
                    break;
                case "管理员管理": Response.Redirect("~/admintype_manage.aspx");
                    break;
                case "管理员类别管理": Response.Redirect("~/admintype_manage.aspx");
                    break;
                case "新闻类别管理": Response.Redirect("~/newstype_manage.aspx");
                    break;
                case "退出": Response.Redirect("Exit.aspx");
                    break;
                default: Response.Redirect("index.aspx");
                    break;


            }
        }
        #endregion

    }
}