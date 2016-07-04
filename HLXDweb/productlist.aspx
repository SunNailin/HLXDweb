<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productlist.aspx.cs" Inherits="HLXDweb.product" %>

<%@ Register src="Control/headerANDnav.ascx" tagname="headerANDnav" tagprefix="uc1" %>


<%@ Register src="Control/footerANDbotnav.ascx" tagname="footerANDbotnav" tagprefix="uc2" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>产品展示—豪联夏都农业生态园</title>
    <!-- InstanceEndEditable -->
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <!-- InstanceBeginEditable name="head" -->
    <!-- InstanceEndEditable -->
</head>
<body>
    <form id="form1" runat="server">
    
    <uc1:headerANDnav ID="headerANDnav1" runat="server" />
    
    <div id="listWrap">
        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <h3>
                产品展示<span>您现在所在的位置：<a href="#">首页</a> > 产品展示</span></h3>
            <div class="box">
            </div>
        </div>
        <!-- InstanceEndEditable -->
        <div class="listWrapL">
            <h6>
                产品类别</h6>
            <ul>
                <asp:Repeater ID="repProductType" runat="server">
                    <ItemTemplate>
                        <li><a href='productlist.aspx?product_type_id=<%# Eval("product_type_id") %>'>
                            <%# Eval("product_type_name") %></a></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
            <p class="bot">
            </p>
            <h2 class="contact">
                联系我们</h2>
            <div class="box">
                地址：<a><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                    <br />
                </a>邮编：<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                <br />
                联系人：<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                <br />
            </div>
            <p class="bot">
            </p>
        </div>
    </div>
   
    
    <uc2:footerANDbotnav ID="footerANDbotnav1" runat="server" />
   
    
    </form>
</body>
<!-- InstanceEnd -->
</html>
