<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="caizhai.aspx.cs" Inherits="HLXDweb.caizhai" %>

<%@ Register src="Control/headerANDnav.ascx" tagname="headerANDnav" tagprefix="uc1" %>
<%@ Register src="Control/footerANDbotnav.ascx" tagname="footerANDbotnav" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>采摘乐园-豪联夏都</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

    <uc1:headerANDnav ID="headerANDnav1" runat="server" />

    <div id="listWrap">
        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <h3>
                采摘乐园<span>您现在所在的位置：<a href="#">首页</a> > 采摘乐园</span></h3>
            <div class="box">
                <table width="100%" border="2px" cellpadding="2" cellspacing="1" bordercolor="Green">
                    <tbody>
                        <tr>
                            <td align="center" style="word-spacing">
                                <b><a href="caizhaidetail.aspx?czid=1">瓜廊</a> </b>
                            </td>
                            <td align="center">
                                <a href="caizhaidetail.aspx?czid=1">
                                    <img src="uploadimages/caizhai/瓜廊秋之景jpg.jpg" alt="瓜廊" width="200px" height="150px" />
                                </a>
                            </td>
                            <td align="center">
                                <a href="caizhaidetail.aspx?czid=1">园区于2011年年底新建成一条长达268米的瓜廊。一共有18个品种，各种瓜千奇百秀，琳琅满目，采摘游客可以免费参观，一定让您大饱眼福！
                                </a>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="word-spacing">
                                <b><a href="caizhaidetail.aspx?czid=2">果园一隅</a> </b>
                            </td>
                            <td align="center">
                                <a href="caizhaidetail.aspx?czid=2">
                                    <img src="uploadimages/caizhai/果园一隅jpg.jpg" alt="果园一隅" width="200px" height="150px" />
                                </a>
                            </td>
                            <td align="center">
                                <a href="caizhaidetail.aspx?czid=2">最美的地方在细节
                                </a>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="word-spacing">
                                <b><a href="caizhaidetail.aspx?czid=3">采摘入口</a> </b>
                            </td>
                            <td align="center">
                                <a href="caizhaidetail.aspx?czid=3">
                                    <img src="uploadimages/caizhai/采摘入口.jpg"alt="采摘入口" width="200px" height="150px" />
                                </a>
                            </td>
                            <td align="center">
                                <a href="caizhaidetail.aspx?czid=3">

                                </a>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <!-- InstanceEndEditable -->
        <div class="listWrapL">
            <h6>
                采摘乐园</h6>
            <ul>
                <asp:Repeater ID="repProductType" runat="server">
                    <ItemTemplate>
                        <li><a href='productlist.aspx?product_type_id=<%# Eval("product_type_id") %>'>
                            <%# Eval("product_type_name") %></a></li>
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
    </div>
    <uc2:footerANDbotnav ID="footerANDbotnav1" runat="server" />
    </form>
</body>
</html>
