using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace gBloggerToJekyll
{
	class PostConverter
	{
		string _strSaveFolderName;
		string _strSaveFolderTempName;

		enum Converter
		{
			html2text,
			pandoc
		}

		public PostConverter(string saveFolderName, string saveFolderTempName)
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

			content = convertPostContent(contentFilename, Converter.pandoc);

			saveToFile(frontMatter + content, filename, "", _strSaveFolderName);
			//Directory.Delete(_strSaveFolderTempName, true);
		}

		public bool? CleanUp(bool check)
		{
			if (check)
			{
				return deleteFolder(_strSaveFolderTempName, true) | deleteFolder(_strSaveFolderName, true);
			}
			else
			{
				deleteFolder(_strSaveFolderTempName,false);
				deleteFolder(_strSaveFolderName, false);
			}
			return null;

		}

		private bool? deleteFolder(string folder, bool check)
		{
			if (check)
			{
				return Directory.Exists(folder);
			}
			else
			{
				if (Directory.Exists(folder))
				{
					Directory.Delete(folder);
				}
			}
			return null;
		}

		private string saveToFile(string content, string filename, string extension, string folder)
		{
			if (!Directory.Exists(folder))
			{
				Directory.CreateDirectory(folder);
			}
			string savePath = folder + @"\" + filename + extension;
			using (StreamWriter sw = new StreamWriter(savePath, false))
			{
				sw.Write(content);
				sw.Flush();
			};
			return savePath;
		}

		private string convertPostContent(string filename, Converter converter)
		{
			string processName = "";
			string processArgs = "";

			if (converter == Converter.pandoc)
			{
				string[] pandocExtension = {
												   "backtick_code_blocks",
												   "auto_identifiers",
												   "autolink_bare_uris",
											   };
				processName = "pandoc.exe";
				processArgs = "-f html -t markdown_strict+" + string.Join("+", pandocExtension) + " --atx-headers \"" + filename + "\"";
			}
			else if (converter == Converter.html2text)
			{
				processName = "html2text.exe";
				processArgs = " \"" + filename + "\" -b 0";
			}

			return redirectPipeOutput(processName, processArgs);
		}

		private string redirectPipeOutput(string processName, string processArgs)
		{
			ProcessStartInfo psi = new ProcessStartInfo(processName, processArgs);
			psi.RedirectStandardOutput = true;

			Process proc = new Process() { StartInfo = psi };

			psi.UseShellExecute = false;
			proc.Start();

			string outputString = "";
			proc.WaitForExit(5000);
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
			string tags = "[" + string.Join(",", Tags.Select(item => escapeString(item))) + "]";

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
}
