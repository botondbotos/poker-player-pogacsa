using Newtonsoft.Json.Linq;

using System;

namespace Nancy.Simple
{
	public static class PokerPlayer
	{
		public static readonly string VERSION = "Pogacsa v0.1";

		public static int BetRequest(JObject gameState)
		{
            var kocka = new Random();
            //int myPlayerIndex = (int)gameState["in_action"];
            //int myPlayer = (int)gameState["players"][myPlayerIndex];

            //Console.WriteLine("Teszt Elek");
            //var cardValue = RankingService.Rank();

			//TODO: Use this method to return the value You want to bet
            int bet = 100 + kocka.Next(10, 100);

            Console.Error.WriteLine("Betting: {0}", bet);
			return bet;
		}


		public static void ShowDown(JObject gameState)
		{
			//TODO: Use this method to showdown
		}
	}
}
