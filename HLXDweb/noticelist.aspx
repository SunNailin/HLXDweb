﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="noticelist.aspx.cs" Inherits="HLXDweb.noticelist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>活动·公告—豪联夏都农业生态园</title>
    <!-- InstanceEndEditable -->
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <!-- InstanceBeginEditable name="head" -->
    <!-- InstanceEndEditable -->
</head>
<body>
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

    <div class="listWrapL">
            <h6>
                公告类别</h6>
            <ul>
                <asp:Repeater ID="repNoticeType" runat="server">
                    <ItemTemplate>
                        <li><a href='noticelist.aspx?notice_type_id=<%# Eval("notice_type_id") %>'>
                            <%# Eval("notice_type_name") %></a></li>
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
        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <h3>
                活动公告<span>您现在所在的位置：<a href="index.aspx">首页</a> > 活动公告</span></h3>
            <div class="box">
                <form id="Form1" runat="server">
                <!--活动列表GridView-->
                <asp:GridView ID="gvAllNotice" runat="server" AutoGenerateColumns="False" 
                    BorderColor="White" Width="697px">
                    <Columns>
                        <asp:TemplateField HeaderText="公告类别">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("notice_type_name") %>'></asp:Label>
                            </ItemTemplate>
                            <ControlStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="公告标题">
                            <ItemTemplate>
                                <a href='notice.aspx?notice_id=<%# Eval("notice_id") %>' target="_parent"  title='<%# Eval("notice_title") %>'><%# StringTruncate(Eval("notice_title").ToString(), 10, "...")%></a>
                            </ItemTemplate>
                            <ControlStyle Width="400px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="发布时间">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# StringTruncate( Eval("notice_time").ToString(),10,"" )%>'></asp:Label>
                            </ItemTemplate>
                            <ControlStyle Width="120px" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <!--公告列表GridView结束-->
                </form>
                <div class="pageList">
                    [1/1]页 本页[14]条 [ 首页 ] [ 上一页 ] [ <a href="#">下一页</a> ] [ 末页 ]
                </div>
            </div>
        </div>
        <!-- InstanceEndEditable -->
        
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
</body>
<!-- InstanceEnd -->
</html>
