<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="HLXDweb.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="css/xgxt_login.css" />
    <title>管理员登录-豪联夏都有机葡萄庄园</title>
</head>
<body>
<form id="loginform" runat="server">
    <div id="header">
        <div class="header_title">
            <span class="title_con">管理员登录-豪联夏都有机葡萄庄园</span>&nbsp;&nbsp;&nbsp;&nbsp;<a id="returnIndex" href="Index.aspx">点此返回网站首页</a>
        </div>
    </div>
    <div id="content">
        <center>
            <div class="con">
                <div class="con_title">
                    <span class="con_title_sp">欢迎登录豪联夏都门户管理系统</span>
                </div>
                <div class="con_panel">
                    <div class="con_input">
                        <span>用户名：</span>
                        <asp:TextBox ID="txtName" runat="server" placeholder="用户名" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入用户名！" Text="*" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                    </div>
                    <div class="con_input">
                        <span>密&nbsp;&nbsp;&nbsp;&nbsp;码：</span>
                        <asp:TextBox ID="txtPassword" runat="server" placeholder="密码" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入密码!" Text="*" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                    
                    </div>
                    <div class="con_select">
                    <asp:Button ID="btnLogin" runat="server" Text="登录" onclick="btnLogin_Click" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server"  ShowMessageBox="true" ShowSummary="false"/>
                </div>
            </div>
        
                    </center>
    </div>
    <div style="text-align: center;">
        <p>
            <a href="" target="_blank"></a>
        </p>
    </div>
    </form>
</body>
</html>
