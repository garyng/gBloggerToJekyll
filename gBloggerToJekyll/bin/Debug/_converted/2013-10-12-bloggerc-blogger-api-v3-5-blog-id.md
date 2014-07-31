---
layout: post
title: '[教程][Blogger][C#] Blogger API v3 教程#5 —— 获取Blog Id'
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
  

# 【获取API Key】

还记得API Key 我们现在需要用到：  
 登录这边获取API
Key：<https://code.google.com/apis/console/b/0/?noredirect>  
 1、在API Access 找到 Simple API Access  

[![image](http://lh6.ggpht.com/-Bkim7AjL0ic/UldGGxb__WI/AAAAAAAAFCo/3ZEMsKoKyaA/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-px10YytHTG8/UldGGdkV_vI/AAAAAAAAFCg/NNQ5_debJqE/s1600-h/image%25255B5%25255D.png)  
  
 2、记下API Key  
  

# 【获取Blog ID】

blogID 和 postID 是最重要的，很多API操作都需要用到它  
 blogID 可以以Blog URL 来获取，所以我们创建两个string  
 一个储存API Key， 另一个储存blog URL  

```
string apiKey = "{YOUR-API-KEY}";
string blogUrl = "{YOUR-BLOG-URL}";
```

  

要用到Blogger API 就需要创建一个Blogger Service，里面传入一个Initializer
参数：  

```
BloggerService blogService = new BloggerService(new BaseClientService.Initializer()); 
```

    Google APIs Explorer 里面有一个API 是：

     

    所以从blogUrl 获取blogID的API 就会在BloggerService 下的 Blogs.GetByURL()

    而Google 的 getByUrl referece（https://developers.google.com/blogger/docs/3.0/reference/blogs/getByUrl）

    说GetByUrl 会返回一个GetByUrl

    对应.net 的BlogResource.GetByUrlRequest

    还需要执行.Execute()函数才能开始获取blogID

    .Execute() 函数返回一个Blog类型

    记得必须给GetUrlRequest 的变量传入API Key，要不然不会收到任何回复的

```
BloggerService blogService = new BloggerService(new BaseClientService.Initializer());
BlogsResource.GetByUrlRequest getReq = blogService.Blogs.GetByUrl(blogUrl);
getReq.Key = apiKey;
Blog blog = getReq.Execute();
```

    然后返回的blog 变量里面就有一个参数叫Id,里面储存的就是Blog 的 ID了

```
Console.WriteLine(blog.Id);
```

    完整代码如下：

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Blogger.v3;
using Google.Apis.Blogger.v3.Data;
using Google.Apis.Services;
using System.Diagnostics;
using Google.Apis.Authentication.OAuth2;
using Google.Apis.Authentication.OAuth2.DotNetOpenAuth;
using DotNetOpenAuth.OAuth2;
using Google.Apis.Util;

namespace BloggerTest
{
 class Program
 {
  static void Main(string[] args)
  {
   string apiKey = "{API-KEY}";
   string blogUrl = "{BLOG-URL}";

   BloggerService blogService = new BloggerService(new BaseClientService.Initializer());

   BlogsResource.GetByUrlRequest getReq = blogService.Blogs.GetByUrl(blogUrl);
   getReq.Key = apiKey;
   Blog blog = getReq.Execute();
   Console.WriteLine(blog.Id);

   Console.ReadKey();

  }
 }
}
```

  
  
  

     

    当你第一次编译运行时，可能会出现这个Open File Dialog

     

    找到下载回来的API dot net client 代码

    去到Src/GoogleApis/Apis/Requests/

    点击Open 就行了

     

    PS：似乎不用这个file 也可以编译..

    运行结果

     
