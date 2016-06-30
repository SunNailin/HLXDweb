<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="news.aspx.cs" Inherits="HLXDweb.news" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!-- InstanceBeginEditable name="doctitle" -->
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
            <li><a href="service.aspx">采摘住宿</a></li>
            <li><a href="vip.aspx">会员服务</a></li>
            <li><a href="contactus.aspx">联系我们</a></li>
        </ul>
        <span class="navRight"></span>
    </div>
    
    <div id="listWrap">
        <div class="listWrapL">
            <h2>
                新闻类别</h2>
                <asp:Repeater ID="repNewsType" runat="server">
                    <ItemTemplate>
                        <li><a href='newslist.aspx?news_type_id=<%# Eval("news_type_id") %>'>
                            <%# Eval("news_type_name") %></a></li>
                    </ItemTemplate>
                </asp:Repeater>
            </p>
            <h2 class="contact">
                联系我们</h2>
            <div class="box">
                地址：<a><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
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
                公司新闻<span>您现在所在的位置：<a href="#">首页</a> > 公司新闻</span></h3>
            <div class="box">
                <h4>
                    人人都要维护食品安全</h4>
                <p>
                    来源： 法制办主站 发布时间： 2012-07-12 08:57</p>
                <p>
                    食品安全，关系到人民群众的切身利益，全社会高度关注。国务院就食品安全专门召开全国电视电话会议，对严厉打击食品非法添加行为、切实加强食品添加剂监管提出明确要求。这抓住了近段时期食品安全工作的"牛鼻子"。</p>
                <p>
                    我国是食品生产和消费大国。13亿多人每天吃掉200万吨食物。让人民群众吃得放心，关键在于食品质量安全长期稳定可靠。近年来，我国食品安全形势总体稳定向好，绝大多数食品的质量安全是有保证的。2009年起，国务院部署开展全国食品安全整顿工作，在各地区、各部门努力下，集中治理、执法检查、日常监管等明显加强。一些威胁人民群众身体健康的食品安全隐患得以消除，整顿工作取得阶段性成果。</p>
                <p>
                    但是，应当清醒地看到，我国食品安全基础薄弱，受产业发展水平、企业管理水平、消费结构水平、诚信道德水平等因素制约，当前的食品安全状况不容乐观，一些违法违规顽疾仍未根治，新的问题时有发生，屡禁不止，特别是以食品非法添加为代表的食品安全问题比较集中地暴露出来，人民群众反映强烈。食品安全体制机制、法规制度、技术能力等方面也存在许多薄弱环节，一定程度上引起人们对食品安全的担忧，影响着公众对食品消费的信心。</p>
                <p>
                    食品安全，关系到人民群众的切身利益，全社会高度关注。国务院就食品安全专门召开全国电视电话会议，对严厉打击食品非法添加行为、切实加强食品添加剂监管提出明确要求。这抓住了近段时期食品安全工作的"牛鼻子"。</p>
                <p>
                    我国是食品生产和消费大国。13亿多人每天吃掉200万吨食物。让人民群众吃得放心，关键在于食品质量安全长期稳定可靠。近年来，我国食品安全形势总体稳定向好，绝大多数食品的质量安全是有保证的。2009年起，国务院部署开展全国食品安全整顿工作，在各地区、各部门努力下，集中治理、执法检查、日常监管等明显加强。一些威胁人民群众身体健康的食品安全隐患得以消除，整顿工作取得阶段性成果。</p>
                <p>
                    但是，应当清醒地看到，我国食品安全基础薄弱，受产业发展水平、企业管理水平、消费结构水平、诚信道德水平等因素制约，当前的食品安全状况不容乐观，一些违法违规顽疾仍未根治，新的问题时有发生，屡禁不止，特别是以食品非法添加为代表的食品安全问题比较集中地暴露出来，人民群众反映强烈。食品安全体制机制、法规制度、技术能力等方面也存在许多薄弱环节，一定程度上引起人们对食品安全的担忧，影响着公众对食品消费的信心。</p>
                <p>
                    食品安全，关系到人民群众的切身利益，全社会高度关注。国务院就食品安全专门召开全国电视电话会议，对严厉打击食品非法添加行为、切实加强食品添加剂监管提出明确要求。这抓住了近段时期食品安全工作的"牛鼻子"。</p>
                <p>
                    我国是食品生产和消费大国。13亿多人每天吃掉200万吨食物。让人民群众吃得放心，关键在于食品质量安全长期稳定可靠。近年来，我国食品安全形势总体稳定向好，绝大多数食品的质量安全是有保证的。2009年起，国务院部署开展全国食品安全整顿工作，在各地区、各部门努力下，集中治理、执法检查、日常监管等明显加强。一些威胁人民群众身体健康的食品安全隐患得以消除，整顿工作取得阶段性成果。</p>
            </div>
        </div>
        <!-- InstanceEndEditable -->
    </div>
  <div id="botNav">
        <a href="index.aspx">网站首页</a><span>|</span><a href="newslist.aspx">公司新闻</a><span>|</span><a
            href="noticelist.aspx">活动公告</a><span>|</span><a href="admin.aspx">基地管理</a><span>|</span><a
                href="vip.aspx">会员服务</a><span>|</span><a href="caizhai.aspx">住宿采摘</a><span>|</span><a
                    href="product.aspx">产品展示</a><span>|</span><a href="intro.aspx">公司简介</a></div>
    <div id="footer">
        <div class="foot">
            电话：<asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            &nbsp;联系人：<asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
            <br />
            北京市豪联夏都农业科技发展有限公司 版权所有 京ICP备10043433号
            <img src="images/logo1.jpg" width="108" height="47" alt="绿色食品" />
        </div>
    </div>
    </form>
</body>
<!-- InstanceEnd -->
</html>