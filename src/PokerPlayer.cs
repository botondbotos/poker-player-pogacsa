using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{
	public static class PokerPlayer
	{
		public static readonly string VERSION = "Pogácsa poker bot";

		public static int BetRequest(JObject gameState)
		{
            int currentPlayer = (int)gameState["in_action"];

			//TODO: Use this method to return the value You want to bet
			return 100;
		}

		public static void ShowDown(JObject gameState)
		{
			//TODO: Use this method to showdown
		}
	}
}

