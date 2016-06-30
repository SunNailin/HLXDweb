<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="intro.aspx.cs" Inherits="HLXDweb.intro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>豪联夏都农业生态园</title>
    <!-- InstanceEndEditable -->
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <!-- InstanceBeginEditable name="head" -->
    <!-- InstanceEndEditable -->
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
        <a href="#">
            <img src="images/logo5.png" width="480" height="71" alt="豪联夏都" /></a></div>
    <div id="nav">
        <span class="navLeft"></span>
        <ul class="navCenter">
            <li><a href="index.aspx">首页</a></li>
            <li><a href="intro.aspx">公司简介</a></li>
            <li><a href="product.aspx">产品展示</a></li>
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
            <h5>
                简介类别</h5>
            <ul>
                <asp:Repeater ID="repNewsType" runat="server">
                    <ItemTemplate>
                        <li><a href='intro.aspx?intro_id=<%# Eval("intro_id") %>'>
                            <%# Eval("intro_title") %></a></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
            <p class="bot">
            </p>
            <h2 class="contact">
                联系我们</h2>
            <div class="box">
                    地址：<a ><asp:Label ID="Label6"
                        runat="server" Text="Label"></asp:Label>
                        <br />
                    </a>邮编：<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                <br />                    
                    联系人：<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </div>
            <p class="bot">
            </p>
        </div>
        <!-- InstanceBeginEditable name="EditRegion3" -->
        <div class="listWrapR">
            <h3>
                公司新闻<span>您现在所在的位置：<a href="index.aspx">首页</a> > 公司新闻</span></h3>
            <div class="box">
                <h4>
                    园区概况</h4>
                &nbsp;&nbsp;&nbsp; 公司在延庆张山营拥有300多亩有机葡萄生产基地，基地背靠国家自然保护区松山，南邻官厅水库，海拔600多米，优越的土壤、水质，凉爽的气候，众多的专家教授经考察论证张山营在北纬40.2度，东经115.9度，在地球的此赤道是最适合葡萄的种植和生长，基地生产的“京香玉”、“京蜜”、“红提”通过国家有机认证，是北京最大的有机葡萄生产基地之一，
    “京香玉”简介：该品种是中科院植物研究所李少华教授培养出的鲜食早熟品种，果粒成长椭圆形、单果重14克、平均穗重1200克，最大可达2600克，果皮金黄色，果肉脆，籽少，味甜，具有北京传统品种玫瑰香的味道，但无论单果重还是肉质均优于玫瑰香，目前只有我公司大量种植，
    红提品种简介：晚熟品种，植株生长旺盛，极丰产。极耐贮运。果粒大，圆形，最大粒重22克，平均粒重13～14克。果穗特大，果粒着&nbsp; 生中等式紧密，圆锥形，最大穗重达2500克，平均穗重800～1200克。果肉脆硬，能切成薄片。味甜，含可溶性固形物17%～19%。品质极上。
    目前正是红提的采摘季节，在国庆和中秋节前后大量成熟供应北京市民，张山营有机葡萄基地欢迎您前来观光采摘并提供团体采购预定，送货上门等服务，自驾车线路，京藏高速康庄出口、（康张路），张山营方向官厅大桥北即到，咨询电话69112016，69195316<br />
                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
        <!-- InstanceEndEditable -->
    </div>
    <div id="botNav">
        <a href="index.aspx">网站首页</a><span>|</span><a href="newslist.aspx">公司新闻</a><span>|</span><a href="noticelist.aspx">活动公告</a><span>|</span><a
            href="admin.aspx">基地管理</a><span>|</span><a href="vip.aspx">会员服务</a><span>|</span><a href="caizhai.aspx">住宿采摘</a><span>|</span><a
                href="product.aspx">产品展示</a><span>|</span><a href="intro.aspx">公司简介</a></div>
    <div id="footer">
        <div class="foot">
            电话：<asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
&nbsp;联系人：龙经理 
            <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
            <br />
            北京市豪联夏都农业科技发展有限公司 版权所有 京ICP备10043433号
            <img src="images/logo1.jpg" width="108" height="47" />
        </div>
    </div>
    </form>
</body>
<!-- InstanceEnd -->
</html>
