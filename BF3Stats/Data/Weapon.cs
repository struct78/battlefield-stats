using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class Weapon
	{
		[JsonProperty("time")]
		public double Time { get; set; }

		[JsonProperty("kills")]
		public int Kills { get; set; }

		[JsonProperty("headshots")]
		public int Headshots { get; set; }

		[JsonProperty("hits")]
		public int Hits { get; set; }

		[JsonProperty("shots")]
		public int Shots { get; set; }

		[JsonProperty("star")]
		public Star Star { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("desc")]
		public string Description { get; set; }

		[JsonProperty("license")]
		public string License { get; set; }

		[JsonProperty("category")]
		public string Category { get; set; }

		[JsonProperty("kit")]
		public string Kit { get; set; }

		[JsonProperty("range")]
		public string Range { get; set; }

		[JsonProperty("fireModeAuto")]
		public bool FireModeAuto { get; set; }

		[JsonProperty("rateOfFire")]
		public string RateOfFire { get; set; }

		[JsonProperty("fireModeBurst")]
		public bool FireModeBurst { get; set; }

		[JsonProperty("fireModeSingle")]
		public bool FireModeSingle { get; set; }

		[JsonProperty("ammo")]
		public string Ammo { get; set; }

		[JsonProperty("img")]
		public string Image { get; set; }

		[JsonProperty("unlocks")]
		public IList<Unlock> Unlocks { get; set; }
	}
}
