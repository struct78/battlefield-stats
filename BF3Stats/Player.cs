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
using System.Collections.Generic;
using BF3Stats.Converters;
using BF3Stats.Data;
using BF3Stats.Enums;
using Newtonsoft.Json;

namespace BF3Stats
{
	public sealed class Player
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("plat")]
		[JsonConverter(typeof(RawValueConverter))]
		public Platform Platform { get; set; }

		[JsonProperty("language")]
		public string Language { get; set; }

		[JsonProperty("status")]
		[JsonConverter(typeof(RawValueConverter))]
		public Status Status { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("country_img")]
		public string CountryImage { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("stats")]
		public Statistics Statistics { get; set; }

		[JsonProperty("tag")]
		// TODO check if this is a string or object
		public string Tag { get; set; }

		[JsonProperty("dogtags")]
		[JsonConverter(typeof(DictionaryToListConverter<DogTag>))]
		public IList<DogTag> Dogtags { get; set; }

		[JsonProperty("date_insert")]
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTime DateInserted { get; set; }

		[JsonProperty("date_update")]
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTime DateUpdated { get; set; }
	}
}
