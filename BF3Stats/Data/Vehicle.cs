using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class Vehicle
	{
		[JsonProperty("time")]
		public double Time { get; set; }

		[JsonProperty("kills")]
		public int Kills { get; set; }

		[JsonProperty("destroys")]
		public int Destroys { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("desc")]
		public string Desc { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("category")]
		public string Category { get; set; }

		[JsonProperty("img")]
		public string Image { get; set; }
	}
}
