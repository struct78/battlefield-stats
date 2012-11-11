using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BF3Stats;
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
