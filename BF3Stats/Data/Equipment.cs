using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class Equipment
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("time")]
		public double Time { get; set; }

		[JsonProperty("kills")]
		public int Kills { get; set; }

		[JsonProperty("headshots")]
		public int Headshots { get; set; }

		[JsonProperty("shots")]
		public int Shots { get; set; }

		[JsonProperty("unlock")]
		public Unlock Unlock { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("spots")]
		public string Spots { get; set; }

		[JsonProperty("revives")]
		public string Revives { get; set; }

		[JsonProperty("spawns")]
		public string Spawns { get; set; }

		[JsonProperty("desc")]
		public string Description { get; set; }

		[JsonProperty("kit")]
		public string Kit { get; set; }

		[JsonProperty("img")]
		public string Image { get; set; }
	}
}
