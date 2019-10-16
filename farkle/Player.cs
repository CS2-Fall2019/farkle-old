//-----------------------------------------------------------------------
// <copyright file="Player.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace farkle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Player
    {
        // Playes total score.
        private int score;

        // Players score for the current round
        private int pendingScore;

        // Variable for the first die.
        private Label dieOne;

        // Variable for the second die.
        private Label dieTwo;

        // Variable for the three die.
        private Label dieThree;

        // Variable for the four die.
        private Label dieFour;

        // Variable for the fifth die.
        private Label dieFive;

        // Variable for the sixth die.
        private Label dieSix;

        /// <summary>
        /// Gets or sets Score.
        /// </summary>
        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        /// <summary>
        /// Gets or sets Pending Score.
        /// </summary>
        public int PendingScore
        {
            get { return this.pendingScore; }
            set { this.pendingScore = value; }
        }


        public int ScoreDice()
        {
            // Variable for total score from the dice roll.
            int totalScore;
            // Scoring 

            List<int> diceKept;
            int die1 = 100;
            int die5 = 50;

            // Create variables to keep count of each die.
            int oneCounter = 0;
            int twoCounter = 0;
            int threeCounter = 0;
            int fourCounter = 0;
            int fiveCounter = 0;
            int sixCounter = 0;
            bool hotDice = false;

            if (hotDice == false)
            {
                this.pendingScore = 0;
            }
            else
            {

            }

            if (diceKept.Count == 1)
            {
                if (diceKept[] == 1)
                {
                    pendingScore = die1;
                }
                else
                {
                    pendingScore = die5;
                }
            }
            else
            {
                // Two of the dice have been kept.
                foreach (int die in diceKept)
                {
                    // If the current die is a 1.
                    if (die == 1)
                    {
                        // Increment the one counter.
                        oneCounter++;
                    }
                    else if (die == 2)
                    {
                        // Increment the two counter
                        twoCounter++;
                    }
                    else if (die == 3)
                    {
                        // Increment the three counter.
                        threeCounter++;
                    }
                    else if (die == 4)
                    {
                        // Increment the four counter.
                        fourCounter++;
                    }
                    else if (die == 5)
                    {
                        // Increment the five counter.
                        fiveCounter++;
                    }
                    else
                    {
                        // Increment the six counter.
                        sixCounter++;
                    }
                }

                // Loop through the oneCounter and adjust scores.
                for (int i = 0; i <= oneCounter; i++)
                {
                    if (i < 3)
                    {
                        // Add 100 for each one rolled.
                        pendingScore += 100;
                    }
                    else if (i == 3)
                    {
                        // If oneCounter is 3 add 1000.
                        pendingScore = 1000;
                    }
                    else if (i == 4)
                    {
                        // If oneCounter is 4 add 2000.
                        pendingScore = 2000;
                    }
                    else if (i == 5)
                    {
                        // If oneCounter is 5 add 4000.
                        pendingScore = 4000;
                    }
                    else 
                    {
                        // If oneCounter is 6 add 8000.
                        pendingScore = 8000;
                    }
                }

                // Loop through the twoCounter and adjust scores.
                for (int i = 0; i <= twoCounter; i++)
                {
                    if (i < 3)
                    {
                        // If twoCounter is less than 2 add 0 to pending score.
                        pendingScore += 0;
                    }
                    else if (i == 3)
                    {
                        // If twoCounter is 3 add 200.
                        pendingScore = 200;
                    }
                    else if (i == 4)
                    {
                        // If twoCounter is 4 add 400.
                        pendingScore = 400;
                    }
                    else if (i == 5)
                    {
                        // If twoCounter is 5 add 800.
                        pendingScore = 800;
                    }
                    else if (i == 6)
                    {
                        // If twoCounter is 6 add 1600.
                        pendingScore = 1600;
                    }
                }

                // Loop through the threeCounter and adjust scores.
                for (int i = 0; i <= threeCounter; i++)
                {
                    if (i < 3)
                    {
                        pendingScore = 0;
                    }
                    else if (i == 3)
                    {
                        pendingScore = 300;
                    }
                    else if (i == 4)
                    {
                        pendingScore = 600;
                    }
                    else if (i == 5)
                    {
                        pendingScore = 1200;
                    }
                    else if (i == 6)
                    {
                        pendingScore = 2400;
                    }
                }

                // Loop through the fourCounter and adjust scores.
                for (int i = 0; i <= fourCounter; i++)
                {
                    if (i < 3)
                    {
                        pendingScore = 0;
                    }
                    else if (i == 3)
                    {
                        pendingScore = 400;
                    }
                    else if (i == 4)
                    {
                        pendingScore = 800;
                    }
                    else if (i == 5)
                    {
                        pendingScore = 1600;
                    }
                    else if (i == 6)
                    {
                        pendingScore = 3200;
                    }
                }

                // Loop through the fiveCounter and adjust scores.
                for (int i = 0; i <= fiveCounter; i++)
                {
                    if (i < 3)
                    {
                        pendingScore += 50;
                    }
                    else if (i == 3)
                    {
                        pendingScore = 500;
                    }
                    else if (i == 4)
                    {
                        pendingScore = 1000;
                    }
                    else if (i == 5)
                    {
                        pendingScore = 2000;
                    }
                    else if (i == 6)
                    {
                        pendingScore = 4000;
                    }
                }

                // Loop through the sixCounter and adjust scores.
                for (int i = 0; i <= sixCounter; i++)
                {
                    if (i < 3)
                    {
                        pendingScore = 0;
                    }
                    else if (i == 3)
                    {
                        pendingScore = 600;
                    }
                    else if (i == 4)
                    {
                        pendingScore = 1200;
                    }
                    else if (i == 5)
                    {
                        pendingScore = 2400;
                    }
                    else if (i == 6)
                    {
                        pendingScore = 4800;
                    }
                }

            }

            /*
            else if (diceKept.Count == 2)
            {
                
            }
            else if (diceKept.Count == 3)
            {
                // Three of the dice have been kept.
            }
            else if (diceKept.Count == 4)
            {
                // Four of the dice have been kept.
            }
            else if (diceKept.Count == 5)
            {
                // Five of the dice have been kept.
            }
            else
            {
                // Dice kept count is 6.

                // Re-roll.
                Dice Die = new Dice();
                int returnAmt;
                returnAmt = Die.RollDice();
            }
            */

            // Die 1-dot = 100pts

            // Die 1-dot x 3 = 1000pts

            // Die 5-dot x 3 = 500pts

            // Die 3 x 2 = 200pts

            // Die 3 x 3 = 300pts

            // Die 3 x 4 = 400pts

            // Die 3 x 5 = 500pts

            // Die 3 x 6 = 600pts

            // Straight = 3000pts

            // Three pair = 1500pts

            return totalScore;
        }
    }
}
