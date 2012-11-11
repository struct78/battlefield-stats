﻿/*
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
	public sealed class Coop
	{
		[JsonProperty("avengerkills")]
		public int AvengerKills { get; set; }

		[JsonProperty("headshots")]
		public int Headshots { get; set; }

		[JsonProperty("indscore")]
		public long IndividualScore { get; set; }

		[JsonProperty("killassists")]
		public int KillAssists { get; set; }

		[JsonProperty("kills")]
		public int Kills { get; set; }

		[JsonProperty("mdrevives")]
		public int Revives { get; set; }

		[JsonProperty("rank")]
		public int Rank { get; set; }

		[JsonProperty("saviorkills")]
		public int SaviorKills { get; set; }

		[JsonProperty("score")]
		public long Score { get; set; }

		[JsonProperty("spotassists")]
		public int SpotAssists { get; set; }

		[JsonProperty("vehiclesdestroyed")]
		public int VehiclesDestroyed { get; set; }
	}
}
