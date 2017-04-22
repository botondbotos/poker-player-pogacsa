using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Simple
{
    enum CardType
    {
        DIAMOND, CLUB, HEART, SPADE
    }

    class Card
    {
        public CardType Suit { get; set; }
        public int Value { get; set; }
    }

}
