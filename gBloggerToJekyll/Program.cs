using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Blogger.v3;
using Google.Apis.Blogger.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace gBloggerToJekyll
{
	class Program
	{
		static BloggerManager bh = new BloggerManager("1063292627846-cklckmk7efnioeli841r29q98n8tika4.apps.googleusercontent.com", "zIJi0yOm0d3v54oPsu2jvvkF", "gBloggerToJekyll");

		enum UserOption
		{
			ContinueToNext,
			RemainInThisPage, 
			BackToPrevius,
			Exit
		}

		private static int promptUserSelect(int selectionMax)
		{
			Console.WriteLine();
			Console.Write("Please select: ");
			string input = Console.ReadLine();
			int selected;
			if (int.TryParse(input, out selected))
			{
				if (selected <= selectionMax && selected > 0)
				{
					return selected;
				}
				else
				{
					Console.WriteLine("Please enter a valid option");
					return -1;
				}
			}
			else
			{
				Console.WriteLine("Please input a number");
				return -1;
			}
		}

		private static void displayAnyKeyContinue()
		{
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}

		private static void menuExit(int num)
		{
			Console.WriteLine( num + ". Exit");
		}
		private static void menuBack(int num)
		{
			Console.WriteLine(num + ". Back");
		}
		private static void menuContinue(int num)
		{
			Console.WriteLine(num + ". Continue");
		}

		private static Program.UserOption login()
		{
			string[] dis = {
							   "1. Login",
							   "2. Logout",
						   };
			Console.WriteLine(string.Join(Environment.NewLine,dis));
			Console.WriteLine();
			menuExit(dis.Count() + 1);

			int selected = promptUserSelect(dis.Count() + 1);
			while (selected == -1)
			{
				selected = promptUserSelect(dis.Count() + 1);
			}
			
			switch (selected)
			{
				case 1:
					Console.WriteLine("Launching default internet browser to authorize application");
					bh.Login();
					Console.WriteLine("Authorized");
					displayAnyKeyContinue();
					return UserOption.ContinueToNext;
				case 2:
					Console.WriteLine("Logging out");
					bh.Logout();
					Console.WriteLine("Logged out");
					displayAnyKeyContinue();
					return UserOption.RemainInThisPage;
				default:
					Environment.Exit(-1);
					return UserOption.Exit;
			}

		}
		private static void stepLogin()
		{
			Console.Clear();
			UserOption uo = login();
			while (uo == UserOption.RemainInThisPage)
			{
				uo = login();
			}
			
		}

		private static Program.UserOption listBlogs(out Blog selectedBlog)
		{
			Console.WriteLine("Fetching available blogs");
			List<Blog> blogs = bh.ListAllBlogs();
			Console.Clear();
			for (int i = 0; i < blogs.Count; i++)
			{
				Console.WriteLine((i+1).ToString() + ". " + blogs[i].Name + " ( " + blogs[i].Id + " ) ");
			}
			Console.WriteLine();
			menuBack(blogs.Count + 1);
			int selected = promptUserSelect(blogs.Count + 1);
			while (selected == -1)
			{
				selected = promptUserSelect(blogs.Count + 1);
			}
			if (selected == (blogs.Count+ 1))
			{
				selectedBlog = null;
				return UserOption.BackToPrevius;
			}
			else
			{
				selectedBlog = blogs[selected - 1];
				return UserOption.ContinueToNext;
			}
		}
		private static Program.UserOption stepListBlogs(out Blog b)
		{
			Console.Clear();
			UserOption uo = listBlogs(out b);
			if (uo == UserOption.BackToPrevius)
			{
				return uo;
			}
			else
			{
				return UserOption.ContinueToNext;
			}
		}

		private static Program.UserOption getBlogUserInfo(Blog b)
		{
			Console.Clear();
			Console.WriteLine("Fetching blog user info");
			BlogPerUserInfo bpui = bh.GetBlogUserInfo(b.Id);
			string[] dis = {
							   "Blog Name: " + b.Name,
							   "Last Updated: " + b.Updated,
							   "Blog Published: " + b.Published,
							   "Blog Id: " + bpui.BlogId,
							   "User Id: " + bpui.UserId,
							   "Access Level: " + bpui.Role,
							   "Blog Link: " + b.Url,
							   bpui.HasAdminAccess.HasValue?(bpui.HasAdminAccess == true?(bh.GetPageViews(b.Id).HasValue?"Total Page Views: " + bh.GetPageViews(b.Id).ToString():""):""):"",
							   Environment.NewLine
						   };
			Console.Clear();
			Console.WriteLine(string.Join(Environment.NewLine,dis));
			if (bpui.HasAdminAccess == true)
			{
				menuContinue(1);
				menuBack(2);

				int selected = promptUserSelect(2);
				while (selected == -1)
				{
					selected = promptUserSelect(2);
				}
				switch (selected)
				{
					case 1:
						return UserOption.ContinueToNext;
					default:
						return UserOption.BackToPrevius;
				}
			}
			else
			{
				Console.WriteLine("You are not ADMIN of this blog");
				Console.WriteLine("Please select another blog");
				displayAnyKeyContinue();
				return UserOption.BackToPrevius;
			}
		}

		private static Program.UserOption fetchLivePost(Blog b, out List<BloggerManager.PostInfo> postList)
		{
			Console.Clear();

			Console.WriteLine("Fetching all live post in blog");

			List<BloggerManager.PostInfo> postInfoList = new List<BloggerManager.PostInfo>();
			bh.GetLivePosts(b.Id).ForEach(item=>postInfoList.Add(bh.GetPost(b.Id,item.Id)));

			Console.WriteLine("Fetched " + postInfoList.Count + " posts");

			Console.WriteLine("Saving post info to JSON data");
			LinkConversionHelper.Save(postInfoList);
			Console.Clear();

			Console.WriteLine("1. Convert all live post now ( total " + postInfoList.Count + " posts )");
			menuBack(2);

			int selected =  promptUserSelect(2);
			while (selected == -1)
			{
				selected = promptUserSelect(2);
			}
			switch (selected)
			{
				case 1:
					postList = postInfoList;
					return UserOption.ContinueToNext;
				default:
					postList = null;
					return UserOption.BackToPrevius;
			}
		}

		private static void directoryCleanUp(PostConverter pc)
		{
			if (pc.CleanUp(true) == true)
			{
				string[] dis = { 
								   "'_converted' and '_temp' folder still exsist",
								   "These folder need to be deleted before converting posts",
								   "Please backup your '_converted' folder that contain the converted posts if needed"
							   };
				Console.WriteLine(string.Join(Environment.NewLine, dis));
				displayAnyKeyContinue();
				pc.CleanUp(false);
			}
		}

		private static Program.UserOption convertLivePost(Blog b, List<BloggerManager.PostInfo> postInfoList)
		{
			Console.Clear();
			
			PostConverter pc = new PostConverter("_converted-" + b.Id, "_temp-" + b.Id);
			directoryCleanUp(pc);

			Console.Clear();
			Console.WriteLine("Converting posts");

			for (int i = 0; i < postInfoList.Count; i++)
			{
				Console.WriteLine("Saving \" " + postInfoList[i].Title + " \" ( " + (i + 1) + " of " + (postInfoList.Count + 1) + " )");
				pc.SavePost(postInfoList[i]);
				Console.CursorTop--;
				Console.WriteLine(new string(' ', Console.WindowWidth - 1));
				Console.CursorTop--;
			}
			Console.Clear();
			string[] dis = { 
							Environment.NewLine,
							 "Done converting " + postInfoList.Count + " posts",
							 "Converted posts save in folder '_converted-" + b.Id + "'",
							 "Raw post saved in folder '_temp-" + b.Id + "'",
							 Environment.NewLine,
							 "Waning: Some of the formatting in posts may not be converted correctly",
							 "such as code highlight, table and links",
							 "you may use the gBloggerToJekyll's  tool - link convertsion helper for helping you to convert links that link inside blog"
						 };
			Console.WriteLine(string.Join(Environment.NewLine,dis));
			menuBack(1);
			menuExit(2);
			int selected = promptUserSelect(2);
			while (selected == -1)
			{
				selected = promptUserSelect(2);
			}
			switch (selected)
			{
				case 1:
					return UserOption.BackToPrevius;
				default:
					Environment.Exit(-1);
					return UserOption.Exit;
			}
			
		}

		static void Main(string[] args)
		{
			List<Blog> blogs = new List<Blog>();
Login:
			stepLogin();
ListBlog:
			Blog selectedBlog;
			UserOption uo = stepListBlogs(out selectedBlog);
			if (uo == UserOption.BackToPrevius)
			{
				goto Login;
			}

			uo = getBlogUserInfo(selectedBlog);
			if (uo == UserOption.BackToPrevius)
			{
				goto ListBlog;
			}

			List<BloggerManager.PostInfo> postInfoList = new List<BloggerManager.PostInfo>();
			uo = fetchLivePost(selectedBlog, out postInfoList);
			if (uo == UserOption.BackToPrevius)
			{
				goto ListBlog;
			}

			uo = convertLivePost(selectedBlog, postInfoList);
			if (uo == UserOption.BackToPrevius)
			{
				goto ListBlog;
			}
		}

	}
}