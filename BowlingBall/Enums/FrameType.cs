namespace BowlingBall.Enums
{
    /// <summary>
    /// FrameType Enums, provide information arround what type of the given Frame is.
    /// </summary>
    public enum FrameType
    {
        /// <summary>
        /// System is not able to find the usable frame yet.
        /// </summary>
        YetToIdentify,
        /// <summary>
        /// OpenFrame: Player did not clear the pins in given attempts.
        /// </summary>
        OpenFrame,
        /// <summary>
        /// SpareFrame: player did clear the pins in given attempts.
        /// </summary>
        SpareFrame,
        /// <summary>
        /// StrikeFrame: Player did the clear the pins in first attempt.
        /// </summary>
        StrikeFrame,
        /// <summary>
        /// ExtraBallFrame: Player did the Spare or Strike in last frame so, player will gate the extra ball to roll.
        /// </summary>
        ExtraBallFrame
    }
}
