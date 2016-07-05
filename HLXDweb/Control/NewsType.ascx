<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsType.ascx.cs" Inherits="HLXDweb.Control.NewsType" %>

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