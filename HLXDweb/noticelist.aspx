<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="noticelist.aspx.cs" Inherits="HLXDweb.noticelist" %>

<%@ Register src="Control/headerANDnav.ascx" tagname="headerANDnav" tagprefix="uc1" %>
<%@ Register src="Control/footerANDbotnav.ascx" tagname="footerANDbotnav" tagprefix="uc2" %>

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
    <uc1:headerANDnav ID="headerANDnav1" runat="server" />
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
                    BorderColor="#CCCCCC" Width="733px" AllowPaging="True" PageSize="12" 
                    BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                    ForeColor="Black" GridLines="Horizontal">
                    <Columns>
                        <asp:TemplateField HeaderText="公告类别">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("notice_type_name") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="100px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="公告标题">
                            <ItemTemplate>
                                <a href='notice.aspx?notice_id=<%# Eval("notice_id") %>' target="_parent" title='<%# Eval("notice_title") %>'>
                                    <%# StringTruncate(Eval("notice_title").ToString(), 20, "...")%></a>
                            </ItemTemplate>
                            <ItemStyle Width="400px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="发布时间">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# StringTruncate( Eval("notice_time").ToString(),20,"" )%>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="200px" />
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
                <!--公告列表GridView结束-->
                </form>
                <div class="pageList">
                    
                </div>
            </div>
        </div>
        <!-- InstanceEndEditable -->
    </div>
    </div>
    <uc2:footerANDbotnav ID="footerANDbotnav1" runat="server" />
</body>
<!-- InstanceEnd -->
</html>
