<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage.aspx.cs" Inherits="HLXDweb.manage" %>

<%@ Register Src="Control/headerANDnav.ascx" TagName="headerANDnav" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>网站信息管理—豪联夏都</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="listWrap">
        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <h3>
                网站信息管理<span>您现在所在的位置：<a href="manage.aspx">网站管理</a> </span></h3>
            <div class="box">

                <asp:Panel ID="Panel1" runat="server" Height="526px">
                </asp:Panel>

            </div>
        </div>
        <!-- InstanceEndEditable -->
        <div class="listWrapL">
            <h2>
                管理</h2>
            <ul>
                <asp:TreeView ID="TreeView1" runat="server" Height="477px" ImageSet="Arrows">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                    <Nodes>
                        <asp:TreeNode Text="网站信息管理" Value="网站信息管理"></asp:TreeNode>
                        <asp:TreeNode Text="管理员管理" Value="管理员管理"></asp:TreeNode>
                        <asp:TreeNode Text="简介管理" Value="简介管理"></asp:TreeNode>
                        <asp:TreeNode Text="新闻管理" Value="新闻管理">
                            <asp:TreeNode Text="新闻类别管理" Value="新闻类别管理"></asp:TreeNode>
                            <asp:TreeNode Text="新闻内容管理" Value="新闻内容管理"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="公告管理" Value="公告管理">
                            <asp:TreeNode Text="公告类别管理" Value="公告类别管理"></asp:TreeNode>
                            <asp:TreeNode Text="公告内容管理" Value="公告内容管理"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="产品管理" Value="产品管理">
                            <asp:TreeNode Text="产品类别管理" Value="产品类别管理"></asp:TreeNode>
                            <asp:TreeNode Text="产品内容管理" Value="产品内容管理"></asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px"
                        NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px"
                        VerticalPadding="0px" />
                </asp:TreeView>
            </ul>
            <p class="bot">
            </p>
           
     
        </div>
    </div>
    </form>
</body>
<!-- InstanceEnd -->
</html>
