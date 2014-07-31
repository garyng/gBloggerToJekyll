---
layout: post
title: '[教程][Blogger][C#] Blogger API v3 教程#4 —— 设置开发环境、安装插件、添加Reference'
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
  
 我的环境是：Visual Studio 2012 Update 3 @ Windows 7  

# 【工具】

1、Visual Studio 2012  
 之前发过很多下载地址（多数是torrent的）：[[分享][VS] Visual Studio 2010
+ 2012
下载地址](http://garyngzhongbo.blogspot.com/2013/06/vsvisual-studio-2010-2012.html)  
    
 2、NuGet  
 这个是一个非常好用的 Visual Studio 插件，用来管理packages的  
 下载地址：<http://docs.nuget.org/docs/start-here/installing-nuget>  
    
 3、Google API DotNet Client  

下载地址：<http://contrib.google-api-dotnet-client.googlecode.com/hg/1.5.0-beta/Generated/ZipFiles/google-api-dotnet-client-1.5.0-beta.source.zip>  
  

# 【安装NuGet】

1、到官网选择VS 版本，这里是2012  

[![image](http://lh6.ggpht.com/-A9ma6MXVB94/Ula2uAWfhwI/AAAAAAAAE7o/gQvkVo1q3Mg/image_thumb.png?imgmax=800 "image")](http://lh5.ggpht.com/-7dzPIKaOm1o/Ula2tBQ-Z9I/AAAAAAAAE7g/hwqUNHCTCoU/s1600-h/image%25255B2%25255D.png)  
  
 2、点击Download  

[![image](http://lh5.ggpht.com/-Wxg3HAAk984/Ula2vVEdlrI/AAAAAAAAE74/qBi0iAkLBoo/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-em_nKHHFr40/Ula2uvltMlI/AAAAAAAAE7w/K2NZQ-UJSQs/s1600-h/image%25255B5%25255D.png)  
  
 3、运行点击Install  

[![image](http://lh4.ggpht.com/-3b3Ajl6dv_0/Ula2wrIH-HI/AAAAAAAAE8I/kacgewwW0ug/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-o-5RXtkbA6M/Ula2v8qQNkI/AAAAAAAAE8A/rejZCjwpjsU/s1600-h/image%25255B8%25255D.png)  
  
 4、安装完毕，点击Close  

[![image](http://lh6.ggpht.com/-hy0APOgeP98/Ula2x8RAKVI/AAAAAAAAE8Y/ZrzXvrZRjts/image_thumb%25255B3%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-xxlCIJ_ngVc/Ula2xCnC7kI/AAAAAAAAE8Q/QEoS5wYe0Pw/s1600-h/image%25255B11%25255D.png)  
  

# 【创建&设置Project】

1、打开Visual Studio  
 Ctrl + Shift + N 创建一个新的 Console Application  

[![image](http://lh5.ggpht.com/-iid6AtjWloE/Ula2zyrTvLI/AAAAAAAAE8o/UCZ0_qtbMxs/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-FALHZzyUKPg/Ula2zMFTAnI/AAAAAAAAE8g/BnbaT4BvUcA/s1600-h/image%25255B14%25255D.png)  
  
 2、按下Ctrl + Shift + S 或者到File \> Save All 保存project  

[![image](http://lh4.ggpht.com/-88pjTm2lM2o/UldanKFYrOI/AAAAAAAAFDU/6pYbjL_bCys/image_thumb%25255B17%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-hKUDUtcmLUY/Uldamk-e1DI/AAAAAAAAFDM/SHFY-AK63A8/s1600-h/image%25255B55%25255D.png)  
  

[![image](http://lh4.ggpht.com/-NTbfz31u5fU/Uldaoc3Hz7I/AAAAAAAAFDk/_ZPbjLm9ZcY/image_thumb%25255B18%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-rz7M4XtpynA/Uldan7WCE-I/AAAAAAAAFDc/dXwwLcf4sTk/s1600-h/image%25255B56%25255D.png)  
  
 3、点击Solution Explorer  
 双击Properties  
 然后将Target Framework 更换为.Net Framework 4  
 点击Yes  

[![image](http://lh5.ggpht.com/-Rvo0mQ7PU9Y/Uldapyze9iI/AAAAAAAAFD0/I1uKVqA6QF0/image_thumb%25255B19%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-mlkEImrLdzU/UldapZdrbeI/AAAAAAAAFDs/PAZN-OPLSGU/s1600-h/image%25255B59%25255D.png)  
  
  
 4、点击Solution Explorer  
 右键References  
 点击Manege NuGet Packages…  

[![image](http://lh3.ggpht.com/-pkMFHNzLEFc/Ula21OPgXCI/AAAAAAAAE84/fvF-uVqtabY/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-UwVgChVNgEg/Ula20R1gghI/AAAAAAAAE8w/rky2LIIcomM/s1600-h/image%25255B17%25255D.png)  
  
  
 5、打开NuGet Packages Manager  
 在上方搜索 "Blogger"  
 选择Google.Apis.Blogger.v3 Client Library  
 点击Install  

[![image](http://lh3.ggpht.com/-43o-80B9yxE/Ula26gmSAkI/AAAAAAAAE94/5pWwVXSui0A/image_thumb%25255B9%25255D.png?imgmax=800 "image")](http://lh5.ggpht.com/-_DM-SwL3UlA/Ula254BfA1I/AAAAAAAAE9w/LiTuNJ7LagM/s1600-h/image%25255B29%25255D.png)  
  
 6、等待安装  

[![image](http://lh3.ggpht.com/-WgUGQKvTffY/Ula27_LJjwI/AAAAAAAAE-I/Fr7vEx_2tOg/image_thumb%25255B11%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-9ZInQKRf42k/Ula27eCwmFI/AAAAAAAAE-A/GlDlFVtn7Q8/s1600-h/image%25255B35%25255D.png)  
  
 7、点击Accept  

[![image](http://lh3.ggpht.com/-1auw0uT7kK0/Ula29LAsv2I/AAAAAAAAE-Y/DjfSmQsoihg/image_thumb%25255B13%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-hJ-KeA-VcA8/Ula28YSTrXI/AAAAAAAAE-Q/AVEsuBUJ54k/s1600-h/image%25255B41%25255D.png)  
  
 8、安装完毕后，搜索 Google Apis  
 然后找到Google APIs OAuth2 Client Library  
 点击Install  

[![image](http://lh3.ggpht.com/-uwxr_gcn1vU/Ula2-jrqR1I/AAAAAAAAE-o/irRGTvCk5d0/image_thumb%25255B14%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-wRMrzjyZ_pE/Ula2934VOKI/AAAAAAAAE-g/ZFMlWd2-Tk0/s1600-h/image%25255B44%25255D.png)  
  
 9、点击Close 返回IDE  

[![image](http://lh6.ggpht.com/-ACYkaxyzJqE/Ula3AKODjMI/AAAAAAAAE-4/BX4SsJq-lIE/image_thumb%25255B15%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-ByQ3uPpJ1nk/Ula2_UocohI/AAAAAAAAE-w/INeLxZJyrr4/s1600-h/image%25255B47%25255D.png)  
  
 10、然后添加以下usings  

    using Google.Apis.Blogger.v3;
    using Google.Apis.Blogger.v3.Data;
    using Google.Apis.Services;
    using System.Diagnostics;
    using Google.Apis.Authentication.OAuth2;
    using Google.Apis.Authentication.OAuth2.DotNetOpenAuth;
    using DotNetOpenAuth.OAuth2;
    using Google.Apis.Util;

     

  
  
  
  
  
  
  

