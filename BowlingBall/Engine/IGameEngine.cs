namespace BowlingBall.Engine
{
    /// <summary>
    /// GameEngine class responsible for initializing the game and calculating the score for the player.
    /// </summary>
    interface IGameEngine
    {
        /// <summary>
        /// To start the game, start calling and passing the pin values to it.
        /// </summary>
        /// <param name="fallingPins"></param>
        void Play(int fallingPins);

        /// <summary>
        /// Function responsible for returning the score for the Game.
        /// </summary>
        /// <returns></returns>
        int Score();
    }
}
