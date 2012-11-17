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
using System.Collections.Generic;
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
