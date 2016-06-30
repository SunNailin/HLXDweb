<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newslist.aspx.cs" Inherits="HLXDweb.newslist" %>

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
            <li><a href="service.aspx">产品展示</a></li>
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
            <h2>
                新闻类别</h2>
            <ul>
                <asp:Repeater ID="repNewsType" runat="server">
                    <ItemTemplate>
                        <li><a href='newslist.aspx?news_type_id=<%# Eval("news_type_id") %>'>
                            <%# Eval("news_type_name") %></a></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
            <p class="bot">
            </p>
            <h2 class="contact">
                联系我们</h2>
            <div class="box">
                地 址：<br />
                邮 编：100000<br />
                热线电话：010-88888888<br />
                传 真：010-88886666<br />
                邮 箱：</div>
            <p class="bot">
            </p>
        </div>
        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <h3>
                新闻动态<span>您现在所在的位置：<a href="index.aspx">首页</a> > 新闻动态</span></h3>
            <div class="box">
                <form runat="server">
                <asp:GridView ID="gvAllNews" runat="server" AutoGenerateColumns="False" BorderColor="White">
                    <Columns>
                        <asp:TemplateField HeaderText="新闻类别" >
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("news_type_name") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("news_type_name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="新闻标题">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("news_title") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("news_title") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="发布时间">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("news_time") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("news_time") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                </form>
                <!--  <dl>
                    <dt><a href="news.aspx">测试新闻等待绑定数据</a></dt>
                    <dd>
                        2016-05-20</dd>
                </dl> -->
                <div class="pageList">
                    [1/1]页 本页[14]条 [ 首页 ] [ 上一页 ] [ <a href="#">下一页</a> ] [ 末页 ]
                </div>
            </div>
        </div>
        <!-- InstanceEndEditable -->
    </div>
    <div id="botNav">
        <a href="#">网站首页</a><span>|</span><a href="#">公司新闻</a><span>|</span><a href="#">行业动态</a><span>|</span><a
            href="#">基地管理</a><span>|</span><a href="#">会员服务</a><span>|</span><a href="#">网上购物</a><span>|</span><a
                href="#">产品展示</a><span>|</span><a href="#">关于我们</a></div>
    <div id="footer">
        <div class="foot">
            电话：010-69111309/69112018/69112016 联系人：龙经理 13801276881<br />
            北京市豪联夏都农业科技发展有限公司 版权所有 京ICP备10043433号
            <img src="images/logo1.jpg" width="108" height="47" />
        </div>
    </div>
</body>
<!-- InstanceEnd -->
</html>
