using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class VehicleCategory
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("time")]
		public double Time { get; set; }

		[JsonProperty("kills")]
		public int Kills { get; set; }

		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("img")]
		public string Image { get; set; }

		[JsonProperty("img_bk")]
		public string ImageBk { get; set; }

		[JsonProperty("unlocks")]
		public IList<Unlock> Unlocks { get; set; }

		[JsonProperty("star")]
		public Star Star { get; set; }
	}
}
