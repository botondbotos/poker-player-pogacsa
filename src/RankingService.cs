using Nancy.Simple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Simple
{
    class RankingService
    {
        private Dictionary<CardRank, int> Rank2Value = new Dictionary<CardRank, int>
        {
            {CardRank.One, 1},
            {CardRank.Two, 2},
            {CardRank.Three, 2},
            {CardRank.Four, 2},
            {CardRank.Five, 2},
            {CardRank.Six, 2},
            {CardRank.Seven, 2},
            {CardRank.Eight, 2},
            {CardRank.Nine, 2},
            {CardRank.Ten, 10},
            {CardRank.Jumbo, 11},
            {CardRank.Queen, 12},
            {CardRank.King, 13},
            {CardRank.Ace, 14}
        };

        private Dictionary<CardRank, double> Rank2Chen = new Dictionary<CardRank, double>
        {
            {CardRank.Two, 1},
            {CardRank.Three, 1.5},
            {CardRank.Four, 2},
            {CardRank.Five, 2.5},
            {CardRank.Six, 3},
            {CardRank.Seven, 3.5},
            {CardRank.Eight, 4},
            {CardRank.Nine, 4.5},
            {CardRank.Ten, 5},
            {CardRank.Jumbo, 6},
            {CardRank.Queen, 7},
            {CardRank.King, 8},
            {CardRank.Ace, 10},
        };

        private Dictionary<int, int> Gap2Minus = new Dictionary<int, int>
        {
            {0, 0},
            {1, 1},
            {2, 2},
            {3, 4}
        };

        
        public int GetChenRanking(List<Card> cards)
        {
            var ranks = cards.Select(card => card.Rank).ToList();
            var suits = cards.Select(card => card.Suit).ToList();
            var values = cards.Select(card => Rank2Value[card.Rank]).ToList();
            var chenValues = cards.Select(card => Rank2Chen[card.Rank]).ToList();

            double chen = chenValues.Max();


            bool isPair = values[0] == values[1];
            if (isPair)
            {
                var value = values[0];
                if (value < 5)
                    chen = 5;
                else if (value == 5)
                    chen = 6;
                else
                    chen *= 2;
            }

            bool sameSuits = suits[0] == suits[1];
            if (sameSuits)
                chen += 2;

            var maxValue = values.Max();
            var minValue = values.Min();
            int gap = maxValue - minValue;
            if (Gap2Minus.Keys.Contains(gap))
                chen -= Gap2Minus[gap];
            else if (gap >= 4)
                chen -= 5;

            if ((gap == 0 || gap == 1) && maxValue < Rank2Value[CardRank.Queen])
                chen += 1;

            chen = Math.Ceiling(chen);

            return (int)chen;
        }

    }
}
