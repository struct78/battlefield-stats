using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
