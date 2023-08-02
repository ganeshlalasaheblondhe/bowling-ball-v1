using BowlingBall.Enums;
using System.Collections.Generic;

namespace BowlingBall.Modals.Contracts
{
    /// <summary>
    /// Base class for the frame representation.
    /// </summary>
    public abstract class Frame 
    {
        protected int _currentNumberOfRoll;
        protected List<int> _scoresPerRoll;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="scoresPerRoll"></param>
        public Frame(List<int> scoresPerRoll)
        {
            _scoresPerRoll = scoresPerRoll;
            _currentNumberOfRoll = scoresPerRoll.Count;
        }

        /// <summary>
        /// Function responsible for returning the current frame score.
        /// </summary>
        /// <returns></returns>
        public abstract int CurrentFrameScore();

        /// <summary>
        /// Function responsible for returning the current frame size.
        /// </summary>
        /// <returns></returns>
        public abstract int CurrentFrameSize { get; }

        /// <summary>
        /// Current frame type <see cref="FrameType"/>
        /// </summary>
        public abstract FrameType CurrentFrameType { get; }
    }
}
