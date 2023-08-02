using BowlingBall.Engine;

namespace BowlingBall
{
    public class Game
    {
        GameEngine gameEngine = new GameEngine();

        public void Roll(int pins)
        {
            gameEngine.Play(pins);
        }

        public int GetScore()
        {
            return gameEngine.Score();
        }
    }
}
