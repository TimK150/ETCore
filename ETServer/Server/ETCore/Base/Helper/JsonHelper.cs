using System;
//using System.Text.Json;
namespace ET
{
	public static class JsonHelper
	{
        //public static string ToJson(object obj)
        //      {
        //	return JsonSerializer.Serialize(obj);
        //      }

        //      public static T FromJson<T>(string str)
        //{
        //	return JsonSerializer.Deserialize<T>(str);
        //}

        public static string ToJson(object obj)
        {
            return MongoHelper.ToJson(obj);
        }

        public static T FromJson<T>(string str)
        {
            return MongoHelper.FromJson<T>(str);
        }

        public static T Clone<T>(T t)
		{
			return FromJson<T>(ToJson(t));
		}
	}
}