using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Simple.Model
{
    public class GameState
    {
        public string tournament_id { get; set; }
        public string game_id { get; set; }
        public int round { get; set; }
        public int bet_index { get; set; }
        public int small_blind { get; set; }
        public int current_buy_in { get; set; }
        public int pot { get; set; }
        public int minimum_raise { get; set; }
        public int dealer { get; set; }
        public int orbits { get; set; }
        public int in_action { get; set; }
        public List<Player> players { get; set; }
        public List<Card> community_cards { get; set; }
    }
}
