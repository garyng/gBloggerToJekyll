---
layout: post
title: '[原创][开源][C#] YouTube Video Grabber（YouTube 视频下载器） 回来啦！'
author: 'Gary Ng'
tags: ['C#','download','Youtube','Youtube Downloader','原创','开源']
---

### 更新：  
笔者建了个简单的网站：<http://youtubesniffer.tk/>，笔者所有更新都会放在该网站上！

  
 用手指头算算，Video Grabber 这个很大很大的 project
也大概有1年了，当初初学VB6，加入了个团队，一时其兴，就胡乱写了个YouTube
Video
Grabber（当然，当初不是这个名字的），起初被队员强力反对，为什么呢？因为没看头！管他呢！俺继续写！写着写着，1年过去了，只发布了3个向外公开的公测版本，最后就因为学业的关系，就没去更新了，放假时才抽空补充功能，解除BUG。  
  
 **PS：还记得前3个版本么？他们在这里——[【原创】【VB6】AG Youtube
Downloader -
免费的Youtube视频下载器](http://garyngzhongbo.blogspot.com/2012/03/vb6ag-youtube-downloader-youtube.html)、[【原创】【VB6】AG
Youtube Downloader 正式更名为 AG Youtube Video
Grabber](http://garyngzhongbo.blogspot.com/2012/04/vb6ag-youtube-downloader-ag-youtube.html)、[【原创】【VB6】YouTube
Video Grabber
大翻新！](http://garyngzhongbo.blogspot.com/2012/05/vb6youtube-video-grabber.html)**  
  

功能越来越多时，问题就来了——整个软件变得很复杂，操作变难了，用VB6来写越来越力不从心，代码越来越难管理（没办法啊，初学VB6的代码风格就是很烂啊），又不适合搞个稳定的多线程，队员没有一个可以看懂VB6代码，于是我有了个念头：放弃更新VB6版本的Grabber，把代码开放出来，用.net重写整个Grabber！  
  

今年11月兴致勃勃的学了C\#，为了什么？为了Grabber啊！搞了整个月，成果出来了！新版本的Grabber注重的是简洁、操作方便。在这之前，我有个想法，那就是Hook
WebBrowser的send API，然后揭下YouTube
的视频下载链接，于是就依照这个课题写了个教程，创建了一个名为youtubesniffer的Google
Page，没想到，功力不足啊！失败了，API
Hooking不是随手就能搞出来的啊！又丢下了Hook
API这个念头，重拾回Grabber一直用着的方法——暴力解析视频网页的HTML代码。VB6版本的Grabber
也是一直基于这个方法运作的，但是YouTube的HTML代码常常更换，所以需要常常更新，奈何笔者外婆功课繁重，没办法一直更新，所以才有了开放源代码的念头。  
  

但是出了刚刚所说的暴力分析视频网页的源代码，笔者又详细分析了YouTube传输video的方法，总结另外4个方法——2个是基于请求头（request
header），另外一个是基于YouTube
自带的get\_video\_info方法，各有各的优点，get\_video\_info这个方法虽好，但是碰到有版权的视频，YouTube
什么资料都不给了！所以到头来，还是暴力的分析HTML代码好啊！  
  
 **想看看那些教程在那里么？来这里——[YouTube Video Downloading
Tutorial](http://code.google.com/p/youtubesniffer/wiki/YouTubeVideoDownloadingTutorial)**  
 PS：笔者的英文很差的啊！  
  
 先说开源的事，youtubesniffer的Google Page
包括了VB6和C\#版本的Grabber的源代码，VB6的代码相对的比较乱些，C\#的就比较有规划（毕竟搞编程也有一年多了，没有良好的代码风格会给人家笑的啊！）  
  
 **【Google Page网址】：YouTubeSniffer’s Google Page:
<http://code.google.com/p/youtubesniffer/>**  
 **  
**
源代码的版本是用SVN管理的，要下载源代码呢，就必须用SVN下载，于是又写了个教程，教导大家如何用TortoiseSVN（GUI版本的SVN）来下载youtubesniffer的代码。  
  
 **教程网址（Google Page）：[How To Use TortoiseSVN To Download
YouTubeSniffer’s SVN
thrunk?](http://code.google.com/p/youtubesniffer/wiki/HowToUseSvn)**  
 **TortoiseSVN来这里下载：<http://tortoisesvn.net/downloads.html>**  
 **  
** 这里也有相同的视频教程：  
  

How to use SVN?

  
  

**这里来查看有没有新版本：<http://code.google.com/p/youtubesniffer/wiki/LatestRelease>**  
 【YouTube Video Grabber .net】  

写了一大堆东东，来正题吧！这个新版本的是以C\#重写，任何看懂C\#代码的大大都可以到Google
Page去下载源代码！  
 这些是一些截图：  

[![image](http://lh5.ggpht.com/-P8cy2w8D4V8/ULx_b3nNUCI/AAAAAAAACus/0n1vY7D3b0g/image_thumb.png?imgmax=800 "image")](http://lh3.ggpht.com/-iBvjlLEawhs/ULx_a7xfDfI/AAAAAAAACuo/2xuYZXi48v4/s1600-h/image%25255B2%25255D.png)  
 *主界面*  
 新版本的主界面分为3大区，分别是
视频截图显示区、资料显示区和下载选项区，是不是与之前的版本简洁多了？  
  

[![image](http://lh6.ggpht.com/-ifIRSVTI290/ULx_eD_1WAI/AAAAAAAACvA/UTsp7R1YQ6s/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-STdKe2HBIeU/ULx_crl1pJI/AAAAAAAACu0/v3S0HWnure0/s1600-h/image%25255B5%25255D.png)  
 *下载器*  

这个版本的下载器支持多线程下载，也就是说能一次性的下载多个视频，当然了，下载速度也会随着下载的数量而改变，越多，下载速度就相对的比较慢。  
  

[![image](http://lh3.ggpht.com/-YBEeUGaXzlw/ULx_gEza_lI/AAAAAAAACvM/8hMBmQSk39s/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-7RsggaqP-UU/ULx_fEl9qpI/AAAAAAAACvE/nL-c-OjzLy8/s1600-h/image%25255B8%25255D.png)  
 *About窗体*  
 还是之前那个图片，哈哈！  

[![image](http://lh3.ggpht.com/-uVV1n9coTI4/ULx_iWc9NoI/AAAAAAAACvg/qTzaNQxDB08/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-zC6-pdHZU_8/ULx_g-sEJ0I/AAAAAAAACvY/swLOouhN6Z8/s1600-h/image%25255B14%25255D.png)  
 *Oppa Gangnam Style!*  
 运作中的Grabber！  
  
 有时候会遇到这种情况：  

[![image](http://lh6.ggpht.com/-Rit-3u37tek/ULx_kl9P4PI/AAAAAAAACvw/_crt1ey0VDM/image_thumb%25255B3%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-6QctH7KUgzA/ULx_juzHO8I/AAAAAAAACvk/-HKeDkIA7VI/s1600-h/image%25255B11%25255D.png)  

没关系，只要才重试一次就好了！笔者不知道为什么，有时候会下载到不同的HTML代码，带着解析HTML代码的模块会出现错误。  
  
 【Youtube Video Grabber .net 下载地址】：[Youtube Video
Grabber](https://dl.dropbox.com/u/43619472/%E6%89%B9%E5%A4%84%E7%90%86/C%23/YouTube%20Video%20Grabber/YouTube%20Grabber.exe "https://dl.dropbox.com/u/43619472/%E6%89%B9%E5%A4%84%E7%90%86/C%23/YouTube%20Video%20Grabber/YouTube%20Grabber.exe")  
  
 这里是C\# 版本的Grabber
的思路图，用FreeMind（这里下载：<http://freemind.sourceforge.net/wiki/index.php/Main_Page>）
做的  
 [![YouTube Video
Grabber](http://lh5.ggpht.com/-BwDu50JH7XU/ULx_nVsTbqI/AAAAAAAACwA/Pr2W3bWqlM4/YouTube%252520Video%252520Grabber_thumb.png?imgmax=800 "YouTube Video Grabber")](http://lh4.ggpht.com/-uQllEvJ9HRM/ULx_l0owReI/AAAAAAAACv4/bGUhYZ_QwH8/s1600-h/YouTube%252520Video%252520Grabber%25255B2%25255D.png)

