<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newslist.aspx.cs" Inherits="HLXDweb.newslist" %>

<%@ Register src="Control/NewsType.ascx" tagname="NewsType" tagprefix="uc1" %>


<%@ Register src="Control/footerANDbotnav.ascx" tagname="footerANDbotnav" tagprefix="uc2" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!-- InstanceBeginEditable name="doctitle" -->
    <title>新闻动态—豪联夏都农业生态园</title>
    <!-- InstanceEndEditable -->
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <!-- InstanceBeginEditable name="head" -->
    <!-- InstanceEndEditable -->
</head>
<body>
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
    <div id="listWrap">

    <!--新闻分类以及联系方式-->
        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <h3>
                新闻动态<span>您现在所在的位置：<a href="index.aspx">首页</a> > 新闻动态</span></h3>
            <div class="box">
                <form runat="server">
                <!--新闻列表GridView-->
                <asp:GridView ID="gvAllNews" runat="server" AutoGenerateColumns="False" 
                    BorderColor="White" Width="700px" AllowPaging="true" PageSize="15">
                    <Columns>
                        <asp:TemplateField HeaderText="新闻类别">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("news_type_name") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="True" Font-Size="15px" />
                            <ItemStyle BackColor="White" Font-Size="15px" Height="30px" Width="150px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="新闻标题">
                            <ItemTemplate>
                                <a href='news.aspx?news_id=<%# Eval("news_id") %>' target="_parent"  title='<%# Eval("news_title") %>'><%# StringTruncate(Eval("news_title").ToString(), 25, "...")%></a>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="True" Font-Size="15px" />
                            <ItemStyle Font-Size="15px" Width="400px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="发布时间">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%#Eval("news_time").ToString()%>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="True" Font-Size="15px" />
                            <ItemStyle Font-Size="15px" Width="150px" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <!--新闻列表GridView结束-->
                </form>
                <div class="pageList">                  
                </div>
            </div>
        </div>
        <!-- InstanceEndEditable -->
        <uc1:NewsType ID="NewsType1" runat="server" />
    </div>
             
    </div>
    <uc2:footerANDbotnav ID="footerANDbotnav1" runat="server" />
</body>
<!-- InstanceEnd -->
</html>
