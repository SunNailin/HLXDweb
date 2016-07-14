<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newstype_manage_foruse.aspx.cs" Inherits="HLXDweb.manage" %>

<%@ Register Src="Control/headerANDnav.ascx" TagName="headerANDnav" TagPrefix="uc1" %>
<%@ Register src="Control/footerANDbotnav.ascx" tagname="footerANDbotnav" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>网站信息管理—豪联夏都</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-3.0.0.js" type="text/javascript"></script>
    <script src="js/editTable.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <uc1:headerANDnav ID="headerANDnav1" runat="server" />
    <div id="listWrap">
        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <h3>
                网站信息管理<span>您现在所在的位置：<a href="manage.aspx">网站管理</a> </span>
            </h3>
            <div class="box">

                <asp:Panel ID="Panel1" runat="server" Height="526px" HorizontalAlign="Justify">
                 *操作时请勿编辑类别序号，否则将会出错！
                    <asp:GridView ID="gvNTP" runat="server" AutoGenerateColumns="False" CellPadding="4"
                        ForeColor="#333333" GridLines="None"  OnRowEditing="gvNTP_RowEditing" 
                        OnRowCancelingEdit="gvNTP_RowCancelingEdit" DataKeyNames="news_type_id"  OnRowUpdating="gvNTP_RowUpdating">
                        <AlternatingRowStyle BackColor="White" />                       
                        <Columns>
                            <asp:BoundField DataField="news_type_id" HeaderText="类别序号" />
                            <asp:BoundField DataField="news_type_name" HeaderText="类别名称" />
                            <asp:BoundField DataFormatString="news_type_intro" HeaderText="类别简介" />
                            <asp:CommandField HeaderText="操作" ShowEditButton="True" />
                            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                    <asp:MultiView ID="MultiView1" runat="server">
                    </asp:MultiView>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="新增类别"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="类别名称"></asp:Label>
                    ：<asp:TextBox ID="txtNTPName" runat="server" ValidationGroup="addNTP"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入类别名称" Text="*" ControlToValidate="txtNTPName" ValidationGroup="addNTP"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="类别简介"></asp:Label>
                    ：<asp:TextBox ID="txtNTPIntro" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="提交" ValidationGroup="addNTP" 
                        onclick="Button1_Click"/>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="addNTP" ShowMessageBox="true" ShowSummary="false"/>
                </asp:Panel>
            </div>
        </div>
        <!-- InstanceEndEditable -->
       
    </div>
    <uc2:footerANDbotnav ID="footerANDbotnav1" runat="server" />
    </form>
</body>
<!-- InstanceEnd -->
</html>
