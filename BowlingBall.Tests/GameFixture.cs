using BowlingBall.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {     

        [TestMethod]
        public void Gutter_game_score_should_be_0()
        {
            var game = new Game();
            var rolles = GameTestDataGenerater.AllZeros();
            foreach (int pins in rolles)
            {
                game.Roll(pins);
            }
            Assert.AreEqual(0, game.GetScore());
        }

        [TestMethod]
        public void All_four_rolls_game_score_should_be_80()
        {
            var game = new Game();
            var rolles = GameTestDataGenerater.AllFours();

            foreach (int pins in rolles)
            {
                game.Roll(pins);
            }
            Assert.AreEqual(80, game.GetScore());
        }


        [TestMethod]
        public void All_spare_rolls_game_score_should_be_146()
        {
            var game = new Game();
            var rolles = GameTestDataGenerater.AllSpare();

            foreach (int pins in rolles)
            {
                game.Roll(pins);
            }

            Assert.AreEqual(146, game.GetScore());
        }

        [TestMethod]
        public void All_strike_rolls_game_score_should_be_300()
        {
            var game = new Game();
            var rolles = GameTestDataGenerater.AllStrike();

            foreach(int pins in rolles)
            {
                game.Roll(pins);
            }

            Assert.AreEqual(300, game.GetScore());
        }

        [TestMethod]
        public void Alternate_strike_and_spare_rolls_game_score_should_be_200()
        {
            var game = new Game();
            var rolles = GameTestDataGenerater.AlternateStrikeAndSpare();

            foreach (int pins in rolles)
            {
                game.Roll(pins);
            }

            Assert.AreEqual(200, game.GetScore());
        }

        [TestMethod]
        public void Alternate_spare_and_strike_rolls_game_score_should_be_200()
        {
            var game = new Game();
            var rolles = GameTestDataGenerater.AlternateSpareAndStrike();

            foreach (int pins in rolles)
            {
                game.Roll(pins);
            }

            Assert.AreEqual(200, game.GetScore());
        }


        [TestMethod]
        public void In_between_spare_and_strike_game_score_should_be_59()
        {
            var game = new Game();
            var rolles = GameTestDataGenerater.InBetweenSpareAndStrike();

            foreach (int pins in rolles)
            {
                game.Roll(pins);
            }
            Assert.AreEqual(59, game.GetScore());
        }


        [TestMethod]
        public void One_from_given_document_should_return_187()
        {
            var game = new Game();
            var rolles = GameTestDataGenerater.OneFromGivenDocument();

            foreach (int pins in rolles)
            {
                game.Roll(pins);
            }
            Assert.AreEqual(187, game.GetScore());
        }

    }
}
