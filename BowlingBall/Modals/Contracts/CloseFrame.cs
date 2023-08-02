using System.Collections.Generic;

namespace BowlingBall.Modals.Contracts
{
    /// <summary>
    /// Extended version of <see cref="Frame"/> responsible for identifing the Spare or Strike Frames.
    /// </summary>
    public abstract class CloseFrame : Frame
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="scoresPerRoll"></param>
        public CloseFrame(List<int> scoresPerRoll) :base(scoresPerRoll) {}

        /// <summary>
        /// Score calculations for closed frames are little diffrent.
        /// While calculating the score for such frames we need the future frame roll scores.
        /// Function responsible for returning the first roll score from the upcomming next frame.
        /// </summary>
        /// <returns></returns>
        protected int ScoreFromFirstNextFrameBall()
        {
            return _scoresPerRoll[_currentNumberOfRoll + CurrentFrameSize];
        }
    }
}
