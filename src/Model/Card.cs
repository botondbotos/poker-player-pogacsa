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
        public CardSuite Suit { get; set; }
        public CardRank Rank { get; set; }

        public static Card Parse(JObject json)
        {
            Card result = new Card();

            result.Suit = retrieveCardSuite(json["suite"].Value<string>());
            result.Rank = retrieveCardRank(json["rank"].Value<string>());

            return result;
        }

        private static CardSuite retrieveCardSuite(string strType)
        {
            CardSuite result = CardSuite.Diamonds;

            if (strType.Equals("hearts")) result = CardSuite.Hearts;
            else if(strType.Equals("clubs")) result = CardSuite.Clubs;
            else if(strType.Equals("spades")) result = CardSuite.Spades;

            return result;
        }

        private static CardRank retrieveCardRank(string strRank)
        {
            CardRank result = CardRank.One;

            if (strRank.Equals("2")) result = CardRank.Two;
            else if (strRank.Equals("3")) result = CardRank.Three;
            else if (strRank.Equals("4")) result = CardRank.Four;
            else if (strRank.Equals("5")) result = CardRank.Five;
            else if (strRank.Equals("6")) result = CardRank.Six;
            else if (strRank.Equals("7")) result = CardRank.Seven;
            else if (strRank.Equals("8")) result = CardRank.Eight;
            else if (strRank.Equals("9")) result = CardRank.Nine;
            else if (strRank.Equals("10")) result = CardRank.Ten;
            else if (strRank.Equals("J")) result = CardRank.Jumbo;
            else if (strRank.Equals("Q")) result = CardRank.Quen;
            else if (strRank.Equals("K")) result = CardRank.King;
            else if (strRank.Equals("A")) result = CardRank.Ace;
            
            return result;
        }
    }
}
