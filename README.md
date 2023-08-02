# bowling-ball
## Introduction
a program, which, given a valid sequence of rolls for one line of American Ten-Pin Bowling, produces
the total score for the game. 
Here are some things that the program does not do:
• Does not check for valid rolls.
• Does not check for correct number of rolls and frames.
• Does not provide scores for intermediate frames.

This is a class library project which can be referred to another project, where you can use the functionality of Bowling-Ball Game.

## Entry Point:
A class Named with Game is the entry point of the program. With the help of Roll and GetScore function you will be able to start the game.

## Test Cases:
The project is 100% code covered using the unit and contract test cases.

## How to Run:
```
            var game = new Game();
            var rolles = new List<int>();

            // In case of all four number of attempts would be 20, as OpenFrame size is 2
            for (int i = 0; i < 20; i++)
            {
                rolles.Add(4);
            }

            foreach (int pins in rolles)
            {
                game.Roll(pins);
            }

            Console.WriteLine("Your Score for the Game is "+ game.GetScore());
```
