using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
			BloggerManager bh = new BloggerManager("1063292627846-cklckmk7efnioeli841r29q98n8tika4.apps.googleusercontent.com", "zIJi0yOm0d3v54oPsu2jvvkF", "gBloggerToJekyll");
			List<Blog> blogs = new List<Blog>();			

			Console.ReadKey();
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
			Blog blog = blogs[1];

			BlogPerUserInfo bpui = bh.GetBlogUserInfo(blog.Id);
			Console.WriteLine(bpui.UserId);
			Console.WriteLine(bpui.Role);
			
			
			//Kill if no admin
			if (bpui.HasAdminAccess == true)
			{
				ConvertManager cm = new ConvertManager("_converted", "_tmp");
				Console.WriteLine(bh.GetPageViews(blog.Id));
				//bh.GetLivePosts(blog.Id).ForEach(item => Console.WriteLine(item.Title + " " + item.Url));
				BloggerManager.PostInfo pi = new BloggerManager.PostInfo();
				bh.GetLivePosts(blog.Id).ForEach(delegate(Post item)
				{
					pi = bh.GetPost(blog.Id, item.Id);
					cm.SavePost(pi);
					Console.WriteLine(pi.Title);
				});

				//BloggerManager.PostInfo pi = bh.GetPost(blog.Id, bh.GetLivePosts(blog.Id)[0].Id);
				//pi.Tags.ForEach(item => Console.WriteLine(item));
				//ConvertManager bcm = new ConvertManager("_converted","_temp");
				//bcm.SavePost(pi);

				//bh.GetDraftPosts(blog.Id).ForEach(item => Console.WriteLine("* " + item.Title));
			}

			Console.ReadKey();
			//bh.Logout();
		}
	}
	
	class ConvertManager
	{
		string _strSaveFolderName;
		string _strSaveFolderTempName;
		public ConvertManager(string saveFolderName, string saveFolderTempName)
		{
			_strSaveFolderName = saveFolderName;
			_strSaveFolderTempName = saveFolderTempName;
			
		}

		public void SavePost(BloggerManager.PostInfo postInfo)
		{
			string filename = processFileName(postInfo.Url, postInfo.Published, ".md");
			
			string frontMatter = createPostFrontMatter(postInfo.Title, postInfo.AuthorName, postInfo.Tags);
			//string fmFilename = saveToFile(frontMatter, filename, ".fm", _strSaveFolderTempName);

			string content = postInfo.Content;
			string contentFilename = saveToFile(content, filename, ".content", _strSaveFolderTempName);

			content = convertPostContent(contentFilename);

			saveToFile(frontMatter + content, filename, "", _strSaveFolderName);
			//Directory.Delete(_strSaveFolderTempName, true);
		}
		
		private string saveToFile(string content, string filename, string extension, string folder)
		{
			if (!Directory.Exists(folder))
			{
				Directory.CreateDirectory(folder);
			}
			string savePath = folder +  @"\" + filename + extension;
			using (StreamWriter sw = new StreamWriter(savePath,false))
			{
				sw.Write(content);
				sw.Flush();
			};
			return savePath;
		}

		private string convertPostContent(string filename)
		{
			string processName = "html2text.exe";
			string processArgs = " \"" + filename + "\" -b 0";

			ProcessStartInfo psi = new ProcessStartInfo(processName, processArgs);
			psi.RedirectStandardOutput = true;

			Process proc = new Process();
			proc.StartInfo = psi;

			psi.UseShellExecute = false;
			proc.Start();

			string outputString = "";
			proc.WaitForExit(2000);
			using (StreamReader sr = new StreamReader(proc.StandardOutput.BaseStream))
			{
				outputString = sr.ReadToEnd();
			}
			return outputString;
		}

		private string processFileName(string postUrl, DateTime? date, string extension)
		{
			string postName = Path.GetFileNameWithoutExtension(new Uri(postUrl).AbsolutePath).Trim().ToLower();
			string postDate = date.HasValue ? date.Value.ToString("yyyy-MM-dd").Trim() : DateTime.Now.ToString("yyyy-MM-dd").Trim();
			string postFilename = postDate + "-" + postName + extension;
			return postFilename;
		}

		private string createPostFrontMatter(string Title, string AuthorName, List<string> Tags)
		{
			string tag = "---";
			string layout = "post";
			string title = escapeString(Title);
			string author = escapeString(AuthorName);
			string tags = "[" + string.Join(",", Tags.Select(item=>escapeString(item))) + "]";

			string[] frontMatter = {
									   tag,
									   joinFrontMatterPropValue("layout",layout),
									   joinFrontMatterPropValue("title",title),
									   joinFrontMatterPropValue("author",author),
									   joinFrontMatterPropValue("tags",tags),
									   tag,
									   Environment.NewLine
								   };
			return string.Join(Environment.NewLine, frontMatter);
		}

		private string joinFrontMatterPropValue(string property, string value)
		{
			return property + ": " + value;
		}

		private string escapeString(string str)
		{
			str = "'" + str.Replace("'", "''") + "'";
			return str;
		}
	}

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

		public BloggerManager(string clientId, string clientSec,string appName)
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
			pi.Tags = p.Labels == null? new List<string>() : p.Labels.ToList();
			return pi;
		}

	}

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
