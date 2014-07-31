---
layout: post
title: '[教程][Blogger][C#] Blogger API v3教程#1 —— 前言'
author: 'Gary Ng'
tags: ['blogger','Blogger API','C#','Gdata','OAuth','原创','教程']
---

# 【前言】

Blogger API v3 的.net 库仍在beta
版本，所以网上的教程几乎都是用GData来操作Blogger的，Blogger API v3
的教程少之又少..我为此至少花了一整个星期才搞定..  
  
 因为Google API .net Client 的 Google Code Page
(<https://code.google.com/p/google-api-dotnet-client/wiki/GettingStarted>)
没有很详细的教程，而且也没有说哪一个平台适合用、那个版本的VS适合，搞定这一项占据了我大部分的时间。  
  
 不过Google 的 APIs Explorer
帮了我很大的忙——<https://developers.google.com/apis-explorer/#p/blogger/v3/>
很多接口的用法都是那边学来的..  
  
 我发现VS2010 压根儿不能成功编译Blogger API
v3的code，不知道为啥..求解，但是初步断定是需要.net 4.5 （因为在某source
file 里面看到了await关键字），所以安装了VS2012
测试，也是不能，不过过后将target framework 换成.net 4.0
后又成功编译了..后面会有详细介绍。  
  
 只在Windows 7 上试过，其他操作系统没试过（Windows XP 似乎不能）  
  

# 【这个系列中..】

[[教程][Blogger][C\#] Blogger API v3教程\#1 ——
前言](http://garyngzhongbo.blogspot.com/2013/10/bloggerc-blogger-api-v31.html)  
 [[教程][Blogger][C\#] Blogger API v3 教程\#2 —— 申请 Blogger API
的使用权限](http://garyngzhongbo.blogspot.com/2013/10/bloggerc-blogger-api-v3-2-blogger-api.html)  
 [[教程][Blogger][C\#] Blogger API v3 教程\#3 —— 获取API Key、Client ID
和 Client
Secret](http://garyngzhongbo.blogspot.com/2013/10/bloggerc-blogger-api-v3-3-api-keyclient.html)  
 [[教程][Blogger][C\#] Blogger API v3 教程\#4 ——
设置开发环境、安装插件、添加Reference](http://garyngzhongbo.blogspot.com/2013/10/bloggerc-blogger-api-v3-4-reference.html)  
 [[教程][Blogger][C\#] Blogger API v3 教程\#5 —— 获取Blog
Id](http://garyngzhongbo.blogspot.com/2013/10/bloggerc-blogger-api-v3-5-blog-id.html)  
 [[教程][Blogger][C\#] Blogger API v3 教程\#6——OAuth 2.0
认证](http://garyngzhongbo.blogspot.com/2013/10/bloggerc-blogger-api-v3-6oauth-20.html)  
 [[教程][Blogger][C\#] Blogger API v3
教程\#7——获取帖子列表](http://garyngzhongbo.blogspot.com/2013/10/bloggerc-blogger-api-v3-7.html)  
 [[教程][Blogger][C\#] Blogger API v3
教程\#8——更改帖子标题](http://garyngzhongbo.blogspot.com/2013/10/bloggerc-blogger-api-v3-8.html)

