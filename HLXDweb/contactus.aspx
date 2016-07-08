<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contactus.aspx.cs" Inherits="HLXDweb.ContactUs" %>

<%@ Register Src="Control/headerANDnav.ascx" TagName="headerANDnav" TagPrefix="uc1" %>
<%@ Register Src="Control/footerANDbotnav.ascx" TagName="footerANDbotnav" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>联系我们-豪联夏都</title>
    <style type="text/css">
        html
        {
            height: 100%;
        }
        body
        {
            height: 100%;
            margin: 100px;
            padding: 0px;
        }
        #container
        {
            height: 600px;
            width:981px;
        }
    </style>
    <script type="text/javascript" src="http://api.map.baidu.com/api?v=2.0&ak=eKICFDnhxT1dFF3u2Lf8oPytU8z9OsWk"></script>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <uc1:headerANDnav ID="headerANDnav1" runat="server" />
    
    <div id="listWrap">
    <div class="listWrapL">
    <h2 class="contact">
    <img src="images/tit_bg9.jpg" alt="联系我们"/></h2>
    微信公众号：haolianxiadu<br/>
    <img src="" alt="豪联夏都" height="200px" width="200px"/><br/><br/>
    地&nbsp&nbsp址：<asp:Label ID="lbl_address" runat="server" Text="Label"></asp:Label><br/><br/>
    邮&nbsp&nbsp编：<asp:Label ID="lbl_postcode" runat="server" Text="Label"></asp:Label><br/><br/>
    电&nbsp&nbsp话：<asp:Label ID="lbl_phone" runat="server" Text="Label"></asp:Label><br/><br/>
    联系人：<asp:Label ID="lbl_contactor" runat="server" Text="Label"></asp:Label><br/><br/>
    邮&nbsp&nbsp箱：<asp:Label ID="lbl_email" runat="server" Text="Label"></asp:Label><br/><br/>

    
    </div>
        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <div class="box">
            <a href="http://j.map.baidu.com/lTSkB" target="_blank"><img src="images/map4.jpg" width="700px" height="600px"></a>
            </div>
        </div>
        <!-- InstanceEndEditable -->
    </div>
    <uc2:footerANDbotnav ID="footerANDbotnav1" runat="server" />
    </form>
</body>
</html>
