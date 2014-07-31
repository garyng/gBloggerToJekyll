---
layout: post
title: '[教程][Blogger][C#] Blogger API v3 教程#8——更改帖子标题'
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
  
 Blogger 有一个API 叫做blogger.pages.update  
 对应.net 库PostsResource中的.Update() 函数  
 返回一个PostsResource.UpdateRequest 类型  

[![image](http://lh3.ggpht.com/-KkXKuDKU3Pg/UlgJzlIYnXI/AAAAAAAAFKA/IOAEhWBbFNQ/image_thumb.png?imgmax=800 "image")](http://lh6.ggpht.com/-B3xaO76CXOM/UlgJy5WO-EI/AAAAAAAAFJ4/P28HKhAnGqU/s1600-h/image%25255B2%25255D.png)  
  
  
 先拿出其中一个post：  

```
Post postUpdate = postsListReq.Execute().Items[0];
```

  
  
 然后更改标题：  

```
postUpdate.Title = "Title Changed";
```

  
  
 创建一个UpdateRequest  
 然后执行.Execute()  
  

```
PostsResource.UpdateRequest blogUpdate = postRes.Update(postUpdate, blog.Id, postUpdate.Id);
blogUpdate.Execute();
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

            Console.WriteLine("Blog ID: " + blog.Id);
            Console.WriteLine();

            PostsResource postRes = new PostsResource(blogService);
            PostsResource.ListRequest postsListReq = postRes.List(blog.Id);

            string firstToken = "";

            while (true)
            {
                PostList posts = postsListReq.Execute();
                postsListReq.PageToken = posts.NextPageToken;

                if (firstToken == "")
                {
                    firstToken = posts.NextPageToken;
                }
                else if (firstToken != "" && posts.NextPageToken == firstToken)
                {
                    // repeated
                    break;
                }

                for (int i = 0; i < posts.Items.Count; i++)
                {
                    Console.WriteLine("Title: " + posts.Items[i].Title);
                    Console.WriteLine("URL: " + posts.Items[i].Url);
                }

            }

            Post postUpdate = postsListReq.Execute().Items[0];
            postUpdate.Title = "Title Changed";

            PostsResource.UpdateRequest blogUpdate = postRes.Update(postUpdate, blog.Id, postUpdate.Id);
            blogUpdate.Execute();

            Console.WriteLine();
            Console.WriteLine("Done...");

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

  
  
 运行结果：  
  

[![image](http://lh4.ggpht.com/-eEFR9HEe5e0/UlgJ1R5Sf2I/AAAAAAAAFKQ/uZ-cwQOQwE0/image_thumb%25255B2%25255D.png?imgmax=800 "image")](http://lh4.ggpht.com/-vmOYN_mEQso/UlgJ0T0ev9I/AAAAAAAAFKI/Pn9TLpv4yFo/s1600-h/image%25255B8%25255D.png)  
  

# 【后记】

这应该是这个系列的最后一个帖子了..当然还有很多API我没示范..  
 还有整个系列的完整源码我已经发在 Github 上了：  

### <https://github.com/garyng/BloggerAPIv3Samples>
