using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class Scores
	{
		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("award")]
		public int Award { get; set; }

		[JsonProperty("assault")]
		public int Assault { get; set; }

		[JsonProperty("bonus")]
		public int Bonus { get; set; }

		[JsonProperty("engineer")]
		public int Engineer { get; set; }

		[JsonProperty("general")]
		public int General { get; set; }

		[JsonProperty("objective")]
		public int Objective { get; set; }

		[JsonProperty("recon")]
		public int Recon { get; set; }

		[JsonProperty("squad")]
		public int Squad { get; set; }

		[JsonProperty("support")]
		public int Support { get; set; }

		[JsonProperty("team")]
		public int Team { get; set; }

		[JsonProperty("unlock")]
		public int Unlock { get; set; }

		[JsonProperty("vehicleaa")]
		public int VehicleAntiAir { get; set; }

		[JsonProperty("vehicleah")]
		public int VehicleAirHelicopterAttack { get; set; }

		[JsonProperty("vehicleall")]
		public int VehicleAll { get; set; }

		[JsonProperty("vehicleifv")]
		public int VehicleInfantryFightingVehicle { get; set; }

		[JsonProperty("vehiclejet")]
		public int VehicleJet { get; set; }

		[JsonProperty("vehiclembt")]
		public int VehicleMainBattleTanks { get; set; }

		[JsonProperty("vehiclesh")]
		public int VehicleHelicopterScout { get; set; }

		[JsonProperty("vehiclelbt")]
		public int VehicleTankDestroyers { get; set; }

		[JsonProperty("vehicleart")]
		public int VehicleMobileArtillery { get; set; }
	}
}
