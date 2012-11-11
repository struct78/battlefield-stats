/*
BF3Stats, provides a .NET implementation of Battlefield 3's statistics API.
Copyright (C) 2012 David Johnson

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

You can contact us at https://github.com/struct78/battlefield-stats.
*/
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
