using Nancy.Simple.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace Nancy.Simple
{
	public static class PokerPlayer
	{
		public static readonly string VERSION = "KrumplisTeszta v0.2";

		public static int BetRequest(JObject rawGameState)
		{
            var rankingService = new RankingService();
            int bet = 0;
            
            try {

                GameState gameState = rawGameState.ToObject<GameState>();

                var myself = gameState.players[gameState.in_action];
                var handCards = gameState.players[gameState.in_action].hole_cards;

                int chenValue = rankingService.GetChenRanking(handCards);

                int callAmount = gameState.current_buy_in - myself.bet + gameState.minimum_raise;
                int allInAmount = myself.stack;
                int activePlayerCount = gameState.players.Count(player => player.status == "active");

                bool inPreflop = gameState.community_cards.Count == 0;

                if (inPreflop)
                {
                    if (chenValue >= 7)
                    {
                        return Math.Min(callAmount, (int)allInAmount / 2);
                    }

                    return 0;
                }

                bet = 100 + new Random().Next(10, 100);

                return bet;
                
            }
            catch (Exception e)
            {
                //Console.Error.WriteLine("raw game state: {0}", rawGameState.ToString());

                Console.Error.WriteLine("Error converting JSON {0}", e.Message);
                Console.Error.WriteLine("Stack trace: {0}", e.StackTrace);
            }

            return 0;


		}


		public static void ShowDown(JObject gameState)  
		{
			//TODO: Use this method to showdown
		}
	}
}
