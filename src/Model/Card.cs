using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Simple.Model
{
    public enum CardSuite
    {
        Diamonds, Clubs, Hearts, Spades
    }

    public enum CardRank
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jumbo = 11,
        Quen = 12,
        King = 13,
        Ace = 14
    }

    public class Card
    {
        private string suit;
        private string rank;

        private Dictionary<string, CardSuite> cardSuiteMapping = new Dictionary<string, CardSuite>()
        {
            {"clubs", CardSuite.Clubs },
            {"diamonds", CardSuite.Diamonds },
            {"hearts", CardSuite.Hearts },
            {"spades", CardSuite.Spades },
        };

        private Dictionary<string, CardRank> cardRateMapping = new Dictionary<string, CardRank>()
        {
            { "1", CardRank.One },
            { "2", CardRank.Two },
            { "3", CardRank.Three },
            { "4", CardRank.Four },
            { "5", CardRank.Five },
            { "6", CardRank.Six },
            { "7", CardRank.Seven },
            { "8", CardRank.Eight },
            { "9", CardRank.Nine },
            { "10", CardRank.Ten },
            { "J", CardRank.Jumbo },
            { "Q", CardRank.Quen },
            { "K", CardRank.King },
            { "A", CardRank.Ace },
        };

        public CardSuite Suit
        {
            get
            {
                return cardSuiteMapping[suit];
            }
        }

        public CardRank Rank
        {
            get
            {
                return cardRateMapping[rank];
            }
        }


    }
}
