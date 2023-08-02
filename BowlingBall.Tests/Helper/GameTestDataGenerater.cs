using System.Collections.Generic;

namespace BowlingBall.Tests.Helpers
{
    public class GameTestDataGenerater
    {
        public static List<int> AllZeros()
        {
            var rolles = new List<int>();

            // In case of all zeros number of attempts would be 20, as OpenFrame size is 2
            for (int i = 0; i < 20; i++)
            {
                rolles.Add(0);
            }

            return rolles;
        }

        public static List<int> AllFours()
        {
            var rolles = new List<int>();

            // In case of all four number of attempts would be 20, as OpenFrame size is 2
            for (int i = 0; i < 20; i++)
            {
                rolles.Add(4);
            }

            return rolles;
        }

        public static List<int> AllSpare()
        {
            var rolles = new List<int>();

            // In case of all strike number of attempts would be 10
            for (int i = 0; i < 10; i++)
            {
                rolles.Add(4);
                rolles.Add(6);
            }

            // As we have spare we will get 1 bonus rolls
            rolles.Add(10);

            return rolles;
        }

        public static List<int> AllStrike()
        {
            var rolles = new List<int>();

            // In case of all strike number of attempts would be 10
            for(int i = 0; i < 10; i++)
            {
                rolles.Add(10);
            }

            // As we have strike we will get 2 bonus rolls
            rolles.Add(10);
            rolles.Add(10);

            return rolles;
        }

        public static List<int> AlternateStrikeAndSpare()
        {
            var rolles = new List<int>();

            // In case of all strike number of attempts would be 10
            for (int i = 0; i < 10; i++)
            {
                rolles.Add(10);
                rolles.Add(3);
                rolles.Add(7);
            }

            // In case of last Frame Spare we will gate only one Bonus Ball Frame.
            rolles.Add(10);
            return rolles;
        }

        public static List<int> AlternateSpareAndStrike()
        {
            var rolles = new List<int>();

            // In case of all strike number of attempts would be 10
            for (int i = 0; i < 10; i++)
            {
                rolles.Add(3);
                rolles.Add(7);
                rolles.Add(10);
            }

            // In case of last Frame Spare we will have 2 bonus chances

            // First Bonus chance was strike, so we will gate one more
            rolles.Add(10);

            // Second Bonus chance was also strike
            rolles.Add(10);
            return rolles;
        }

        public static List<int> OneFromGivenDocument()
        {
            var rolles = new List<int>();

            rolles.Add(10);
            rolles.Add(9);
            rolles.Add(1);
            rolles.Add(5);
            rolles.Add(5);
            rolles.Add(7);
            rolles.Add(2);
            rolles.Add(10);
            rolles.Add(10);
            rolles.Add(10);
            rolles.Add(9);
            rolles.Add(0);
            rolles.Add(8);
            rolles.Add(2);
            rolles.Add(9);
            rolles.Add(1);
            // Second Bonus chance was also strike
            rolles.Add(10);
            return rolles;
        }

        public static List<int> InBetweenSpareAndStrike()
        {
            var rolles = new List<int>();

            rolles.Add(1);
            rolles.Add(0);

            rolles.Add(9);
            rolles.Add(1);
            
            rolles.Add(5);
            rolles.Add(3);
            
            rolles.Add(10);
            
            rolles.Add(2);
            rolles.Add(2);
            
            rolles.Add(0);
            rolles.Add(0);
            
            rolles.Add(9);
            rolles.Add(0);
            
            rolles.Add(8);
            rolles.Add(0);
            
            rolles.Add(0);
            rolles.Add(0);
             
            rolles.Add(0);
            rolles.Add(0);
            return rolles;
        }
    }
}
