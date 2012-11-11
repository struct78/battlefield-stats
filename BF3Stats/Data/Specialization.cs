using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class Specialization
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("desc")]
		public string Description { get; set; }

		[JsonProperty("img")]
		public string Image { get; set; }

		[JsonProperty("curr")]
		public int? Curr { get; set; }

		[JsonProperty("needed")]
		public int? Needed { get; set; }

		[JsonProperty("nname")]
		public string AlternateName { get; set; }
	}
}
