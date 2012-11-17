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
using System;
using System.Collections.Generic;
using BF3Stats.Converters;
using Newtonsoft.Json;

namespace BF3Stats.Data
{
	public sealed class Statistics
	{
		[JsonProperty("coop")]
		public Coop Coop { get; set; }

		[JsonProperty("coopmissions")]
		[JsonConverter(typeof(DictionaryToListConverter<CoopMission>))]
		public IList<CoopMission> CoopMissions { get; set; }

		[JsonProperty("equipment")]
		[JsonConverter(typeof(DictionaryToListConverter<Equipment>))]
		public IList<Equipment> Equipment { get; set; }

		[JsonProperty("gamemodes")]
		[JsonConverter(typeof(DictionaryToListConverter<GameMode>))]
		public IList<GameMode> GameModes { get; set; }

		[JsonProperty("global")]
		public Global Global { get; set; }

		[JsonProperty("kits")]
		public Kits Kits { get; set; }

		[JsonProperty("medals")]
		[JsonConverter(typeof(DictionaryToListConverter<Medal>))]
		public IList<Medal> Medals { get; set; }

		[JsonProperty("nextranks")]
		public IList<NextRank> NextRanks { get; set; }

		[JsonProperty("rank")]
		public Rank Rank { get; set; }

		[JsonProperty("ribbons")]
		[JsonConverter(typeof(DictionaryToListConverter<Ribbon>))]
		public IList<Ribbon> Ribbons { get; set; }

		[JsonProperty("scores")]
		public Scores Scores { get; set; }

		[JsonProperty("specializations")]
		[JsonConverter(typeof(DictionaryToListConverter<Specialization>))]
		public IList<Specialization> Specializations { get; set; }

		[JsonProperty("teams")]
		public Teams Teams { get; set; }

		[JsonProperty("vehcats")]
		[JsonConverter(typeof(DictionaryToListConverter<VehicleCategory>))]
		public IList<VehicleCategory> VehicleCategories { get; set; }

		[JsonProperty("vehicles")]
		[JsonConverter(typeof(DictionaryToListConverter<Vehicle>))]
		public IList<Vehicle> Vehicles { get; set; }

		[JsonProperty("weapons")]
		[JsonConverter(typeof(DictionaryToListConverter<Weapon>))]
		public IList<Weapon> Weapons { get; set; }

		[JsonProperty("date_check")]
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTime DateCheck { get; set; }

		[JsonProperty("date_insert")]
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTime DateInsert { get; set; }

		[JsonProperty("date_update")]
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTime DateUpdate { get; set; }
	}
}
