using System;
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Blogger.v3;
using Google.Apis.Blogger.v3.Data;
using Google.Apis.Util.Store;

namespace gBloggerToJekyll
{
	class BloggerManager
	{
		ClientSecrets _csAppSec = new ClientSecrets();
		UserCredential _ucUser = null;
		BloggerService _bsBlogger = null;
		FileDataStore _fdsStore = null;
		string _strAppName = "";

		public struct PostInfo
		{
			public string Title;
			public string Content;
			public string Url;
			public string AuthorName;
			public DateTime? Published;
			public List<string> Tags;
		}

		public BloggerManager(string clientId, string clientSec, string appName)
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
			_ucUser = BloggerHelper.createCredential(_csAppSec, _fdsStore);
			_bsBlogger = BloggerHelper.createService(_ucUser, _strAppName);
		}

		public void Logout()
		{
			_ucUser = null;
			_bsBlogger = null;
			_fdsStore.ClearAsync();
		}

		public List<Blog> ListAllBlogs()
		{
			return BloggerHelper.listAllBlogs(_bsBlogger);
		}

		public BlogPerUserInfo GetBlogUserInfo(string blogId)
		{
			return BloggerHelper.getBlogUserInfo(_bsBlogger, blogId);
		}

		public long? GetPageViews(string blogId)
		{
			return BloggerHelper.getPageViews(_bsBlogger, blogId, PageViewsResource.GetRequest.RangeEnum.All)[0].Count;
		}

		public List<Post> GetLivePosts(string blogId)
		{
			return BloggerHelper.getPostList(_bsBlogger, blogId, PostsResource.ListRequest.StatusEnum.Live);
		}

		public List<Post> GetDraftPosts(string blogId)
		{
			return BloggerHelper.getPostList(_bsBlogger, blogId, PostsResource.ListRequest.StatusEnum.Draft);
		}

		public BloggerManager.PostInfo GetPost(string blogId, string postId)
		{
			Post p = BloggerHelper.getPost(_bsBlogger, blogId, postId);
			PostInfo pi = new PostInfo();
			pi.AuthorName = p.Author.DisplayName;
			pi.Content = p.Content;
			pi.Published = p.Published;
			pi.Title = p.Title;
			pi.Url = p.Url;
			pi.Tags = p.Labels == null ? new List<string>() : p.Labels.ToList();
			return pi;
		}

	}
}
