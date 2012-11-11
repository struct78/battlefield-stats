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

namespace BF3Stats.Utilities
{
	public sealed class PlayerOptions
	{
		[JsonProperty("scores")]
		private bool _scores = true;
		public bool Scores { get { return _scores; } set { _scores = value; } }

		[JsonProperty("global")]
		private bool _global = true;
		public bool Global { get { return _global; } set { _global = value; } }

		[JsonProperty("nextranks")]
		private bool _nextRanks;
		public bool NextRanks { get { return _nextRanks; } set { _nextRanks = value; } }

		[JsonProperty("rank")]
		private bool _rank = true;
		public bool Rank { get { return _rank; } set { _rank = value; } }

		[JsonProperty("imgInfo")]
		private bool _imgInfo;
		public bool ImgInfo { get { return _imgInfo; } set { _imgInfo = value; } }

		[JsonProperty("lastseen")]
		private bool _lastSeen;
		public bool LastSeen { get { return _lastSeen; } set { _lastSeen = value; } }

		[JsonProperty("")]
		private bool _urls;
		public bool Urls { get { return _urls; } set { _urls = value; } }

		[JsonProperty("keys")]
		private bool _keys;
		public bool Keys { get { return _keys; } set { _keys = value; } }

		[JsonProperty("raw")]
		private bool _raw;
		public bool Raw { get { return _raw; } set { _raw = value; } }

		[JsonProperty("nozero")]
		private bool _noZero;
		public bool NoZero { get { return _noZero; } set { _noZero = value; } }

		[JsonProperty("dogtags")]
		private bool _dogTags = true;
		public bool DogTags { get { return _dogTags; } set { _dogTags = value; } }

		[JsonProperty("coop")]
		private bool _coop = true;
		public bool Coop { get { return _coop; } set { _coop = value; } }

		[JsonProperty("coopInfo")]
		private bool _coopInfo = true;
		public bool CoopInfo { get { return _coopInfo; } set { _coopInfo = value; } }

		[JsonProperty("coopMissions")]
		private bool _coopMissions = true;
		public bool CoopMissions { get { return _coopMissions; } set { _coopMissions = value; } }

		[JsonProperty("gamesModes")]
		private bool _gamesModes = true;
		public bool GamesModes {  get { return _gamesModes; } set { _gamesModes = value; }  }

		[JsonProperty("gamesModesInfo")]
		private bool _gamesModesInfo = true;
		public bool GamesModesInfo { get { return _gamesModesInfo; } set { _gamesModesInfo = value; } }

		[JsonProperty("weapons")]
		private bool _weapons = true;
		public bool Weapons { get { return _weapons; } set { _weapons = value; } }

		[JsonProperty("weaponsName")]
		private bool _weaponsName = true;
		public bool WeaponsName { get { return _weaponsName; } set { _weaponsName = value; } }

		[JsonProperty("weaponsInfo")]
		private bool _weaponsInfo = true;
		public bool WeaponsInfo { get { return _weaponsInfo; } set { _weaponsInfo = value; } }

		[JsonProperty("weaponsOnlyUsed")]
		private bool _weaponsOnlyUsed;
		public bool WeaponsOnlyUsed { get { return _weaponsOnlyUsed; } set { _weaponsOnlyUsed = value; } }

		[JsonProperty("weaponsUnlocks")]
		private bool _weaponsUnlocks = true;
		public bool WeaponsUnlocks { get { return _weaponsUnlocks; } set { _weaponsUnlocks = value; } }

		[JsonProperty("weaponsRanking")]
		private bool _weaponsRanking = true;
		public bool WeaponsRanking { get { return _weaponsRanking; } set { _weaponsRanking = value; } }

		[JsonProperty("weaponsStars")]
		private bool _weaponsStars = true;
		public bool WeaponsStars { get { return _weaponsStars; } set { _weaponsStars = value; } }

		[JsonProperty("equipment")]
		private bool _equipment = true;
		public bool Equipment { get { return _equipment; } set { _equipment = value; } }

		[JsonProperty("equipmentName")]
		private bool _equipmentName = true;
		public bool EquipmentName { get { return _equipmentName; } set { _equipmentName = value; } }

		[JsonProperty("equipmentInfo")]
		private bool _equipmentInfo = true;
		public bool EquipmentInfo { get { return _equipmentInfo; } set { _equipmentInfo = value; } }

		[JsonProperty("equipmentRanking")]
		private bool _equipmentRanking = true;
		public bool EquipmentRanking { get { return _equipmentRanking; } set { _equipmentRanking = value; } }

		[JsonProperty("equipmentOnlyUsed")]
		private bool _equipmentOnlyUsed;
		public bool EquipmentOnlyUsed { get { return _equipmentOnlyUsed; } set { _equipmentOnlyUsed = value; } }

		[JsonProperty("specializations")]
		private bool _specializations = true;
		public bool Specializations { get { return _specializations; } set { _specializations = value; } }

		[JsonProperty("specializationsName")]
		private bool _specializationsName = true;
		public bool SpecializationsName { get { return _specializationsName; } set { _specializationsName = value; } }

		[JsonProperty("specializationsInfo")]
		private bool _specializationsInfo = true;
		public bool SpecializationsInfo { get { return _specializationsInfo; } set { _specializationsInfo = value; } }

		[JsonProperty("teams")]
		private bool _teams = true;
		public bool Teams { get { return _teams; } set { _teams = value; } }

		[JsonProperty("kits")]
		private bool _kits = true;
		public bool Kits { get { return _kits; } set { _kits = value; } }

		[JsonProperty("kitsName")]
		private bool _kitsName = true;
		public bool KitsName { get { return _kitsName; } set { _kitsName = value; } }

		[JsonProperty("kitsInfo")]
		private bool _kitsInfo = true;
		public bool KitsInfo { get { return _kitsInfo; } set { _kitsInfo = value; } }

		[JsonProperty("kitsStars")]
		private bool _kitsStars = true;
		public bool KitsStars { get { return _kitsStars; } set { _kitsStars = value; } }

		[JsonProperty("kitsUnlocks")]
		private bool _kitsUnlocks = true;
		public bool KitsUnlocks { get { return _kitsUnlocks; } set { _kitsUnlocks = value; } }

		[JsonProperty("vehicles")]
		private bool _vehicles = true;
		public bool Vehicles { get { return _vehicles; } set { _vehicles = value; } }

		[JsonProperty("vehiclesName")]
		private bool _vehiclesName = true;
		public bool VehiclesName { get { return _vehiclesName; } set { _vehiclesName = value; } }

		[JsonProperty("vehiclesInfo")]
		private bool _vehiclesInfo = true;
		public bool VehiclesInfo { get { return _vehiclesInfo; } set { _vehiclesInfo = value; } }

		[JsonProperty("vehiclesRanking")]
		private bool _vehiclesRanking = true;
		public bool VehiclesRanking { get { return _vehiclesRanking; } set { _vehiclesRanking = value; } }

		[JsonProperty("vehiclesOnlyUsed")]
		private bool _vehiclesOnlyUsed;
		public bool VehiclesOnlyUsed { get { return _vehiclesOnlyUsed; } set { _vehiclesOnlyUsed = value; } }

		[JsonProperty("vehCats")]
		private bool _vehCats = true;
		public bool VehCats { get { return _vehCats; } set { _vehCats = value; } }

		[JsonProperty("vehCatsStars")]
		private bool _vehCatsStars = true;
		public bool VehCatsStars { get { return _vehCatsStars; } set { _vehCatsStars = value; } }

		[JsonProperty("vehCatsUnlocks")]
		private bool _vehCatsUnlocks = true;
		public bool VehCatsUnlocks { get { return _vehCatsUnlocks; } set { _vehCatsUnlocks = value; } }

		[JsonProperty("vehCatsGroup")]
		private bool _vehCatsGroup;
		public bool VehCatsGroup { get { return _vehCatsGroup; } set { _vehCatsGroup = value; } }

		[JsonProperty("vehCatsInfo")]
		private bool _vehCatsInfo = true;
		public bool VehCatsInfo { get { return _vehCatsInfo; } set { _vehCatsInfo = value; } }

		[JsonProperty("awards")]
		private bool _awards = true;
		public bool Awards { get { return _awards; } set { _awards = value; } }

		[JsonProperty("awardsName")]
		private bool _awardsName = true;
		public bool AwardsName { get { return _awardsName; } set { _awardsName = value; } }

		[JsonProperty("awardsInfo")]
		private bool _awardsInfo = true;
		public bool AwardsInfo { get { return _awardsInfo; } set { _awardsInfo = value; } }

		[JsonProperty("awardsAwarded")]
		private bool _awardsAwarded;
		public bool AwardsAwarded { get { return _awardsAwarded; } set { _awardsAwarded = value; } }

		[JsonProperty("ranking")]
		private bool _ranking;
		public bool Ranking { get { return _ranking; } set { _ranking = value; } }

		[JsonProperty("rankingInfo")]
		private bool _rankingInfo = true;
		public bool RankingInfo { get { return _rankingInfo; } set { _rankingInfo = value; } }

		[JsonProperty("assignments")]
		private bool _assignments;
		public bool Assignments { get { return _assignments; } set { _assignments = value; } }

		[JsonProperty("assignmentsInfo")]
		private bool _assignmentsInfo = true;
		public bool AssignmentsInfo { get { return _assignmentsInfo; } set { _assignmentsInfo = value; } }

		[JsonProperty("assignmentsName")]
		private bool _assignmentsName = true;
		public bool AssignmentsName { get { return _assignmentsName; } set { _assignmentsName = value; } }
	}
}
