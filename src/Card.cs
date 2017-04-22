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

    class Card
    {
        public CardType Suit { get; set; }
        public int Rank { get; set; }
    }
}
