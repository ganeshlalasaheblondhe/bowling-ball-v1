using BowlingBall.Factory.Contracts;
using BowlingBall.Modals.Contracts;
using System.Collections.Generic;

namespace BowlingBall.Factory.Implementation
{
    /// <summary>
    /// Spare Frame Factory
    /// </summary>
    public class SpareFrameFactory : IFrameFactory
    {
        /// <inheritdoc/>
        public Frame CreateFrame(int firstRoll, int secondRoll, List<int> scoresPerRoll)
       => new SpareFrame(firstRoll, secondRoll, scoresPerRoll);
    }
}
