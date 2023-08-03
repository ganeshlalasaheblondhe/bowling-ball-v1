using BowlingBall.Factory.Contracts;
using BowlingBall.Modals.Contracts;
using System.Collections.Generic;

namespace BowlingBall.Factory.Implementation
{
    /// <summary>
    /// Strike Frame Factory
    /// </summary>
    public class StrikeFrameFactory : IFrameFactory
    {
        /// <inheritdoc/>
        public Frame CreateFrame(int firstRoll, int secondRoll, List<int> scoresPerRoll)
        {
            return new StrikeFrame(scoresPerRoll);
        }
    }
}
