<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="news.aspx.cs" Inherits="HLXDweb.news" %>

<%@ Register src="Control/NewsType.ascx" tagname="NewsType" tagprefix="uc1" %>

<%@ Register src="Control/headerANDnav.ascx" tagname="headerANDnav" tagprefix="uc3" %>

<%@ Register src="Control/footerANDbotnav.ascx" tagname="footerANDbotnav" tagprefix="uc4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!-- InstanceBeginEditable name="doctitle" -->
    <title>豪联夏都农业生态园</title>
    <!-- InstanceEndEditable -->
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <!-- InstanceBeginEditable name="head" -->
    <!-- InstanceEndEditable -->
</head>
<body>
    <form id="form1" runat="server">
    
    
    <uc3:headerANDnav ID="headerANDnav1" runat="server" />
    
    
    <div id="listWrap">
      

        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <h3>
                公司新闻<span>您现在所在的位置：<a href="#">首页</a> > 公司新闻</span></h3>
            <div class="box">
                <h4>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </h4>
                <p>
                    发布时间：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </p>
            </div>
        </div>
        <!-- InstanceEndEditable -->
        <uc1:NewsType ID="NewsType1" runat="server" />
    </div>
  
    <uc4:footerANDbotnav ID="footerANDbotnav1" runat="server" />
  
    </form>
</body>
<!-- InstanceEnd -->
</html>