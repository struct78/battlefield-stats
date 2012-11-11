using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class Star
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("date")]
		public DateTime? Date { get; set; }

		[JsonProperty("current")]
		public int Curr { get; set; }

		[JsonProperty("needed")]
		public int Needed { get; set; }

		[JsonProperty("nname")]
		public string AlternateName { get; set; }

		[JsonProperty("img")]
		public string Image { get; set; }
	}
}
