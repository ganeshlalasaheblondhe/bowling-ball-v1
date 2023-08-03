using BowlingBall.Factory.Contracts;
using BowlingBall.Modals.Contracts;
using System.Collections.Generic;

namespace BowlingBall.Factory.Implementation
{
    /// <summary>
    /// ExtraBall Frame Factory
    /// </summary>
    public class ExtraBallFrameFactory : IFrameFactory
    {
        /// <inheritdoc/>
        public Frame CreateFrame(int firstRoll, int secondRoll, List<int> scoresPerRoll)
        {
            return new ExtraBallFrame(firstRoll,scoresPerRoll);
        }
    }
}
