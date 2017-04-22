using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Simple
{
    enum CardType
    {
        Diamonds, Clubs, Hearts, Spades
    }
    
    enum CardRank
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

    class Card
    {
        public CardType Suit { get; set; }
        public int Rank { get; set; }
    }
}
