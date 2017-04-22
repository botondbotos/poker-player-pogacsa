using Newtonsoft.Json.Linq;
using System;

namespace Nancy.Simple
{
	public static class PokerPlayer
	{
		public static readonly string VERSION = "Pogácsa poker bot";

		public static int BetRequest(JObject gameState)
		{
            int myPlayerIndex = (int)gameState["in_action"];
            int myPlayer = (int)gameState["players"][myPlayerIndex];

            Console.WriteLine("Teszt Elek");

			//TODO: Use this method to return the value You want to bet
			return 100;
		}

		public static void ShowDown(JObject gameState)
		{
			//TODO: Use this method to showdown
		}
	}
}

