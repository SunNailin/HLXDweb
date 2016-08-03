<%@ Page Title="" Language="C#" MasterPageFile="~/manage.Master" AutoEventWireup="true"
    CodeBehind="webinfo_manage.aspx.cs" Inherits="HLXDweb.webinfo_manage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/xgxt_login.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="592px" HorizontalAlign="Justify">
        <asp:Table ID="Table1" runat="server" CellPadding="3" HorizontalAlign="Center" Width="600px"
            BorderStyle="Solid" BorderWidth="1px" Height="558px">

            <asp:TableRow ID="TableRow1" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell1" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">项目</asp:TableCell>
                <asp:TableCell ID="TableCell2" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">内容</asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow2" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell3" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">信息摘要</asp:TableCell>
                <asp:TableCell ID="TableCell4" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox1" runat="server"  Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow3" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell5" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">Logo</asp:TableCell>
                <asp:TableCell ID="TableCell6" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox2" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow4" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell7" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">地址</asp:TableCell>
                <asp:TableCell ID="TableCell8" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox3" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow5" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell9" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">邮编</asp:TableCell>
                <asp:TableCell ID="TableCell10" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox4" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow6" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell11" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">电话</asp:TableCell>
                <asp:TableCell ID="TableCell12" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox5" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow7" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell13" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">传真</asp:TableCell>
                <asp:TableCell ID="TableCell14" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox6" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow8" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell15" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">邮箱</asp:TableCell>
                <asp:TableCell ID="TableCell16" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox7" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow9" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell17" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">联系人</asp:TableCell>
                <asp:TableCell ID="TableCell18" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox8" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow10" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell19" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">微信二维码</asp:TableCell>
                <asp:TableCell ID="TableCell20" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox9" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow11" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell21" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">大图1</asp:TableCell>
                <asp:TableCell ID="TableCell22" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox10" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow12" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell23" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">大图2</asp:TableCell>
                <asp:TableCell ID="TableCell24" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox11" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow13" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell25" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">大图3</asp:TableCell>
                <asp:TableCell ID="TableCell26" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox12" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow14" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell27" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">大图4</asp:TableCell>
                <asp:TableCell ID="TableCell28" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox13" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow15" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell29" runat="server" Width="101px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">大图5</asp:TableCell>
                <asp:TableCell ID="TableCell30" runat="server" Width="400px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:TextBox ID="TextBox14" runat="server" Width="300px"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow ID="TableRow16" runat="server" BorderColor="Black" BorderStyle="Solid"
                BorderWidth="1px" Font-Size="16pt" Height="30px" HorizontalAlign="center" VerticalAlign="Middle">
                <asp:TableCell ID="TableCell31" runat="server" Width="600px" BorderStyle="Solid" BorderWidth="1px"
                    Font-Size="16pt" Height="30px" HorizontalAlign="Left" VerticalAlign="Middle">
                    <asp:Button ID="Button1" runat="server" Text="Button" /></asp:TableCell>
                
            </asp:TableRow>
        </asp:Table>
    </asp:Panel>
</asp:Content>
