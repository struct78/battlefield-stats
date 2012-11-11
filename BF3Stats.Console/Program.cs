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
using BF3Stats.Enums;

namespace BF3Stats.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			Player player = null;

			ApiClient target = new ApiClient
				                {
				                   	Username = "struct78",
				                   	Platform = Platform.Xbox360
				                };
			target.GetPlayerStats();
			target.GetPlayerStatsComplete += delegate(Player p)
				                                {
				                                 	player = p;
				                                 	System.Console.Write(player.Statistics.CoopMissions.Count);
				                                 	System.Console.Write(" coop missions found");
				                                };

			System.Console.Write("Loading...");
			System.Console.ReadKey();
		}
	}
}
