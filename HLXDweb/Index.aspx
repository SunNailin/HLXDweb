<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HLXDweb.Index1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>北京市豪联夏都农业科技发展有限公司</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
</head>

<body>
    <form id="form1" runat="server">
    <div>    
    </div>
    <div id="header"><a href="#"><img src="images/logo5.png" width="480" height="71" 
        alt="豪联夏都" /></a></div>
<div id="nav">
	<span class="navLeft"></span>
    <ul class="navCenter">
    	<li><a href="#">首页</a></li>
        <li><a href="intro.aspx">公司简介</a></li>
        <li><a href="service.aspx">产品展示</a></li>
        <li><a href="#">新闻动态</a></li>
        <li><a href="#">活动公告</a></li>
        <li><a href="#">葡萄酒博物馆</a></li>
        <li><a href="#">采摘住宿</a></li>
        <li><a href="#">会员服务</a></li>     
        <li><a href="#">联系我们</a></li>        
     </ul>
    <span class="navRight"></span>
</div>
<div id="banner"></div>
<div id="content">
	<ul class="conTop">
    	<li>
        	<h2><a href="#"><img src="images/tit_bg1.jpg" alt="有机蔬菜" /></a></h2>
            <p>主要通过自然降水、施用农家肥人工除草等传统的农...</p>
        </li>
        <li>
        	<h2><a href="#"><img src="images/tit_bg2.jpg" alt="有机蔬菜" /></a></h2>
            <p>含有丰富的碳水化合物、维生素和微量元素，尤其是...</p>
        </li>
        <li>
        	<h2><a href="#"><img src="images/tit_bg3.jpg" alt="有机蔬菜" /></a></h2>
            <p>含有丰富的碳水化合物、维生素和微量元素，尤其是...</p>
        </li>
        <li>
        	<h2><a href="#"><img src="images/tit_bg4.jpg" alt="有机蔬菜" /></a></h2>
            <p>在饲养过程中不添加任何化学合成的添加剂、抗生素...</p>
        </li>
    </ul>
    <div class="conBot">
    	<div class="conBotL">
        	<h2><a href="#"><img src="images/tit_bg5.jpg" width="185" height="38" alt="关于我们" /></a><span><a href="#"><img src="images/more.jpg" width="35" height="20" alt="更多" /></a></span></h2>
            <dl>
            	<dt><a href="#"><img src="images/photo_1.jpg" width="96" height="82" alt="豪联夏都" /></a></dt>
                <dd>豪联夏都农业生态园立志于有机事业的发展，坚持以人为本，走可持续发展的道路，从农田到餐桌，实行全过程监控体系，以优质的产品为更多的人提供健康的食品安...<a href="#">详细内容>></a></dd>
            </dl>
        </div>
        <div class="conBotC">
        	<h2><a href="#"><img src="images/tit_bg6.jpg" width="148" height="38" alt="产品展示" /></a><span><a href="#"><img src="images/more.jpg" width="35" height="20" alt="更多" /></a></span></h2>
            <ul>
            	<li>
                	<p class="one"><a href="#"><img src="images/photo_2.jpg" width="114" height="88" /></a></p>
                    <p class="two"><a href="#">(古道)纯牛奶</a></p>
                </li>
                <li>
                	<p class="one"><a href="#"><img src="images/photo_3.jpg" width="114" height="88" /></a></p>
                    <p class="two"><a href="#">油茶籽油</a></p>
                </li>
                <li class="noMargin">
                	<p class="one"><a href="#"><img src="images/photo_4.jpg" width="114" height="88" /></a></p>
                    <p class="two"><a href="#">龙兴香桃</a></p>
                </li>
            </ul>
      </div>
        <div class="conBotR">
        	<h2><a href="#"><img src="images/tit_bg7.jpg" width="126" height="38" alt="联系我们" /></a></h2>
            <p>
            	地  址：<a href="http://j.map.baidu.com/lTSkB"  target="_blank">北京市延庆县张山营镇西卓家营村东500米豪联夏都葡萄庄园<br />    </a> 
                邮  编：100000<br />  
                热线电话：010-88888888<br />                                
                传  真：010-88886666<br />  
                邮  箱：
                
            </p>
        </div>
    </div>
</div>
<div id="botNav"><a href="#">网站首页</a><span>|</span><a href="#">公司新闻</a><span>|</span><a href="#">行业动态</a><span>|</span><a href="#">基地管理</a><span>|</span><a href="#">会员服务</a><span>|</span><a href="#">网上购物</a><span>|</span><a href="#">产品展示</a><span>|</span><a href="#">关于我们</a></div>
<div id="footer">
<div class="foot">
    	电话：010-69111309/69112018/69112016　联系人：龙经理 13801276881<br />
	  北京市豪联夏都农业科技发展有限公司 版权所有 京ICP备10043433号
    <img src="images/logo1.jpg" width="108" height="47" />　  
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
</div>
    </form>
    </body>
</html>
