﻿/*
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
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public class Rank
	{
		[JsonProperty("nr")]
		public int NextRankId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("img_large")]
		public string ImageLarge { get; set; }

		[JsonProperty("img_medium")]
		public string ImageMedium { get; set; }

		[JsonProperty("img_small")]
		public string ImageSmall { get; set; }

		[JsonProperty("img_tiny")]
		public string ImageTiny { get; set; }
	}
}
