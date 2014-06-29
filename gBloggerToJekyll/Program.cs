using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Blogger.v3;
using Google.Apis.Blogger.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace gBloggerToJekyll
{
	class Program
	{
		static void Main(string[] args)
		{
			BloggerHelper bh = new BloggerHelper("1063292627846-cklckmk7efnioeli841r29q98n8tika4.apps.googleusercontent.com", "zIJi0yOm0d3v54oPsu2jvvkF", "gBloggerToJekyll");
			List<Blog> blogs = new List<Blog>();

			bh.Login();
			//List blogs
			blogs = bh.ListAllBlogs();
			blogs.ForEach(delegate(Blog item)
			{
				Console.WriteLine(item.Name + " (" + item.Id+ ")");
				Console.WriteLine(item.Published.Value.ToString());
				Console.WriteLine(item.Updated.Value.ToString());
				Console.WriteLine();
			});

			//Select blog
			string blogId = blogs[0].Id;

			BlogPerUserInfo bpui = bh.GetBlogUserInfo(blogId);
			Console.WriteLine(bpui.UserId);
			Console.WriteLine(bpui.Role);

			if (bpui.HasAdminAccess == true)
			{
				Console.WriteLine(bh.GetPageViews(blogId));
			}

			Console.ReadKey();
			//bh.Logout();
		}
	}
	
	class BloggerHelper
	{
		ClientSecrets _csAppSec = new ClientSecrets();
		UserCredential _ucUser = null;
		BloggerService _bsBlogger = null;
		FileDataStore _fdsStore = null;
		string _strAppName = "";

		public BloggerHelper(string clientId, string clientSec,string appName)
		{
			_csAppSec = new ClientSecrets
			{
				ClientId = clientId,
				ClientSecret = clientSec
			};

			_fdsStore = new FileDataStore(appName);
			_strAppName = appName;
		}

		public void Login()
		{
			_ucUser = GoogleWebAuthorizationBroker.AuthorizeAsync(
				_csAppSec,
				new[] { BloggerService.Scope.Blogger },
				"user",
				CancellationToken.None,
				_fdsStore
				).Result;

			_bsBlogger = new BloggerService(new BaseClientService.Initializer
				{
					HttpClientInitializer = _ucUser,
					ApplicationName = _strAppName
				});
		}

		public void Logout()
		{
			_ucUser = null;
			_bsBlogger = null;
			_fdsStore.ClearAsync();
		}

		public List<Blog> ListAllBlogs()
		{
			return listAllBlogs(_bsBlogger);
		}

		public BlogPerUserInfo GetBlogUserInfo(string blogId)
		{
			return getBlogUserInfo(_bsBlogger, blogId);
		}

		public long? GetPageViews(string blogId)
		{
			return getPageViews(_bsBlogger, blogId, PageViewsResource.GetRequest.RangeEnum.All)[0].Count;
		}

		private List<Pageviews.CountsData> getPageViews(BloggerService bs, string blogId, PageViewsResource.GetRequest.RangeEnum range)
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

		private BlogPerUserInfo getBlogUserInfo(BloggerService bs, string blogId)
		{
			if (bs == null)
			{
				return null;
			}

			BlogUserInfosResource.GetRequest req = bs.BlogUserInfos.Get("self",blogId);
			BlogUserInfo bui = req.Execute();

			return bui.BlogUserInfoValue;
		}

		private List<Blog> listAllBlogs(BloggerService bs)
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
