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
    }
}
