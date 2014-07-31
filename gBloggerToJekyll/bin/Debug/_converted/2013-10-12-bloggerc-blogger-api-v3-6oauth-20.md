---
layout: post
title: '[教程][Blogger][C#] Blogger API v3 教程#6——OAuth 2.0 认证'
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
  
 至于OAuth 是啥，这里不做详细介绍  
 就是类似这样的东东：  

[![image](http://lh3.ggpht.com/-8EcUGThBuAo/UleX3FKLrSI/AAAAAAAAFG4/inkJJafEn3M/image_thumb.png?imgmax=800 "image")](http://lh3.ggpht.com/-FEteT-Eh-xk/UleX2f62-sI/AAAAAAAAFGw/bCRjGbNSc_M/s1600-h/image%25255B2%25255D.png)  
  
 1、先到这边获取Client Id 和 Client Secret
：<https://code.google.com/apis/console/b/0/?noredirect>  

[![image](http://lh5.ggpht.com/-SAYj_aziQ6c/UleX4V30ZUI/AAAAAAAAFHI/jpgqN8JlNkg/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-3WRTcBCYnLo/UleX3trC52I/AAAAAAAAFHA/6Q6KP83u6js/s1600-h/image%25255B5%25255D.png)  
  
 2、创建两个string，储存Client ID 和 Secret  

```
string clientID = "{CLIENT-ID}";
string clientSec = "{CLIENT-SECRET}";
```

  
  
 3、Google Code Page 这里有个OAuth2.0 的 .net
版本例子，我们照搬改点东西就好了：  

[![image](http://lh4.ggpht.com/-ZkFSlllU_kQ/UleX6B2cSYI/AAAAAAAAFHY/nCI6Js3QKII/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-UKsV2ZR5KY8/UleX5ZqGOqI/AAAAAAAAFHQ/-TFTDUxfwq0/s1600-h/image%25255B8%25255D.png)  
  
 所以我们只要改一改我们的BloggerService 再加上一个function就行了：  
 先创建NativeApplicationClient  

```
NativeApplicationClient provider = new NativeApplicationClient(GoogleAuthenticationServer.Description)
{
    ClientIdentifier = clientID,
    ClientSecret = clientSec
};
```

  
 然后是增加一个函数  

```
private static IAuthorizationState getAuth(NativeApplicationClient arg)
{
    IAuthorizationState state = new AuthorizationState(new [] {BloggerService.Scopes.Blogger.GetStringValue()})
        {
            Callback = new Uri(NativeApplicationClient.OutOfBandCallbackUrl)
        };
    Uri authUri = arg.RequestUserAuthorization(state);
    Process.Start(authUri.ToString());
    Console.WriteLine("Please enter auth code:");
    string authCode = Console.ReadLine();
    return arg.ProcessUserAuthorization(authCode, state);
}
```

  
  
 创建OAuth2Authenticator  

```
OAuth2Authenticator<NativeApplicationClient> auth = new OAuth2Authenticator<NativeApplicationClient>(provider, getAuth);
```

  
  
 然后更改BloggerService  

```
BloggerService blogService = new BloggerService(new BaseClientService.Initializer()
{
    Authenticator = auth,
    ApplicationName = "BloggerTest"
});
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
   string apiKey= "{API-KEY}";
   string blogUrl= "{BLOG-URL}";

   string clientID = "{CLIENT_ID}";
   string clientSec = "{CLIENT_SECRET}";

   NativeApplicationClient provider = new NativeApplicationClient(GoogleAuthenticationServer.Description)
   {
    ClientIdentifier = clientID,
    ClientSecret = clientSec
   };

   OAuth2Authenticator<NativeApplicationClient> auth = new OAuth2Authenticator<NativeApplicationClient>(provider, getAuth);

   BloggerService blogService = new BloggerService(new BaseClientService.Initializer()
   {
    Authenticator = auth,
    ApplicationName = "BloggerTest"
   });

   BlogsResource.GetByUrlRequest getReq = blogService.Blogs.GetByUrl(blogUrl);
   getReq.Key = apiKey;
   Blog blog = getReq.Execute();
   Console.WriteLine(blog.Id);

   Console.ReadKey();

  }

  private static IAuthorizationState getAuth(NativeApplicationClient arg)
  {
   IAuthorizationState state = new AuthorizationState(new[] { BloggerService.Scopes.Blogger.GetStringValue() })
    {
     Callback = new Uri(NativeApplicationClient.OutOfBandCallbackUrl)
    };
   Uri authUri = arg.RequestUserAuthorization(state);
   Process.Start(authUri.ToString());
   Console.WriteLine("Please enter auth code:");
   string authCode = Console.ReadLine();
   return arg.ProcessUserAuthorization(authCode, state);
  }
 }
}
```

  
  
  
 编译运行后，程序会开启一个页面：  
 点击Accept  

[![image](http://lh6.ggpht.com/-S_bLpcLohSU/UleX7Wx1nhI/AAAAAAAAFHk/0AoRuI-kKAE/image_thumb%25255B3%25255D.png?imgmax=800 "image")](http://lh6.ggpht.com/-erAFVPZLm_c/UleX6m10pAI/AAAAAAAAFHc/j1QfHEENa2o/s1600-h/image%25255B11%25255D.png)  
  
  
 然后就有一长串字符，Copy 了 paste 进程序内 （[[教程] 如何在CMD中Copy &
Paste](http://garyngzhongbo.blogspot.com/2013/10/cmdcopy-paste.html)）  

[![image](http://lh6.ggpht.com/-2Nj1_EIyY9g/UleX8TLBGgI/AAAAAAAAFH4/BcJ7oOKnJx4/image_thumb%25255B4%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-RwljnDEuO2g/UleX7yq0MRI/AAAAAAAAFHw/h8biK1DCJxY/s1600-h/image%25255B14%25255D.png)  
  
 然后照常输出blog id  

[![image](http://lh5.ggpht.com/-YOzsZZts-jE/UleX9rBvCdI/AAAAAAAAFII/zCND2eAOq08/image_thumb%25255B5%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-nFPj4S0WV54/UleX86AxCpI/AAAAAAAAFIA/OqI7iSiIEK4/s1600-h/image%25255B17%25255D.png)  
  
 PS：Auth code 会过期的！

