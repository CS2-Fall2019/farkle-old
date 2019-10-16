//-----------------------------------------------------------------------
// <copyright file="Dice.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
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

    /// <summary>
    /// Class representing the Dice.
    /// </summary>
    class Dice
    {
        /// <summary>
        /// The number of dice being kept.
        /// </summary>
        private int diceKept;

        /// <summary>
        /// Get or sets dice kept.
        /// </summary>
        public int DiceKept
        {
            get { return this.diceKept; }
            set { this.diceKept = value; }
        }

        /// <summary>
        /// Method to roll the dice.
        /// </summary>
        public void RollDice()
        {
 
        }
    }
}
