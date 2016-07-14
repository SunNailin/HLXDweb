<%@ Page Title="" Language="C#" MasterPageFile="~/manage.Master" AutoEventWireup="true"
    CodeBehind="newstype_manage.aspx.cs" Inherits="HLXDweb.newstype_manager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/xgxt_login.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="526px" HorizontalAlign="Justify">
        *操作时请勿编辑类别序号，否则将会出错！
        <asp:GridView ID="gvNTP" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None" OnRowEditing="gvNTP_RowEditing" OnRowCancelingEdit="gvNTP_RowCancelingEdit"
            DataKeyNames="news_type_id" OnRowUpdating="gvNTP_RowUpdating">
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
        <br />
        <asp:Label ID="Label4" runat="server" Text="新增类别"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="类别名称"></asp:Label>
        ：<asp:TextBox ID="txtNTPName" runat="server" ValidationGroup="addNTP"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入类别名称"
            Text="*" ControlToValidate="txtNTPName" ValidationGroup="addNTP"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="类别简介"></asp:Label>
        ：<asp:TextBox ID="txtNTPIntro" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="提交" ValidationGroup="addNTP" OnClick="Button1_Click" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="addNTP"
            ShowMessageBox="true" ShowSummary="false" />
    </asp:Panel>
</asp:Content>
