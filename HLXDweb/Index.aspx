<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HLXDweb.Index1" %>

<%@ Register src="Control/footerANDbotnav.ascx" tagname="footerANDbotnav" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>北京市豪联夏都农业科技发展有限公司</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <!--收藏用logo图标-->
    <link rel="bookmark" type="image/x-icon" href="images/logo/16X16.ico" />
    <!--网站显示页logo图标-->
    <link rel="shortcut icon" href="images/logo/16X16.ico" />
    <link rel="icon" href="images/logo/16X16.ico" />
    <style type="text/css">
        h1.title
        {
            font-family: "微软雅黑" ,Verdana;
            font-weight: normal;
        }
        .code
        {
            height: auto;
            padding: 20px;
            border: 1px solid #9EC9FE;
            background: #ECF3FD;
        }
        .code pre
        {
            font-family: "Courier New";
            font-size: 14px;
        }
        .code pre code.note
        {
            color: #999;
        }
        .code2
        {
            border: 1px solid #FEB0B0;
            background: #FFF1F1;
            margin-top: 10px;
        }
        .code2 pre
        {
            margin-left: 20px;
            font-size: 12px;
        }
        .info
        {
            font-size: 12px;
            color: #666666;
            font-family: Verdana;
            margin: 20px 0 50px 0;
        }
        .info p
        {
            margin: 0;
            padding: 0;
            line-height: 22px;
            text-indent: 40px;
        }
        h2.title
        {
            margin: 0;
            padding: 0;
            margin-top: 50px;
            font-size: 18px;
            font-family: "微软雅黑" ,Verdana;
        }
        h2.title span.titleInfo
        {
            font-size: 12px;
            color: #333;
            margin-left: 10px;
            font-family: Verdana;
        }
        h3.title
        {
            font-size: 16px;
            font-family: "微软雅黑" ,Verdana;
        }
        .importInfo
        {
            font-family: Verdana;
            font-size: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
    <div id="header">
        <a href="#">
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
    <!--大图轮换-->
    <div id="KinSlideshow">
        <a href="intro.aspx" target="_parent">
            <img src="/images/banner_bg2.jpg" alt="第四张图片" /></a>
    </div>
    <div id="content">
        <div class="conBot">
            <div class="conBotL">
                <h2>
                    <a href="#">
                        <img src="images/tit_bg_gongsijieshao.jpg" width="185" height="38" alt="关于我们" /></a><span><a
                            href="intro.aspx"><img src="images/more.jpg" width="35" height="20" alt="更多" /></a></span></h2>
                <dl>
                    <dt><a href="#">
                        <img src="images/photo_1.jpg" width="96" height="82" alt="豪联夏都" /></a></dt>
                    <dd>
                        <a href="intro.aspx" title="">&nbsp&nbsp&nbsp&nbsp<%=introcont %></a></dd>
                </dl>
            </div>
            <div class="conBotC">
                <h2>
                    <a href="#">
                        <img src="images/tit_bg5_xinwendongtai.jpg" width="170" height="38" alt="新闻动态" /></a><span><a
                            href="#"><img src="images/more.jpg" width="35" height="20" alt="更多" /></a></span></h2>
                <ul>
                    <li class="noMargin">
                        <asp:GridView ID="gvNewNews" runat="server"  
                            OnRowCreated="gvMain_RowCreated" AutoGenerateColumns="false" Bordercolor="White">
                            <Columns>
                                <asp:TemplateField HeaderText="新闻标题" HeaderStyle-Font-Bold="false" ShowHeader="False">
                                    <ItemTemplate>
                                        <a href='news.aspx?news_id=<%# Eval("news_id") %>' target="_parent" title='<%#Eval("news_title") %>'>
                                            [<%#Eval("news_type_name") %>]
                                            <%# StringTruncate(Eval("news_title").ToString(), 20, "...")%></a>
                                    </ItemTemplate>                                   
                                    <HeaderStyle Font-Bold="False" Height="0px"></HeaderStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="发布时间">
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%#  Eval("news_time")%>'><%#  Eval("news_time")%></asp:Label>
                                    </ItemTemplate>                           
                                    <HeaderStyle BackColor="White" Height="0px" />
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </li>
                </ul>
            </div>
            <div class="conBotR">
                <h2>
                    <a href="#">
                        <img src="images/tit_bg_lianxiwomen.jpg" width="170" height="38" alt="联系我们" /></a></h2>
                <p>
                    地址：<a href="http://j.map.baidu.com/lTSkB" target="_blank"><asp:Label ID="Label1"
                        runat="server" Text="Label"></asp:Label>
                        <br />
                    </a>邮编：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    <br />
                    电话：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    <br />
                    联系人：<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    <br />
                    邮箱：
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </p>
            </div>
        </div>
        <marquee behavior="scroll" contenteditable="true" scrollamount="20" scrolldelay="10" loop="10000"   hspace="10" vspace="10" onmouseover="this.stop()" onmouseout="this.start()">
        <ul class="conTop">
            <li>
                <h2>
                    <a href="#">
                        <img src="images/tit_bg1.jpg" alt="有机蔬菜" /></a></h2>
                <p>
                    等待数据绑定</p>
            </li>
            <li>
                <h2>
                    <a href="#">
                        <img src="images/tit_bg2.jpg" alt="有机蔬菜" /></a></h2>
                <p>
                    等待数据绑定</p>
            </li>
            <li>
                <h2>
                    <a href="#">
                        <img src="images/tit_bg3.jpg" alt="有机蔬菜" /></a></h2>
                <p>
                    等待数据绑定</p>
            </li>
        </ul></marquee>
    </div>
    <uc1:footerANDbotnav ID="footerANDbotnav1" runat="server" />
    </form>
</body>
</html>
