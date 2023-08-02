using BowlingBall.Enums;
using System.Collections.Generic;

namespace BowlingBall.Modals.Contracts
{
    /// <summary>
    /// player did clear the pins in given attempts.
    /// </summary>
    public class SpareFrame : CloseFrame
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstRoll"></param>
        /// <param name="secondRoll"></param>
        /// <param name="scoresPerRoll"></param>
        public SpareFrame(int firstRoll, int secondRoll, List<int> scoresPerRoll) : base(scoresPerRoll)
        {
            scoresPerRoll.Add(firstRoll);
            scoresPerRoll.Add(secondRoll);
        }

        /// <inheritdoc/>
        public override int CurrentFrameScore()
        {
            return 10 + ScoreFromFirstNextFrameBall();
        }

        /// <inheritdoc/>
        public override int CurrentFrameSize => 2;

        /// <summary>
        /// <see cref="FrameType.SpareFrame"/>
        /// </summary>
        public override FrameType CurrentFrameType => FrameType.SpareFrame;
    }
}
