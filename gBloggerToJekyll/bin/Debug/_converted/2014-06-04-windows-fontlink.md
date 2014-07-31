---
layout: post
title: '[教程][Windows] 以FontLink解决某字体中文下乱码的问题'
author: 'Gary Ng'
tags: ['原创','教程']
---

笔者最近才装好Windows 8 （记得么—— [[原创][教程]
在USB内直接使用正式版Windows
8](http://garyngzhongbo.blogspot.com/2012/11/usbwindows-8.html)）  
 打开Notepad 将字体设置为Consolas 后，输入中文字显示一堆乱码（Windows
Live Writer 内也是……）  
 Google了很久却无果  
 突然想到FontLink 便着手试试  
 没想到成功了 xD  

# 【步骤】

1、打开regedit  
 （Win + R \> regedit）  
 找到HKEY\_LOCAL\_MACHINE\\SOFTWARE\\Microsoft\\Windows
NT\\CurrentVersion\\FontLink\\SystemLink  

[![image](http://lh5.ggpht.com/-DtcpULk60WA/U46tiGUSD-I/AAAAAAAAG_0/830vY-DDmOE/image_thumb.png?imgmax=800 "image")](http://lh6.ggpht.com/-PQrbesKT9g4/U46tgz60jtI/AAAAAAAAG_s/Yj27nembYdM/s1600-h/image%25255B2%25255D.png)  
  
 2、在空白处右键，点击New \> Multi-String Value  

[![image](http://lh4.ggpht.com/-YJuYEAsaFG8/U46tkv6T3JI/AAAAAAAAHAE/Lz-Zal-9RvM/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-qM4fGzK4atY/U46tjSP9teI/AAAAAAAAG_8/wBvYYB5J2o4/s1600-h/image%25255B5%25255D.png)  
  
 3、重命名成Consolas  

[![image](http://lh3.ggpht.com/-XyPBH3QHCdg/U46tmiJyEGI/AAAAAAAAHAU/KRENTbrVjTo/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-Bg7EvCCtvow/U46tlQmg9lI/AAAAAAAAHAM/JyQ2lkT5w18/s1600-h/image%25255B8%25255D.png)  
  
 4、双击打开，输入：  
 TAHOMA.TTF  
 MSYH.TTC,Microsoft YaHei UI,128,96  
 MSYH.TTC,Microsoft YaHei UI  
 MSJH.TTC,Microsoft Jhenghei UI,128,96  
 MSJH.TTC,Microsoft Jhenghei UI  

[![image](http://lh5.ggpht.com/-kGMrMy4RZRA/U46tozsvUCI/AAAAAAAAHAk/UOo8WpX7jNM/image_thumb%25255B3%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-J2qOJ1AhJ8Q/U46tnXZW1CI/AAAAAAAAHAc/2uTq99Bb53M/s1600-h/image%25255B11%25255D.png)  
 完成后点击OK  
  
 5、重启就可以看到效果了：  

[![image](http://lh3.ggpht.com/-ffusV07Une4/U46trAzEETI/AAAAAAAAHA0/-XEYWBmB27I/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-dNQl58ZnNTE/U46tppZat1I/AAAAAAAAHAs/FJEGtBOoCBQ/s1600-h/image%25255B14%25255D.png)  
  
  
  
 PS：笔者我试了好久才弄到的..  
 失败品：  

[![2014-06-04\_121246](http://lh4.ggpht.com/-OzI2HtUIMaQ/U46tsy-e53I/AAAAAAAAHBE/RerGPLYcnAE/2014-06-04_121246_thumb.png?imgmax=800 "2014-06-04_121246")](http://lh5.ggpht.com/-tMGURxK9F4Y/U46tr6nf6MI/AAAAAAAAHA8/EPW4Mo8mj08/s1600-h/2014-06-04_121246%25255B2%25255D.png)  
  
 PS2：部落格似乎变得越来越慢了..太臃肿了么..

