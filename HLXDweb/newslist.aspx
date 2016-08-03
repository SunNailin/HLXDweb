<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newslist.aspx.cs" Inherits="HLXDweb.newslist" %>

<%@ Register Src="Control/NewsType.ascx" TagName="NewsType" TagPrefix="uc1" %>
<%@ Register Src="Control/footerANDbotnav.ascx" TagName="footerANDbotnav" TagPrefix="uc2" %>
<%@ Register Src="Control/headerANDnav.ascx" TagName="headerANDnav" TagPrefix="uc3" %>
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
    <uc3:headerANDnav ID="headerANDnav1" runat="server" />
    <div id="listWrap">
        <!--新闻分类以及联系方式-->
        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <h3>
                新闻动态<span>您现在所在的位置：<a href="index.aspx">首页</a> > 新闻动态</span></h3>
            <div class="box">
                <form runat="server">
                <!--新闻列表GridView-->
                <asp:GridView ID="gvAllNews" runat="server" AutoGenerateColumns="False" BorderColor="#CCCCCC"
                    Width="733px" AllowPaging="True" PageSize="20" BackColor="White" BorderStyle="None"
                    BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                    <Columns>
                        <asp:TemplateField HeaderText="新闻类别">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("news_type_name") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="True" Font-Size="15px" />
                            <ItemStyle BackColor="White" Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="新闻标题">
                            <ItemTemplate>
                                <a href='news.aspx?news_id=<%# Eval("news_id") %>' target="_parent" title='<%# Eval("news_title") %>'>
                                    <%# StringTruncate(Eval("news_title").ToString(), 25, "...")%></a>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="True" Font-Size="15px" />
                            <ItemStyle Width="400px" Font-Size="15px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="发布时间">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%#Eval("news_time").ToString()%>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="True" Font-Size="15px" />
                            <ItemStyle Width="200px" HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="Green" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                </asp:GridView>
                <!--新闻列表GridView结束-->
                <div class="pageList">
                    jlaskfjalksjflakjsflkjaljflakjsflkaj
                </div>
                </form>
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
