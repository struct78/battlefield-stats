/*
BF3Stats, provides a .NET implementation of Battlefield 3's statistics API.
Copyright (C) 2012 David Johnson

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

You can contact us at https://github.com/struct78/battlefield-stats.
*/
using System;
using System.Reflection;
using BF3Stats.Utilities;
using Newtonsoft.Json;

namespace BF3Stats.Converters
{
	public class RawValueConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return typeof(Enum).IsAssignableFrom(objectType);
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.String)
			{
				foreach (string name in Enum.GetNames(objectType))
				{
					//get the attributes of the member
					MemberInfo target = objectType.GetMember(name)[0];
					object[] attributes = target.GetCustomAttributes(false);

					foreach (object attribute in attributes)
					{
						RawValueAttribute rawValueAttribute;
						string readerValue = reader.Value.ToString();

						if ((rawValueAttribute = attribute as RawValueAttribute) != null && rawValueAttribute.RawValue == readerValue)
						{
							//serializer.Populate(reader, rawValueAttribute.RawValue);
							return Enum.Parse(objectType, name);
						}
					}
				}
			}

			throw new Exception("Could not match raw value");
		}
	}
}
