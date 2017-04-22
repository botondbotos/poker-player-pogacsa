using System;
using System.Linq;
using Nancy.Simple.Model;
using System.Collections.Generic;

namespace Nancy.Simple.BettingStrategies
{
    public class ChenStrategy : IBettingStrategy
    {
        public enum Rank
        {
            None,
            OnePair,
            TwoPairs,
            Drill,
            Poker
        }

        public int PlaceBet(GameState gameState)
        {
            var rankingService = new RankingService();
            int bet = 0;

            var myself = gameState.players[gameState.in_action];
            var moneyLeft = myself.stack;
            var handCards = gameState.players[gameState.in_action].hole_cards;

            int chenValue = rankingService.GetChenRanking(handCards);

            int callAmount = gameState.current_buy_in - myself.bet + gameState.minimum_raise;
            int allInAmount = myself.stack;
            int activePlayerCount = gameState.players.Count(player => player.status == "active");

            bool inPreflop = gameState.community_cards.Count == 0;

            #region Pre-flop strategy
            if (inPreflop)
            {
                if (chenValue >= 7)
                {
                    return Math.Min(callAmount, (int)allInAmount / 2);
                }

                if (handCards[0].Rank == handCards[1].Rank)
                    return Math.Min(callAmount, (int)(moneyLeft / 4));

                return 0;
            }
            #endregion

            Rank rank = this.GetRank(handCards.Union(gameState.community_cards).ToList());

            if (rank == Rank.None)
                bet = 10 + new Random().Next(10, 20);
            else if (rank == Rank.OnePair)
                bet = 50;
            else if (rank == Rank.TwoPairs)
                bet = Math.Min(callAmount, (int)moneyLeft / 4);
            else
                bet = allInAmount;


            return bet;
            
        }

        public Rank GetRank(List<Card> cards) {
            var ranks = cards.Select(card => card.Rank).ToList();
            var suits = cards.Select(card => card.Suit).ToList();
            var values = cards.Select(card => RankingService.Rank2Value[card.Rank]).ToList();

            var valueFrequency = new Dictionary<int, int>();


            foreach (int value in values)
            {
                if (!valueFrequency.ContainsKey(value))
                    valueFrequency[value] = 1;
                else
                    valueFrequency[value] += 1;
            }

            if (valueFrequency.ContainsValue(4))
                return Rank.Poker;

            if (valueFrequency.ContainsValue(3))
                return Rank.Drill;

            if (valueFrequency.Values.Count(item => item == 2) == 2)
                return Rank.TwoPairs;

            if (valueFrequency.ContainsValue(2))
                return Rank.OnePair;

            return Rank.None;
        }
    }
}
