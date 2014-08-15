using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace gBloggerToJekyll
{
	static class LinkConversionHelper
	{
		public static void Save(List<gBloggerToJekyll.BloggerManager.PostInfo> postList)
		{
			serializeDict(convertListToDict(postList));
		}

		private static void serializeDict(Dictionary<string, DateTime?> dict)
		{
			string serialized = SerializeHelper.ToJson(dict);
			File.WriteAllText("gbtk-data.json", serialized);
		}

		private static Dictionary<string, DateTime?> convertListToDict(List<gBloggerToJekyll.BloggerManager.PostInfo> postList)
		{
			Dictionary<string, DateTime?> urlDate = new Dictionary<string, DateTime?>();
			postList.ForEach(item => urlDate.Add(item.Url.ToLower(), item.Published));
			return urlDate;
		}
	}
}
