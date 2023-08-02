using BowlingBall.Enums;
using System.Collections.Generic;

namespace BowlingBall.Modals.Contracts
{
    /// <summary>
    /// Player did the clear the pins in first attempt.
    /// </summary>
    public class StrikeFrame : CloseFrame
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="scoresPerRoll"></param>
        public StrikeFrame(List<int> scoresPerRoll) : base(scoresPerRoll)
        {
            scoresPerRoll.Add(10);
        }

        /// <summary>
        /// Score calculations for Strike frames are little diffrent.
        /// While calculating the score for such frames we need the future frame roll scores.
        /// Function responsible for returning the second roll score from the upcomming next frame.
        /// </summary>
        /// <returns></returns>
        private int ScoreFromSecondNextFrameBall()
        {
            return _scoresPerRoll[_currentNumberOfRoll + CurrentFrameSize + 1];
        }

        /// <inheritdoc/>
        public override int CurrentFrameScore()
        {
            return 10 + ScoreFromFirstNextFrameBall() + ScoreFromSecondNextFrameBall();
        }

        /// <inheritdoc/>
        public override int CurrentFrameSize => 1;

        /// <summary>
        /// <see cref="FrameType.StrikeFrame"/>
        /// </summary>
        public override FrameType CurrentFrameType => FrameType.StrikeFrame;
    }
}
