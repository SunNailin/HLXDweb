<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productlist.aspx.cs" Inherits="HLXDweb.product" %>

<%@ Register Src="Control/headerANDnav.ascx" TagName="headerANDnav" TagPrefix="uc1" %>
<%@ Register Src="Control/footerANDbotnav.ascx" TagName="footerANDbotnav" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>产品展示—豪联夏都农业生态园</title>
    <!-- InstanceEndEditable -->
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <!-- InstanceBeginEditable name="head" -->
    <!-- InstanceEndEditable -->
</head>
<body>
    <form id="form1" runat="server">
    <uc1:headerANDnav ID="headerANDnav1" runat="server" />
    <div id="listWrap">
        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <h3>
                产品展示<span>您现在所在的位置：<a href="#">首页</a> > 产品展示</span></h3>
            <div class="box">
                <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False">
                     <Columns>
                        <asp:TemplateField HeaderText="名称">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("product_name") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="True" Font-Size="15px" />
                            <ItemStyle BackColor="White" Font-Size="15px" Height="30px" Width="50px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="图片展示">
                            <ItemTemplate>
                            <img src='<%# Eval("product_picture1") %>' height="200px" width="200px" />
                                <a href='news.aspx?news_id=<%# Eval("product_id") %>' target="_parent"  title='<%# Eval("product_id") %>'></a>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="True" Font-Size="15px" />
                            <ItemStyle Font-Size="15px" Width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="品种简介">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("product_content") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="True" Font-Size="15px" />
                            <ItemStyle Font-Size="15px" Width="480px" />
                        </asp:TemplateField>
                    </Columns>
                    <headerstyle backcolor="Green" font-bold="True" forecolor="White" />
                </asp:GridView>
                
                <%--<table width="100%" border="2px" cellpadding="2" cellspacing="1" bordercolor="Green">
                    <tbody>
                        <tr>
                            <td align="center" style="word-spacing">
                                <b><a href="product.aspx?prdtid=1">红提</a> </b>
                            </td>
                            <td align="center">
                                <a href="product.aspx?prdtid=1">
                                    <img src="uploadimages/product/2011916151994083_红提.jpg" alt="红提" width="200px" height="200px" />
                                </a>
                            </td>
                            <td align="center">
                                <a href="product.aspx?prdtid=1">品种简介：主要特性：晚熟品种。植株生长旺盛，极丰产。极耐贮运。果粒大，圆形，最大粒重22克，平均粒重13～14克。果穗特大，果粒着生中等式紧密，圆锥形，最大穗重达2500克，平均穗重800～1200克。果肉脆硬，能切成薄片。味甜，含可溶性固形物17%～19%。品质极上。
                                </a>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="word-spacing">
                                <b><a href="product.aspx?prdtid=2">京香玉</a> </b>
                            </td>
                            <td align="center">
                                <a href="product.aspx?prdtid=2">
                                    <img src="uploadimages/product/201191614571795741_京香玉.jpg" alt="京香玉" width="200px" height="200px" />
                                </a>
                            </td>
                            <td align="center">
                                <a href="product.aspx?prdtid=2">品种简介：该品种是中科院植物研究所李少华教授选新育出的鲜食早熟品种。树体生长势强，产量极高。果穗大，长圆锥形，平均穗重1200g，最大的可达2500g。果实长椭圆形，平均单果重14g。果皮金黄色，果肉脆，籽少，味甜，品质极优。果实具有独特的玫瑰香。
                                </a>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="word-spacing">
                                <b><a href="product.aspx?prdtid=3">京蜜（97优1）</a> </b>
                            </td>
                            <td align="center">
                                <a href="product.aspx?prdtid=3">
                                    <img src="uploadimages/product/200991414164764067_京蜜.jpg" alt="京蜜（97优1）" width="200px" height="200px" />
                                </a>
                            </td>
                            <td align="center">
                                <a href="product.aspx?prdtid=3">品种简介：  该品种是中科院植物研究所李少华教授选新育出的鲜食早熟品种。树体生长势中等，且早熟。果穗长，平均穗长30cm，穗重1000g。果粒扁圆形，果点微凹陷，柿子状，平均单果重10g。果皮淡绿色至黄色，果肉极脆，特甜，糖度可达20度以上，品质特优。果实清香，极耐储藏运输。

                                </a>
                            </td>
                        </tr>
                    </tbody>
                </table>--%>
            </div>
        </div>
        <!-- InstanceEndEditable -->
        <div class="listWrapL">
            <h6>
                产品类别</h6>
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
<!-- InstanceEnd -->
</html>
