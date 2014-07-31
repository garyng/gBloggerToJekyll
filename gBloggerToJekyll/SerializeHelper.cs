using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace gBloggerToJekyll
{
	public static class SerializeHelper
	{
		//From : http://www.jarloo.com/serialize-to-json/
		public static string ToJson<T>(this T obj)
		{
			MemoryStream ms = new MemoryStream();
			try
			{
				DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(T));
				dcjs.WriteObject(ms, obj);
				return Encoding.UTF8.GetString(ms.ToArray());
			}
			finally
			{
				ms.Close();
				ms.Dispose();
			}
		}

		public static T FromJson<T>(this string input)
		{
			MemoryStream ms = new MemoryStream();
			try
			{
				DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(T));
				ms = new MemoryStream(Encoding.UTF8.GetBytes(input));
				T obj = (T)dcjs.ReadObject(ms);
				return obj;
			}
			finally
			{
				ms.Close();
				ms.Dispose();
			}
		}
	}
}
