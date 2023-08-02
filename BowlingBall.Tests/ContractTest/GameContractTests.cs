
using BowlingBall.Enums;
using BowlingBall.Modals.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests.ContractTest
{
    [TestClass]
    public class GameContractTests
    {

        #region Frame Size
        [TestMethod]
        public void Openframe_should_return_framesize_equal_to_2()
        {
            var openFrame = new OpenFrame(0, 0, new System.Collections.Generic.List<int>());

            Assert.AreEqual(2, openFrame.CurrentFrameSize);
        }

        [TestMethod]
        public void Spareframe_should_return_framesize_equal_to_2()
        {
            var spareFrame = new SpareFrame(0, 0, new System.Collections.Generic.List<int>());

            Assert.AreEqual(2, spareFrame.CurrentFrameSize);
        }
      

        [TestMethod]
        public void Strikeframe_should_return_framesize_equal_to_1()
        {
            var strikeFrame = new StrikeFrame(new System.Collections.Generic.List<int>());

            Assert.AreEqual(1, strikeFrame.CurrentFrameSize);
        }

        [TestMethod]
        public void Extraballframe_should_return_framesize_equal_to_0()
        {
            var extraBallFrame = new ExtraBallFrame(0, new System.Collections.Generic.List<int>());

            Assert.AreEqual(0, extraBallFrame.CurrentFrameSize);
        }
        #endregion

        #region FrameType
        [TestMethod]
        public void Strikeframe_should_return_frametype_equal_to_StrikeFrame()
        {
            var strikeFrame = new StrikeFrame(new System.Collections.Generic.List<int>());

            Assert.AreEqual(FrameType.StrikeFrame, strikeFrame.CurrentFrameType);
        }

        [TestMethod]
        public void Extraballframe_should_return_frametype_equal_to_ExtraBallFrame()
        {
            var extraBallFrame = new ExtraBallFrame(0, new System.Collections.Generic.List<int>());

            Assert.AreEqual(FrameType.ExtraBallFrame, extraBallFrame.CurrentFrameType);
        }


        [TestMethod]
        public void Openframe_should_return_frametype_equal_to_OpenFrame()
        {
            var openFrame = new OpenFrame(0, 0, new System.Collections.Generic.List<int>());

            Assert.AreEqual(FrameType.OpenFrame, openFrame.CurrentFrameType);
        }

        [TestMethod]
        public void Spareframe_should_return_frametype_equal_to_SpareFrame()
        {
            var spareFrame = new SpareFrame(0, 0, new System.Collections.Generic.List<int>());

            Assert.AreEqual(FrameType.SpareFrame, spareFrame.CurrentFrameType);
        }
        #endregion
    }
}
