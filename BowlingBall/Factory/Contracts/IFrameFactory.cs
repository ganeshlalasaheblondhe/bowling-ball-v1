using BowlingBall.Modals.Contracts;
using System.Collections.Generic;

namespace BowlingBall.Factory.Contracts
{
    /// <summary>
    /// Abstarct Implementation of FrameFactory
    /// </summary>
    public interface IFrameFactory
    {
        /// <summary>
        /// Function responsible for creating an object of Frame.
        /// </summary>
        /// <param name="firstRoll"></param>
        /// <param name="secondRoll"></param>
        /// <param name="scoresPerRoll"></param>
        /// <returns></returns>
        Frame CreateFrame(int firstRoll, int secondRoll, List<int> scoresPerRoll);
    }
}
