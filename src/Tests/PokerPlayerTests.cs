using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Simple.Tests
{
    [TestFixture]
    public class PokerPlayerTests
    {
        [Test]
        public void CanBetRequest()
        {
            // Arrange
            var jsonData = @"
{ 
    ""tournament_id"": ""58e67af2925f9e0004000002"", 
    ""game_id"": ""58fb54b050d19600040001c5"", 
    ""round"": 24, 
    ""players"": [ 
      { 
        ""name"": ""Deep Poker"", 
        ""stack"": 1836, 
        ""status"": ""active"", 
        ""bet"": 328, 
        ""time_used"": 1097839, 
        ""version"": ""Fuck pogacsa 1.4"", 
        ""id"": 0 
      }, 
      { 
        ""name"": ""happyDay"", 
        ""stack"": 935, 
        ""status"": ""folded"", 
        ""bet"": 0, 
        ""time_used"": 1018672, 
        ""version"": ""0.1"", 
        ""id"": 1 
      }, 
      { 
        ""name"": ""Ogli G Tribute team"", 
        ""stack"": 0, 
        ""status"": ""out"", 
        ""bet"": 0, 
        ""time_used"": 368108, 
        ""version"": ""0.1"", 
        ""id"": 2 
      }, 
      { 
        ""name"": ""Pogacsa"", 
        ""stack"": 807, 
        ""status"": ""active"", 
        ""bet"": 94, 
        ""hole_cards"": [ 
          { 
            ""rank"": ""K"", 
            ""suit"": ""diamonds"" 
          }, 
          { 
            ""rank"": ""10"", 
            ""suit"": ""spades"" 
          } 
        ], 
        ""time_used"": 1106087, 
        ""version"": ""Pogacsa v0.1"", 
        ""id"": 3 
      } 
    ], 
    ""small_blind"": 5, 
    ""big_blind"": 10, 
    ""orbits"": 6, 
    ""dealer"": 1, 
    ""community_cards"": [], 
    ""current_buy_in"": 328, 
    ""pot"": 422, 
    ""in_action"": 3, 
    ""minimum_raise"": 234, 
    ""bet_index"": 8 
} ";

            JObject gameData = JObject.Parse(jsonData);

            // Act
            int actual = PokerPlayer.BetRequest(gameData);

            // Assert
            Assert.That(actual, Is.GreaterThan(0));
        }
    }
}
