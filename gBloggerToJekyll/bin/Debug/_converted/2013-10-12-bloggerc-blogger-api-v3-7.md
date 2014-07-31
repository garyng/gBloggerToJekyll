---
layout: post
title: '[教程][Blogger][C#] Blogger API v3 教程#7——获取帖子列表'
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

  

# 【获取帖子列表】

    有BlogID 了万事好办..

    Blogger API的数据模型是这样的：

    Blogs Resource 下有Posts Resource

    所以我们创建一个PostsResource变量，传入blogService

```
PostsResource postsRes = new PostsResource(blogService);
```

  

     

    有一API 叫做 posts.list

     

    如上面的GetByUrl Request 一般，PostsResource 也有ListRequest

    呼叫PostsResouce 里面的 .List函数，返回一个PostsResource.ListRequest

    然后呼叫PostsResource.ListRequest 的.Execute()函数，返回一个PostList 类型

  

```
PostsResource postsRes = new PostsResource(blogService);
PostsResource.ListRequest postsListReq = postsRes.List(blog.Id);
PostList posts = postsListReq.Execute();
```

  

    Blogger API 默认返回10个posts，储存在Post.Items中

    现在在遍历.Items 然后输出post的 Title

  

```
for (int i = 0; i < posts.Items.Count; i++)
{
    Console.WriteLine(posts.Items[i].Title);
}
```

  
  
 完整代码：  
  

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
            PostList posts = postsListReq.Execute();

            for (int i = 0; i < posts.Items.Count; i++)
            {
                Console.WriteLine(posts.Items[i].Title);
            }

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

  
  
 输出结果：  
  

[![image](http://lh3.ggpht.com/-tG6wsSFk9cY/Ule_eZf6zzI/AAAAAAAAFJA/dqR8_GzRs7M/image_thumb.png?imgmax=800 "image")](http://lh6.ggpht.com/-eX7iOd2gHMw/Ule_dvZwMiI/AAAAAAAAFI4/UXsZKfAOqKs/s1600-h/image%25255B2%25255D.png)  
  
  
  

# 【获取所有帖子】

  
 PostList 里面有个.PageToken和.NextPageToken、.PrevPageToken  
  
 基本上，含义是这样：  
  

[![unnamed1](http://lh6.ggpht.com/-o1poxQCr0N0/UlfU9mLQKyI/AAAAAAAAFJY/AZe2r_MSv-0/unnamed1_thumb.png?imgmax=800 "unnamed1")](http://lh5.ggpht.com/-utEF--ktbVU/UlfU8jvb_-I/AAAAAAAAFJQ/OZS1p0fsAxU/s1600-h/unnamed1.png)  
  
  
  
 所以我们要遍历所有的帖子的话，  
  
 要把.PageToken 设置为 NextPageToken  
  
 然后还要检测当前的PageToken是否为第一个的PageToken
（因为我们已经获取过了，所以不用获取了），如果是的话，就break 出 while
loop  
  
 所以把之前代码中的  
  

```
PostList posts = postsListReq.Execute();
```

  
 删除掉  
  
 现在定义一个string为 firstToken  
  
 用来储存第一个NextPageToken  
  

```
string firstToken = "";
```

  
  
 现在就是while loop  
  

```
现在就是while loop

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

```

  
 }  
  
  
  
 完整代码：  
  

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
            string apiKey= "{API-KEY}"
            string blogUrl= "{BLOG-URL}"

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

  
  
  
  
 输出结果：  
  

[![image](http://lh6.ggpht.com/-XGsogmezQs8/UlfU_csdyzI/AAAAAAAAFJo/li39Jbc6dpE/image_thumb%25255B1%25255D.png?imgmax=800 "image")](http://lh3.ggpht.com/-1YXLwoMPOnw/UlfU-XF-eXI/AAAAAAAAFJg/-dqbC9MCCJo/s1600-h/image%25255B5%25255D.png)

