using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class Teams
	{
		[JsonProperty("RU")]
		public Team RU { get; set; }

		[JsonProperty("US")]
		public Team US { get; set; }
	}

	public class Team
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("headshots")]
        public int Headshots { get; set; }

        [JsonProperty("shots")]
        public int Shots { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }
    }
}
