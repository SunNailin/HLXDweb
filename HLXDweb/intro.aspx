<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="intro.aspx.cs" Inherits="HLXDweb.intro" %>

<%@ Register src="Control/headerANDnav.ascx" tagname="headerANDnav" tagprefix="uc1" %>

<%@ Register src="Control/footerANDbotnav.ascx" tagname="footerANDbotnav" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>公司简介—豪联夏都农业生态园</title>
    <!-- InstanceEndEditable -->
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <!-- InstanceBeginEditable name="head" -->
    <!-- InstanceEndEditable -->
</head>
<body>
    <form id="form1" runat="server">
    
    <uc1:headerANDnav ID="headerANDnav1" runat="server" />
    
    <div id="listWrap">
        <div class="listWrapL">
            <h5>
                简介类别</h5>
            <ul>
                <asp:Repeater ID="repNewsType" runat="server">
                    <ItemTemplate>
                        <li><a href='intro.aspx?intro_id=<%# Eval("intro_id") %>'>
                            <%# Eval("intro_title") %></a></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
            <p class="bot">
            </p>
            <h2 class="contact">
                联系我们</h2>
            <div class="box">
                    地址：<a ><asp:Label ID="Label6"
                        runat="server" Text="Label"></asp:Label>
                        <br />
                    </a>邮编：<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                <br />                    
                    联系人：<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </div>
            <p class="bot">
            </p>
        </div>
        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <h3>
                 豪联夏都简介<span>您现在所在的位置：<a href="index.aspx">首页</a> > 公司简介</span></h3>
            <div class="box">
                <h4>
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                </h4>
                <br />
                &nbsp;&nbsp;&nbsp; <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
        <!-- InstanceEndEditable -->
    </div>

    <uc2:footerANDbotnav ID="footerANDbotnav1" runat="server" />

    </form>
</body>
<!-- InstanceEnd -->
</html>
