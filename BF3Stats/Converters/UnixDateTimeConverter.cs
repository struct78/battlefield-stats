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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BF3Stats.Converters
{
	public class UnixDateTimeConverter : DateTimeConverterBase
	{
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
			JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				return null;
			}

			if (reader.TokenType != JsonToken.Integer)
			{
				throw new Exception(
					String.Format("Unexpected token parsing date. Expected Integer, got {0}.",
					reader.TokenType));
			}

			var ticks = (long) reader.Value;

			var date = new DateTime(1970, 1, 1);
			date = date.AddSeconds(ticks);

			return date;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			long ticks;
			if (value is DateTime)
			{
				var epoc = new DateTime(1970, 1, 1);
				var delta = ((DateTime)value) - epoc;
				if (delta.TotalSeconds < 0)
				{
					throw new ArgumentOutOfRangeException("Unix epoc starts January 1st, 1970");
				}
				ticks = (long)delta.TotalSeconds;
			}
			else
			{
				throw new Exception("Expected date object value.");
			}
			writer.WriteValue(ticks);
		}
	}
}
