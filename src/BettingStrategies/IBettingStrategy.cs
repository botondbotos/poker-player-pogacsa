using Nancy.Simple.Model;

namespace Nancy.Simple.BettingStrategies
{
    public interface IBettingStrategy
    {
        int PlaceBet(GameState gameState);
    }
}