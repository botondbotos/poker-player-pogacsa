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
        private CardSuite suit;
        private CardRank rank;

        public CardSuite Suit {
            get
            {
                return suit;
            }
            set
            {
                if (value.Equals("hearts")) suit = CardSuite.Hearts;
                else if (value.Equals("clubs")) suit = CardSuite.Clubs;
                else if (value.Equals("spades")) suit = CardSuite.Spades;
                else if (value.Equals("diamonds")) suit = CardSuite.Diamonds;
            }
        }

        public CardRank Rank {
            get
            {
                return rank;
            }
            set
            {
                if (value.Equals("1")) rank = CardRank.One;
                else if (value.Equals("2")) rank = CardRank.Two;
                else if (value.Equals("3")) rank = CardRank.Three;
                else if (value.Equals("4")) rank = CardRank.Four;
                else if (value.Equals("5")) rank = CardRank.Five;
                else if (value.Equals("6")) rank = CardRank.Six;
                else if (value.Equals("7")) rank = CardRank.Seven;
                else if (value.Equals("8")) rank = CardRank.Eight;
                else if (value.Equals("9")) rank = CardRank.Nine;
                else if (value.Equals("10")) rank = CardRank.Ten;
                else if (value.Equals("J")) rank = CardRank.Jumbo;
                else if (value.Equals("Q")) rank = CardRank.Quen;
                else if (value.Equals("K")) rank = CardRank.King;
                else if (value.Equals("A")) rank = CardRank.Ace;
            }
        }
        
  
    }
}
