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
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class Kits
	{
		[JsonProperty("assault")]
		public ExpandedKit Assault { get; set; }

		[JsonProperty("engineer")]
		public ExpandedKit Engineer { get; set; }

		[JsonProperty("general")]
		public Kit General { get; set; }

		[JsonProperty("Recon")]
		public ExpandedKit Recon { get; set; }

		[JsonProperty("Support")]
		public ExpandedKit Support { get; set; }

		[JsonProperty("vehicle")]
		public Kit Vehicle { get; set; }
	}

	public sealed class ExpandedKit : Kit
	{
		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("time")]
		public double Time { get; set; }

		[JsonProperty("timer")]
		public double Timer { get; set; }

		[JsonProperty("timeu")]
		// TODO Find out what this property is for
		public double TimeU { get; set; }

		[JsonProperty("star")]
		public Star Star { get; set; }
	}

	public class Kit
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("img")]
		public string Image { get; set; }

		[JsonProperty("img_bk")]
		// TODO check these images
		public string ImageBk { get; set; }

		[JsonProperty("unlocks")]
		public IList<Unlock> Unlocks { get; set; }
	}
}
