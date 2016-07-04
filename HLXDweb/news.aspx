<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="news.aspx.cs" Inherits="HLXDweb.news" %>

<%@ Register src="Control/NewsType.ascx" tagname="NewsType" tagprefix="uc1" %>

<%@ Register src="Control/Footer.ascx" tagname="Footer" tagprefix="uc2" %>

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
    <div id="header">
        <a href="index.aspx">
           <img src="images/logo5.png" width="480" height="71" alt="豪联夏都" /></a></div>
    <div id="nav">
        <span class="navLeft"></span>
        <ul class="navCenter">
            <li><a href="index.aspx">首页</a></li>
            <li><a href="intro.aspx">公司简介</a></li>
            <li><a href="product.aspx">产品展示</a></li>
            <li><a href="newslist.aspx">新闻动态</a></li>
            <li><a href="noticelist.aspx">活动公告</a></li>
            <li><a href="museum.aspx">葡萄酒博物馆</a></li>
            <li><a href="caizhai.aspx">采摘住宿</a></li>
            <li><a href="vip.aspx">会员服务</a></li>
            <li><a href="contactus.aspx">联系我们</a></li>
        </ul>
        <span class="navRight"></span>
    </div>
    
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
  <div id="botNav">
        <a href="index.aspx">网站首页</a><span>|</span><a href="newslist.aspx">公司新闻</a><span>|</span><a
            href="noticelist.aspx">活动公告</a><span>|</span><a href="admin.aspx">基地管理</a><span>|</span><a
                href="vip.aspx">会员服务</a><span>|</span><a href="caizhai.aspx">住宿采摘</a><span>|</span><a
                    href="product.aspx">产品展示</a><span>|</span><a href="intro.aspx">公司简介</a></div>
<div id="footer">
        <div class="foot">
            电话：<asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            &nbsp;联系人：<asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            <br />
            北京市豪联夏都农业科技发展有限公司 版权所有 京ICP备10043433号
            <img src="images/logo1.jpg" width="108" height="47" alt="绿色食品" />
        </div>
    </div>
    </form>
</body>
<!-- InstanceEnd -->
</html>