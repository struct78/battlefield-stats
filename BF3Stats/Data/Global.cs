using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class Global
	{
		[JsonProperty("kills")]
		public int Kills { get; set; }

		[JsonProperty("deaths")]
		public int Deaths { get; set; }

		[JsonProperty("wins")]
		public int Wins { get; set; }

		[JsonProperty("losses")]
		public int Losses { get; set; }

		[JsonProperty("shots")]
		public int Shots { get; set; }

		[JsonProperty("hits")]
		public int Hits { get; set; }

		[JsonProperty("headshots")]
		public int Headshots { get; set; }

		[JsonProperty("longesths")]
		public double LongestHeadshot { get; set; }

		[JsonProperty("time")]
		public int Time { get; set; }

		[JsonProperty("vehicletime")]
		public double VehicleTime { get; set; }

		[JsonProperty("vehiclekills")]
		public int VehicleKills { get; set; }

		[JsonProperty("revives")]
		public int Revives { get; set; }

		[JsonProperty("killassists")]
		public double KillAssists { get; set; }

		[JsonProperty("resupplies")]
		public int Resupplies { get; set; }

		[JsonProperty("heals")]
		public double Heals { get; set; }

		[JsonProperty("repairs")]
		public double Repairs { get; set; }

		[JsonProperty("rounds")]
		public int Rounds { get; set; }

		[JsonProperty("elo")]
		public double ELO { get; set; }

		[JsonProperty("elo_games")]
		public int ELOGames { get; set; }

		[JsonProperty("killstreakbonus")]
		public int KillStreakBonus { get; set; }

		[JsonProperty("vehicledestroyassist")]
		public double VehicleDestroyAssist { get; set; }

		[JsonProperty("vehicledestroyed")]
		public int VehiclesDestroyed { get; set; }

		[JsonProperty("dogtags")]
		public int Dogtags { get; set; }

		[JsonProperty("avengerkills")]
		public int AvengerKills { get; set; }

		[JsonProperty("saviorkills")]
		public int SaviorKills { get; set; }

		[JsonProperty("damagaassists")]
		public int DamageAssists { get; set; }

		[JsonProperty("suppression")]
		public int Suppression { get; set; }

		[JsonProperty("nemesisstreak")]
		public int NemesisStreak { get; set; }

		[JsonProperty("nemesiskills")]
		public int NemesisKills { get; set; }

		[JsonProperty("mcomdest")]
		public int MComsDestroyed { get; set; }

		[JsonProperty("mcomdefkills")]
		public int MComsDefended { get; set; }

		[JsonProperty("flagcaps")]
		public int FlagsCaptured { get; set; }

		[JsonProperty("flagdef")]
		public int FlagsDefended { get; set; }

		[JsonProperty("longesthandhs")]
		public double LongestHandheldHeadshot { get; set; }
	}
}
