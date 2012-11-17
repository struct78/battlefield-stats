# BF3Stats

BF3Stats is a .NET wrapper for the Battlefield 3 statistics API on api.bf3stats.com.

## Usage
	
	ApiClient target = new ApiClient
		{
			Username = "Username",
			Platform = Platform.Xbox360
		};
	target.GetPlayerStats();
	target.GetPlayerStatsComplete += delegate(Player p)
		{
			player = p;
		};