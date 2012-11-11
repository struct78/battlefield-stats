using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace BF3Stats.Converters
{
	public class DictionaryToListConverter<T> : CustomCreationConverter<T> where T : class, new()
	{
		public override T Create(Type objectType)
		{
			return new T();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jObject = JObject.Load(reader);
			var list = new List<T>();

			foreach(var key in jObject)
			{
				var obj = JsonConvert.DeserializeObject<T>(key.Value.ToString());
				list.Add(obj);
			}

			return list;
		}
	}
}
