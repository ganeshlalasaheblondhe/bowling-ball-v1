using BowlingBall.Factory.Contracts;
using BowlingBall.Modals.Contracts;
using System.Collections.Generic;

namespace BowlingBall.Factory.Implementation
{
    /// <summary>
    /// OpenFrame Factory
    /// </summary>
    public class OpenFrameFactory : IFrameFactory
    {
        /// <inheritdoc/>
        public Frame CreateFrame(int firstRoll, int secondRoll, List<int> scoresPerRoll)
        => new OpenFrame(firstRoll, secondRoll, scoresPerRoll);
    }
}
