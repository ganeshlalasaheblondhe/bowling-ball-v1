using BowlingBall.Enums;
using System.Collections.Generic;

namespace BowlingBall.Modals.Contracts
{
    /// <summary>
    /// Player did the Spare or Strike in last frame so, player will gate the extra ball to roll.
    /// </summary>
    public class ExtraBallFrame : Frame
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="extraRoll"></param>
        /// <param name="scoresPerRoll"></param>
        public ExtraBallFrame(int extraRoll, List<int> scoresPerRoll) : base(scoresPerRoll)
        {
            scoresPerRoll.Add(extraRoll);
        }

        /// <inheritdoc/>
        public override int CurrentFrameScore()
        {
            return 0;
        }

        /// <inheritdoc/>
        public override int CurrentFrameSize => 0;

        /// <summary>
        /// <see cref="FrameType.ExtraBallFrame"/>
        /// </summary>
        public override FrameType CurrentFrameType => FrameType.ExtraBallFrame;
    }
}
