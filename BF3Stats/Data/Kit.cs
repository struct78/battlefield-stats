using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class Kits
	{
		[JsonProperty("assault")]
		public ExpandedKit Assault { get; set; }

		[JsonProperty("engineer")]
		public ExpandedKit Engineer { get; set; }

		[JsonProperty("general")]
		public Kit General { get; set; }

		[JsonProperty("Recon")]
		public ExpandedKit Recon { get; set; }

		[JsonProperty("Support")]
		public ExpandedKit Support { get; set; }

		[JsonProperty("vehicle")]
		public Kit Vehicle { get; set; }
	}

	public sealed class ExpandedKit : Kit
	{
		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("time")]
		public double Time { get; set; }

		[JsonProperty("timer")]
		public double Timer { get; set; }

		[JsonProperty("timeu")]
		// TODO Find out what this property is for
		public double TimeU { get; set; }

		[JsonProperty("star")]
		public Star Star { get; set; }
	}

	public class Kit
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("img")]
		public string Image { get; set; }

		[JsonProperty("img_bk")]
		// TODO check these images
		public string ImageBk { get; set; }

		[JsonProperty("unlocks")]
		public IList<Unlock> Unlocks { get; set; }
	}
}
