using System;

using Nancy.Simple.Model;

namespace Nancy.Simple.BettingStrategies
{
    public class RandomStrategy : IBettingStrategy
    {
        public int PlaceBet(GameState gameState)
        {
            var kocka = new Random();
            int bet = 50 + kocka.Next(10, 100);

            //Console.Error.WriteLine("Betting: {0}", bet);
            return bet;
        }
    }
}
