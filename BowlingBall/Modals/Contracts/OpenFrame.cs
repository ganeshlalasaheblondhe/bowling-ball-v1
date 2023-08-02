using BowlingBall.Enums;
using System.Collections.Generic;

namespace BowlingBall.Modals.Contracts
{
    /// <summary>
    /// Player did not clear the pins in given attempts.
    /// </summary>
    public class OpenFrame : Frame
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstRoll"></param>
        /// <param name="secondRoll"></param>
        /// <param name="scoresPerRoll"></param>
        public OpenFrame(int firstRoll, int secondRoll, List<int> scoresPerRoll) : base(scoresPerRoll)
        {
            scoresPerRoll.Add(firstRoll);
            scoresPerRoll.Add(secondRoll);
        }

        /// <inheritdoc/>
        public override int CurrentFrameScore()
        {
            return _scoresPerRoll[_currentNumberOfRoll] + _scoresPerRoll[_currentNumberOfRoll+1] ;
        }

        /// <inheritdoc/>
        public override int CurrentFrameSize => 2;

        /// <summary>
        /// <see cref="FrameType.OpenFrame"/>
        /// </summary>
        public override FrameType CurrentFrameType { get => FrameType.OpenFrame; }
    }
}
