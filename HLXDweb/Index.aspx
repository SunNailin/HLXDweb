<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HLXDweb.Index1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>北京市豪联夏都农业科技发展有限公司</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <!--收藏用logo图标-->
    <link rel="bookmark" type="image/x-icon" href="images/logo/16X16.ico" />
    <!--网站显示页logo图标-->
    <link rel="shortcut icon" href="images/logo/16X16.ico"/>
    <link rel="icon" href="images/logo/16X16.ico"/>
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
    <div id="banner">
        <img src="images/banner_bg2.jpg" width="980" height="382" alt="豪联夏都生态园"/></div>
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
                        <a href="intro.aspx">详细内容>></a></dd>
                </dl>
            </div>
            <div class="conBotC">
                <h2>
                    <a href="#">
                        <img src="images/tit_bg5_xinwendongtai.jpg" width="170" height="38" alt="新闻动态" /></a><span><a
                            href="#"><img src="images/more.jpg" width="35" height="20" alt="更多" /></a></span></h2>
                <ul>
                    <li>
                        <p class="one">
                            <a href="#">
                                <img src="images/photo_2.jpg" width="114" height="88" /></a></p>
                        <p class="two">
                            <a href="#">等待数据绑定</a></p>
                    </li>
                    <li>
                        <p class="one">
                            <a href="#">
                                <img src="images/photo_3.jpg" width="114" height="88" /></a></p>
                        <p class="two">
                            <a href="#">等待数据绑定</a></p>
                    </li>
                    <li class="noMargin">
                        <p class="one">
                            <a href="#">
                                <img src="images/photo_4.jpg" width="114" height="88" /></a></p>
                        <p class="two">
                            <a href="#">等待数据绑定</a></p>
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
        <ul class="conTop">
            <li>
                <h2>
                    <a href="#">
                        <img src="images/tit_bg1.jpg" alt="有机蔬菜" /></a></h2>
                <p>
                    主要通过自然降水、施用农家肥人工除草等传统的农...</p>
            </li>
            <li>
                <h2>
                    <a href="#">
                        <img src="images/tit_bg2.jpg" alt="有机蔬菜" /></a></h2>
                <p>
                    含有丰富的碳水化合物、维生素和微量元素，尤其是...</p>
            </li>
            <li>
                <h2>
                    <a href="#">
                        <img src="images/tit_bg3.jpg" alt="有机蔬菜" /></a></h2>
                <p>
                    含有丰富的碳水化合物、维生素和微量元素，尤其是...</p>
            </li>
            <li>
                <h2>
                    <a href="#">
                        <img src="images/tit_bg4.jpg" alt="有机蔬菜" /></a></h2>
                <p>
                    在饲养过程中不添加任何化学合成的添加剂、抗生素...</p>
            </li>
        </ul>
    </div>
    <div id="botNav">
        <a href="index.aspx">网站首页</a><span>|</span><a href="newslist.aspx">公司新闻</a><span>|</span><a href="noticelist.aspx">活动公告</a><span>|</span><a
            href="admin.aspx">基地管理</a><span>|</span><a href="vip.aspx">会员服务</a><span>|</span><a href="caizhai.aspx">住宿采摘</a><span>|</span><a
                href="product.aspx">产品展示</a><span>|</span><a href="intro.aspx">公司简介</a></div>
    <div id="footer">
        <div class="foot">
            电话：<asp:Label 
                ID="Label6" runat="server" Text="Label"></asp:Label>
&nbsp;联系人：<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
            <br />
            北京市豪联夏都农业科技发展有限公司 版权所有 京ICP备10043433号
            <img src="images/logo1.jpg" width="108" height="47" />
        </div>
    </div>
    </form>
</body>
</html>
