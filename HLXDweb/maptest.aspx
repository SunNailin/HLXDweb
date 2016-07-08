﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="maptest.aspx.cs" Inherits="HLXDweb.maptest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>  
<meta name="viewport" content="initial-scale=1.0, user-scalable=no" />  
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />  
<title>Hello, World</title>  
<style type="text/css">  
html{height:100%}  
body{height:100%;margin:0px;padding:0px}  
#container{height:100%}  
</style>  
<script type="text/javascript" src="http://api.map.baidu.com/api?v=2.0&ak=eKICFDnhxT1dFF3u2Lf8oPytU8z9OsWk">
    //v2.0版本的引用方式：src=""
    //v1.4版本及以前版本的引用方式：src=""
</script>
</head>  
 
<body>  
<div id="container"></div> 
<script type="text/javascript">
    var map = new BMap.Map("container");          // 创建地图实例  
    var point = new BMap.Point(116.404, 39.915);  // 创建点坐标  
    map.centerAndZoom(point, 15);                 // 初始化地图，设置中心点坐标和地图级别  
</script>  
</body>  
</html>