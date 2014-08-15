using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Blogger.v3;
using Google.Apis.Blogger.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace gBloggerToJekyll
{
	static class BloggerHelper
	{
		public static UserCredential createCredential(ClientSecrets cs, FileDataStore fds)
		{
			UserCredential uc = GoogleWebAuthorizationBroker.AuthorizeAsync(
				cs,
				new[] { BloggerService.Scope.Blogger },
				"user",
				CancellationToken.None,
				fds
				).Result;
			return uc;
		}

		public static BloggerService createService(UserCredential uc, string appName)
		{
			BloggerService bs = new BloggerService(new BaseClientService.Initializer
				{
					HttpClientInitializer = uc,
					ApplicationName = appName
				});
			return bs;
		}

		public static Post getPost(BloggerService bs, string blogId, string postId)
		{
			PostsResource.GetRequest req = bs.Posts.Get(blogId, postId);
			req.View = PostsResource.GetRequest.ViewEnum.ADMIN;

			Post p = req.Execute();
			return p;
		}

		public static List<Post> getPostList(BloggerService bs, string blogId, PostsResource.ListRequest.StatusEnum status)
		{
			PostsResource.ListRequest req = bs.Posts.List(blogId);
			req.View = PostsResource.ListRequest.ViewEnum.ADMIN;
			req.FetchBodies = false;
			req.FetchImages = false;
			req.Status = status;

			List<Post> listOfPost = new List<Post>();
			string firstToken = "";

			while (true)
			{
				PostList posts = req.Execute();
				req.PageToken = posts.NextPageToken;
				if (firstToken == "")
				{
					firstToken = posts.NextPageToken;
				}
				else if (firstToken != "" && posts.NextPageToken == firstToken)
				{
					break;
				}
				if (posts.Items != null)
				{
					posts.Items.ToList().ForEach(item => listOfPost.Add(item));
				}
			}

			return listOfPost;

		}

		public static List<Pageviews.CountsData> getPageViews(BloggerService bs, string blogId, PageViewsResource.GetRequest.RangeEnum range)
		{
			if (bs == null || getBlogUserInfo(bs, blogId).HasAdminAccess != true)
			{
				return null;
			}

			PageViewsResource.GetRequest req = bs.PageViews.Get(blogId);
			req.Range = range;

			Pageviews pv = req.Execute();
			return pv.Counts.ToList();
		}

		public static BlogPerUserInfo getBlogUserInfo(BloggerService bs, string blogId)
		{
			if (bs == null)
			{
				return null;
			}

			BlogUserInfosResource.GetRequest req = bs.BlogUserInfos.Get("self", blogId);
			BlogUserInfo bui = req.Execute();

			return bui.BlogUserInfoValue;
		}

		public static List<Blog> listAllBlogs(BloggerService bs)
		{
			if (bs == null)
			{
				return null;
			}

			BlogsResource.ListByUserRequest req = bs.Blogs.ListByUser("self");
			BlogList bl = req.Execute();

			return bl.Items.ToList();
		}
	}
}
