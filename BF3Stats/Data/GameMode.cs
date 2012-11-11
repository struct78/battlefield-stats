using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class GameMode
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("losses")]
		public int Losses { get; set; }

		[JsonProperty("wins")]
		public int Wins { get; set; }
	}
}
