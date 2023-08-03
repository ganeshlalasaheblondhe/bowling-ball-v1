using BowlingBall.Engine;

namespace BowlingBall
{
    /// <summary>
    /// BowlingBall Game class, use this class to Roll the Ball and fetch the Score
    /// </summary>
    public class Game
    {
        private readonly GameEngine _gameEngine;

        /// <summary>
        /// Constructor
        /// </summary>
        public Game()
        {
            _gameEngine = new GameEngine();
        }

        /// <summary>
        /// Function responsible for rolling the ball.
        /// </summary>
        /// <param name="pins"></param>
        public void Roll(int pins)
        {
            _gameEngine.Play(pins);
        }

        /// <summary>
        /// Function responsible for getting the score of the game.
        /// </summary>
        /// <returns></returns>
        public int GetScore()
        {
            return _gameEngine.Score();
        }
    }
}
