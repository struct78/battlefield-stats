using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class NextRank : Rank
	{
		[JsonProperty("left")]
		public int Left { get; set; }
	}
}
