---
layout: post
title: '[教程][Blogger][C#] Blogger API v3 教程#2 —— 申请 Blogger API 的使用权限'
author: 'Gary Ng'
tags: ['blogger','Blogger API','C#','Gdata','Google','OAuth','原创','教程']
---

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
  

# 【基本需求】

1、你需要一个Google 账户  
  

# 【申请Blogger API 使用权限】

1、浏览：<https://cloud.google.com/console#/project>  
 2、点击 Create Project  

[![image](http://lh3.ggpht.com/-du9XOP6TuDw/UlZtAlHW7oI/AAAAAAAAE4I/xGtTkBRw5Tc/image_thumb.png?imgmax=800 "image")](http://lh5.ggpht.com/-ZySypSGq2uE/UlZs_x13bwI/AAAAAAAAE4A/me2MPNHf7qs/s1600-h/image%25255B2%25255D.png)  
  
 3、填入Project 的基本资料  
 Project Name、Project ID  
 勾选 I have read and agree to all Terms of Service for the Google Cloud
Platfom products.  
 然后点击Create  

[![image](http://lh5.ggpht.com/-yzl5cWh4n2E/UlZtB29n_9I/AAAAAAAAE4Y/eJDwoGwWf60/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-jWVuucZ084U/UlZtBbf56kI/AAAAAAAAE4Q/V89IDuHB2sU/s1600-h/image%25255B5%25255D.png)  
  
 4、点击左边的APIs & auth  

[![image](http://lh6.ggpht.com/-GxDmKljOTX4/UlZtDPMrb9I/AAAAAAAAE4o/AcEXMh6kEhc/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-ZZvhrvJbg-E/UlZtCf-W62I/AAAAAAAAE4g/5hm6wOjyEgs/s1600-h/image%25255B8%25255D.png)  
  
 5、找到Blogger API v3，点击 OFF  

[![image](http://lh4.ggpht.com/-0NQJpUC7qxc/UlZtEUEQkKI/AAAAAAAAE44/rpak3nH9nBk/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-fPihxCCxFFk/UlZtD3Ne2wI/AAAAAAAAE4w/vwhk0b4TjaE/s1600-h/image%25255B14%25255D.png)  
  
 6、然后就会有这个Quota Request 的申请表格  
 滑倒下面点击提交就行了  

[![image](http://lh4.ggpht.com/-pMfG_L_HUkg/UlZtFix_JiI/AAAAAAAAE5I/NEbx5zMeAq8/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-8I6qaBeFDT4/UlZtFMHTcFI/AAAAAAAAE5A/O5ETMoSSxIg/s1600-h/image%25255B17%25255D.png)  
  
 7、然后等待Google 发给你回复，通常一两天就能了：  

[![image](http://lh3.ggpht.com/-uhdC52jkCqc/UlZtG2vRIxI/AAAAAAAAE5Y/trZl5ZF5ZVo/image_thumb%25255B6%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-w0Bx_iGJo_M/UlZtGZ8QauI/AAAAAAAAE5Q/91HMLQT7N38/s1600-h/image%25255B20%25255D.png)  
  
 8、点击email 中的 link，就可以了  

[![image](http://lh5.ggpht.com/-471Eslp1SwA/UlZtILte26I/AAAAAAAAE5o/QYtR1Ex3mRE/image_thumb%25255B7%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-WxjKIkcMbj8/UlZtHYleiwI/AAAAAAAAE5g/wEgBtrde5cw/s1600-h/image%25255B23%25255D.png)

