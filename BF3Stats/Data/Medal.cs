using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BF3Stats.Converters;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class Medal
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("date")]
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTime? Date { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("curr")]
		public double Current { get; set; }

		[JsonProperty("needed")]
		public int Needed { get; set; }

		[JsonProperty("nname")]
		public string AlternateName { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("desc")]
		public string Description { get; set; }

		[JsonProperty("img_large")]
		public string ImageLarge { get; set; }

		[JsonProperty("img_medium")]
		public string ImageMedium { get; set; }

		[JsonProperty("img_small")]
		public string ImageSmall { get; set; }
	}
}
