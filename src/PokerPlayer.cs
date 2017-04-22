using Nancy.Simple.Model;
using Newtonsoft.Json.Linq;
using System;

namespace Nancy.Simple
{
	public static class PokerPlayer
	{
		public static readonly string VERSION = "Pogacsa v0.1";

		public static int BetRequest(JObject rawGameState)
		{
            try
            {
                GameState gameState = rawGameState.ToObject<GameState>();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error converting JSON {0}", e.Message);
            }


            //int myPlayerIndex = (int)gameState["in_action"];
            //int myPlayer = (int)gameState["players"][myPlayerIndex];

            //Console.WriteLine("Teszt Elek");
            //var cardValue = RankingService.Rank();

            var kocka = new Random();
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
