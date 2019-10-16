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

            // Die 1-dot = 100pts
            if (rolledDie[] = )
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
