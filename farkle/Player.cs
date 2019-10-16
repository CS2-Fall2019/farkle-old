//-----------------------------------------------------------------------
// <copyright file="Player.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Windows;

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
            int totalScore = 0;
            // Scoring 

            // Set up a list to store the diceKept in.
            List<int> diceKept = new List<int>();

            // Set up variables to hold the scores for a single 1 or single 5 rolled.
            int die1 = 100;
            int die5 = 50;

            // Create variables to keep count of each die.
            int oneCounter = 0;
            int twoCounter = 0;
            int threeCounter = 0;
            int fourCounter = 0;
            int fiveCounter = 0;
            int sixCounter = 0;

            // Set up a bool value to hold true if all 6 dice are kept.
            bool hotDice = false;

            // todo Set up a bool value to hold true if there are dice that can be scored?
            // bool scoreableDice = true;

            // todo set up a way to tell if there are scoreable dice.
            // todo list of dice that arent being kept.
            // List<int> rolledDice = new List<int>();


            // todo not sure what was going here.
            // If 
            if (hotDice == false)
            {
                this.pendingScore = 0;
            }
            else
            {

            }

            // If there is only one dice kept.
            if (diceKept.Count == 1)
            {
                // If the dice kept is a 1.
                if (diceKept[0] == 1)
                {
                    // Add 100 to pendingScore.
                    pendingScore = die1;
                }
                else
                {
                    // The dice kept is a 5. Add 50 to the pendingScore.
                    pendingScore = die5;
                }
            }
            else
            {
                // Loop through the diceKept list and increment the counters of each die rolled.
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
                    // If there are less than 3 ones rolled.
                    if (i < 3)
                    {
                        // Add 100 for each one rolled.
                        pendingScore += 100;
                    }
                    else
                    {
                        // If there are 3 or more ones rolled.
                        if (i == 3)
                        {
                            // If oneCounter is 3 add 1000.
                            pendingScore += 1000;
                        }
                        else if (i == 4)
                        {
                            // If oneCounter is 4 add 2000.
                            pendingScore += 2000;
                        }
                        else if (i == 5)
                        {
                            // If oneCounter is 5 add 4000.
                            pendingScore += 4000;
                        }
                        else
                        {
                            // If oneCounter is 6 add 8000.
                            pendingScore += 8000;
                        }
                    }
                }

                // Loop through the twoCounter and adjust scores.
                for (int i = 0; i <= twoCounter; i++)
                {
                    // If there are 3 or more twos rolled.
                    if (i == 3)
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
                    else
                    {
                        // If twoCounter is 6 add 1600.
                        pendingScore = 1600;
                    }
                }

                // Loop through the threeCounter and adjust scores.
                for (int i = 0; i <= threeCounter; i++)
                {
                    // If there are 3 or more threes rolled.
                    if (i == 3)
                    {
                        // If threeCounter is 3 add 300.
                        pendingScore += 300;
                    }
                    else if (i == 4)
                    {
                        // If threeCounter is 4 add 600.
                        pendingScore += 600;
                    }
                    else if (i == 5)
                    {
                        // If threeCounter is 5 add 1200.
                        pendingScore += 1200;
                    }
                    else
                    {
                        // If threeCounter is 6 add 2400.
                        pendingScore += 2400;
                    }
                }

                // Loop through the fourCounter and adjust scores.
                for (int i = 0; i <= fourCounter; i++)
                {
                    // If there are 3 or more fours rolled.
                    if (i == 3)
                    {
                        // If fourCounter is 3 add 400.
                        pendingScore += 400;
                    }
                    else if (i == 4)
                    {
                        // If fourCounter is 4 add 800.
                        pendingScore += 800;
                    }
                    else if (i == 5)
                    {
                        // If fourCounter is 5 add 1600.
                        pendingScore += 1600;
                    }
                    else
                    {
                        // If fourCounter is 6 add 3200.
                        pendingScore += 3200;
                    }
                }

                // Loop through the fiveCounter and adjust scores.
                for (int i = 0; i <= fiveCounter; i++)
                {
                    // If there are less than 3 fives rolled.
                    if (i < 3)
                    {
                        // Add 50 for each 5 rolled.
                        pendingScore += 50;
                    }
                    else
                    {
                        // If there are 3 or more fives rolled.
                        if (i == 3)
                        {
                            // If fiveCounter is 3 add 500.
                            pendingScore += 500;
                        }
                        else if (i == 4)
                        {
                            // If fiveCounter is 4 add 1000.
                            pendingScore += 1000;
                        }
                        else if (i == 5)
                        {
                            // If fiveCounter is 5 add 2000.
                            pendingScore += 2000;
                        }
                        else
                        {
                            // If fiveCounter is 6 add 4000.
                            pendingScore += 4000;
                        }
                    }
                }

                // Loop through the sixCounter and adjust scores.
                for (int i = 0; i <= sixCounter; i++)
                {
                    // If there are 3 or more sixes rolled.
                    if (i == 3)
                    {
                        // If sixCounter is 3 add 600.
                        pendingScore += 600;
                    }
                    else if (i == 4)
                    {
                        // If sixCounter is 4 add 1200.
                        pendingScore += 1200;
                    }
                    else if (i == 5)
                    {
                        // If sixCounter is 5 add 2400.
                        pendingScore += 2400;
                    }
                    else
                    {
                        // If sixCounter is 6 add 4800.
                        pendingScore += 4800;
                    }
                }

                // Check to see if the player rolled a straight or three pairs.
                if (diceKept.Count == 6)
                {
                    // Set hotDice to true.
                    hotDice = true;

                    // Set up bool values to hold true if counters are pairs.
                    bool pairOnes = false;
                    bool pairTwos = false;
                    bool pairThrees = false;
                    bool pairFours = false;
                    bool pairFives = false;
                    bool pairSixes = false;

                    // Set up a bool value to hold true if there are three pairs.
                    bool threePairs = false;

                    // Check for pairs.
                    // If theres a pair of ones.
                    if (oneCounter == 2)
                    {
                        // Set pairOnes as true.
                        pairOnes = true;
                    }

                    // If theres a pair of twos.
                    if (twoCounter == 2)
                    {
                        // Set pairTwos as true.
                        pairTwos = true;
                    }

                    // If theres a pair of threes.
                    if (threeCounter == 2)
                    {
                        // Set pairThrees as true.
                        pairThrees = true;
                    }

                    // If theres a pair of fours.
                    if (fourCounter == 2)
                    {
                        // Set pairFours as true.
                        pairFours = true;
                    }

                    // If theres a pair of fives.
                    if (fiveCounter == 2)
                    {
                        // Set pairFives as true.
                        pairFives = true;
                    }

                    // If theres a pair of sixes.
                    if (sixCounter == 2)
                    {
                        // Set pairSixes as true.
                        pairSixes = true;
                    }

                    // Check for a straight.
                    if (oneCounter == 1 && twoCounter == 1 && threeCounter == 1 &&
                        fourCounter == 1 && fiveCounter == 1 && sixCounter == 1)
                    {
                        // Add 3000 to the pending score for a straight.
                        pendingScore = 3000;
                    }
                    else
                    {
                        // Check for three pairs.
                        // If theres a pair of ones.
                        if (pairOnes)
                        {
                            // Check if theres another pair.
                            if (pairTwos)
                            {
                                // Check if theres a third pair.
                                if (pairThrees)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairFours)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairFives)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else if (pairThrees)
                            {
                                // Check if theres a third pair.
                                if (pairFours)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairFives)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else if (pairFours)
                            {
                                // Check if theres a third pair.
                                if (pairFives)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else if (pairFives)
                            {
                                // Check if theres a third pair.
                                if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else
                            {
                                // There are not three pairs.
                            }
                        }
                        else if (pairTwos)
                        {
                            // Check if theres another pair.
                            if (pairThrees)
                            {
                                // Check if theres a third pair.
                                if (pairFours)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairFives)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else if (pairFours)
                            {
                                // Check if theres a third pair.
                                if (pairFives)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else if (pairFives)
                            {
                                // Check if theres a third pair.
                                if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else
                            {
                                // There are not three pairs.
                            }
                        }
                        else if (pairThrees)
                        {
                            // Check if theres another pair.
                            if (pairFours)
                            {
                                // Check if theres a third pair.
                                if (pairFives)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else if (pairFives)
                            {
                                // Check if theres a third pair.
                                if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else
                            {
                                // There are not three pairs.
                            }
                        }
                        else if (pairFours)
                        {
                            // Check if theres another pair.
                            if (pairFives)
                            {
                                // Check if theres a third pair.
                                if (pairSixes)
                                {
                                    // Set threePairs to true.
                                    threePairs = true;
                                }
                                else
                                {
                                    // There are not three pairs.
                                }
                            }
                            else
                            {
                                // There are not three pairs.
                            }
                        }
                        else
                        {
                            // There are not three pairs.
                        }

                        // If there are three pairs.
                        if (threePairs)
                        {
                            // Add 1500 to the pending score for three pairs.
                            pendingScore = 1500;
                        }
                        else
                        {
                            // Pending score stays as pending score.
                        }
                    }

                    // Message box to tell player to roll again.
                    MessageBox.Show("You have hot dice! Roll again!");
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
