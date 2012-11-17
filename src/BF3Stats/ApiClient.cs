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
using System.IO;
using BF3Stats.Enums;
using BF3Stats.Utilities;
using Hammock;
using Hammock.Web;
using Newtonsoft.Json;

namespace BF3Stats
{
	public delegate void OnGetPlayerStatsComplete(Player player);

	public class ApiClient
	{
		private const string Uri = "http://api.bf3stats.com/";
		private const string UserAgent = "BF3StatsAPI/0.1";

		public Platform Platform { get; set; }
		public string Username { get; set; }
		public event OnGetPlayerStatsComplete GetPlayerStatsComplete;

		public ApiClient()
		{
		}

		public ApiClient(Platform platform, string username)
		{
			Platform = platform;
			Username = username;
		}

		internal RestClient CreateClient()
		{
			RestClient client = new RestClient
			                    	{
			                    		Authority = Uri,
										UserAgent = UserAgent
			                    	};
			return client;
		}

		internal RestRequest CreateRequest(string action)
		{
			System.Net.ServicePointManager.Expect100Continue = false;

			RestRequest request = new RestRequest
			                      	{
										Path = Path.Combine(typeof(Platform).GetRawValue(Platform), action) + "/",
			                      		Method = WebMethod.Post
			                      	};

			return request;
		}

		public void GetPlayerStats()
		{
			GetPlayerStats(PlayerOptionsPreset.All);
		}

		public void GetPlayerStats(PlayerOptionsPreset preset)
		{
			if (!Enum.IsDefined(typeof(Platform), Platform))
				throw new Exception("Platform cannot be empty");

			if (string.IsNullOrEmpty(Username))
				throw new Exception("Username cannot be empty");

			if (!Enum.IsDefined(typeof(PlayerOptionsPreset), preset))
				throw new Exception("Preset cannot be empty");

			RestClient client = CreateClient();
			RestRequest request = CreateRequest("player");
			request.AddParameter("player", Username);
			request.AddParameter("opt", typeof(PlayerOptionsPreset).GetRawValue(preset));
			//client.Request(request);
			client.BeginRequest(request, new RestCallback(RestRequestComplete));
		}

		public virtual void RestRequestComplete(RestRequest request, RestResponse response, object userState)
		{
			var player = JsonConvert.DeserializeObject<Player>(response.Content);
			GetPlayerStatsComplete(player);
		}
	}
}
 