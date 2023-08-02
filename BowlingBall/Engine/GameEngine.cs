using BowlingBall.Enums;
using BowlingBall.Modals.Contracts;
using System.Collections.Generic;

namespace BowlingBall.Engine
{
    /// <summary>
    /// GameEngine class responsible for initializing the game and calculating the score for the player.
    /// </summary>
    public class GameEngine : IGameEngine
    {
        /// <summary>
        /// List of Frames responsible for storing the frames with there individual data.
        /// </summary>
        private readonly List<Frame> _frames;

        /// <summary>
        /// Variable keeps the track of all the rolled scores.
        /// </summary>
        private readonly List<int> _scorePerThrow;

        #region Internal variables for identifing the current frame and do the analysis.
        private int _numberOfRemainingAttempts = 2;
        private int _firstRoll = 0;
        private int _secondRoll = 0;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public GameEngine()
        {
            _frames = new List<Frame>();
            _scorePerThrow = new List<int>();
        }                     

        /// <summary>
        /// Function responsible for, resetting the framevariables once we are done with the current frame processing. 
        /// </summary>
        private void ResetTheAnalysisVariables()
        {
            _firstRoll = 0;
            _secondRoll = 0;
            _numberOfRemainingAttempts = 2;
        }

        /// <summary>
        /// Function responsible for identifing the type of frame and pushes it to the framelist for score calculation.
        /// </summary>
        /// <param name="frameType"></param>
        private void Analysis(FrameType frameType)
        {

            switch (frameType)
            {
                case FrameType.OpenFrame:
                    {
                        var openFrame = new OpenFrame(_firstRoll, _secondRoll, _scorePerThrow);
                        _frames.Add(openFrame);

                        ResetTheAnalysisVariables();
                        break;
                    }

                case FrameType.SpareFrame:
                    {
                        var spareFrame = new SpareFrame(_firstRoll, _secondRoll, _scorePerThrow);
                        _frames.Add(spareFrame);

                        ResetTheAnalysisVariables();
                        break;

                    }

                case FrameType.StrikeFrame:
                    {
                        var strikeFrame = new StrikeFrame(_scorePerThrow);
                        _frames.Add(strikeFrame);

                        ResetTheAnalysisVariables();
                        break;
                    }
                case FrameType.ExtraBallFrame:
                    {
                        var strikeFrame = new ExtraBallFrame(_firstRoll,_scorePerThrow);
                        _frames.Add(strikeFrame);

                        ResetTheAnalysisVariables();
                        break;
                        
                    }
                case FrameType.YetToIdentify:
                    {
                        break;
                    }
            }

        }

        /// <summary>
        /// Function responsible for identifing the FrameType based on the current fallingpin and the next falling pin.
        /// </summary>
        /// <param name="fallingPins"></param>
        /// <returns></returns>
        private FrameType FrameTypeFinder(int fallingPins)
        {
            if (_frames.Count >= 10)
            {
                _firstRoll = fallingPins;
                return FrameType.ExtraBallFrame;
            }


            if (fallingPins == 10 && _numberOfRemainingAttempts == 2)
            {
                return FrameType.StrikeFrame;
            }
            else if (_numberOfRemainingAttempts == 2)
            {
                _numberOfRemainingAttempts--;
                _firstRoll = fallingPins;
                return FrameType.YetToIdentify;
            }
            else
            {
                _numberOfRemainingAttempts--;
                _secondRoll = fallingPins;

                if (_firstRoll + _secondRoll == 10)
                    return FrameType.SpareFrame;
                else
                    return FrameType.OpenFrame;
            }
        }

        /// <inheritdoc />
        public void Play(int fallingPins)
        {
            var frameType = FrameTypeFinder(fallingPins);
            Analysis(frameType);
        }

        /// <inheritdoc />
        public int Score()
        {
            int score = 0;
            foreach(Frame frame in _frames)
            {
                score += frame.CurrentFrameScore();
            }
            return score;
        }

    }
}
