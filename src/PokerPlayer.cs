using Nancy.Simple.BettingStrategies;
using Nancy.Simple.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace Nancy.Simple
{
	public static class PokerPlayer
	{
		public static readonly string VERSION = "KrumplisTeszta v0.3";

		public static int BetRequest(JObject rawGameState)
		{
            IBettingStrategy strategy = new ChenStrategy();

            GameState gameState = rawGameState.ToObject<GameState>();

            return strategy.PlaceBet(gameState);
		}

		public static void ShowDown(JObject gameState)  
		{
			//TODO: Use this method to showdown
		}
	}
}
