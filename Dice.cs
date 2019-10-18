﻿//-----------------------------------------------------------------------
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
        /// The number of die one.
        /// </summary>
        private int die1;

        /// <summary>
        /// The number of die two.
        /// </summary>
        private int die2;

        /// <summary>
        /// The number of die three.
        /// </summary>
        private int die3;

        /// <summary>
        /// The number of die four.
        /// </summary>
        private int die4;

        /// <summary>
        /// The number of die five.
        /// </summary>
        private int die5;

        /// <summary>
        /// The number of die six.
        /// </summary>
        private int die6;

        /// <summary>
        /// If die 1 is currently being kept.
        /// </summary>
        private bool die1Kept;

        /// <summary>
        /// If die 2 is currently being kept.
        /// </summary>
        private bool die2Kept;

        /// <summary>
        /// If die 3 is currently being kept.
        /// </summary>
        private bool die3Kept;

        /// <summary>
        /// If die 4 is currently being kept.
        /// </summary>
        private bool die4Kept;

        /// <summary>
        /// If die 5 is currently being kept.
        /// </summary>
        private bool die5Kept;

        /// <summary>
        /// If die 6 is currently being kept.
        /// </summary>
        private bool die6Kept;

        /// <summary>
        /// The numbered value of the die between 1 and 6.
        /// </summary>
        private int dieValue;

        /// <summary>
        /// Get or sets dice value.
        /// </summary>
        public int DieValue 
        {
            get { return this.dieValue; }
            set { this.dieValue = value; }
        }

        // public List<int> diceList;
        public List<int> DiceList = new List<int>();

        /// <summary>
        /// Get or sets dice kept.
        /// </summary>
        public int DiceKept
        {
            get { return this.diceKept; }
            set { this.diceKept = value; }
        }

        /// <summary>
        /// Get or sets die one.
        /// </summary>
        public int Die1
        {
            get { return this.die1; }
            set { this.die1 = value; }
        }

        /// <summary>
        /// Get or sets die two.
        /// </summary>
        public int Die2
        {
            get { return this.die2; }
            set { this.die2 = value; }
        }

        /// <summary>
        /// Get or sets die three.
        /// </summary>
        public int Die3
        {
            get { return this.die3; }
            set { this.die3 = value; }
        }

        /// <summary>
        /// Get or sets die four.
        /// </summary>
        public int Die4
        {
            get { return this.die4; }
            set { this.die4 = value; }
        }

        /// <summary>
        /// Get or sets die five.
        /// </summary>
        public int Die5
        {
            get { return this.die5; }
            set { this.die5 = value; }
        }

        /// <summary>
        /// Get or sets die six.
        /// </summary>
        public int Die6
        {
            get { return this.die6; }
            set { this.die6 = value; }
        }

        /// <summary>
        /// Gets or sets die1Kept.
        /// </summary>
        public bool Die1Kept
        {
            get => die1Kept;
            set => die1Kept = value;
        }

        /// <summary>
        /// Gets or sets die2Kept.
        /// </summary>
        public bool Die2Kept
        {
            get => die2Kept;
            set => die2Kept = value;
        }

        /// <summary>
        /// Gets or sets die3Kept.
        /// </summary>
        public bool Die3Kept
        {
            get => die3Kept;
            set => die3Kept = value;
        }

        /// <summary>
        /// Gets or sets die4Kept.
        /// </summary>
        public bool Die4Kept
        {
            get => die4Kept;
            set => die4Kept = value;
        }

        /// <summary>
        /// Gets or sets die5Kept.
        /// </summary>
        public bool Die5Kept
        {
            get => die5Kept;
            set => die5Kept = value;
        }

        /// <summary>
        /// Gets or sets die6Kept.
        /// </summary>
        public bool Die6Kept
        {
            get => die6Kept;
            set => die6Kept = value;
        }

        /// <summary>
        /// Method to roll the dice.
        /// </summary>
        public void RollDice(int diceRolled)
        {

            // Create insance of a dice array.
            Dice[] myDice;

            // Return a list of rolled dice (or a die).
            switch (diceRolled)
            {
                // Roll all 6 dice
                case 6:

                    // An array of 6 dice.                    
                    myDice = new Dice[6];

                    // Loop through and add a random number "foreach" die then add to list. 
                    foreach (Dice d in myDice)
                    {
                        // The number between 1 and 6 the die landed on.
                        d.DieValue = Roll();
                        this.DiceList.Add(d.DieValue);
                    }

                    break;

                // Roll 5 dice
                case 5:

                    // An array of 5 dice.
                    myDice = new Dice[5];

                    // Loop through and add a random number "foreach" die then add to list. 
                    foreach (Dice d in myDice)
                    {
                        // The number between 1 and 6 the die landed on.
                        d.DieValue = Roll();
                        this.DiceList.Add(d.DieValue);
                    }

                    break;

                // Roll 4 dice
                case 4:

                    // An array of 4 dice.
                    myDice = new Dice[4];

                    // Loop through and add a random number "foreach" die then add to list. 
                    foreach (Dice d in myDice)
                    {
                        // The number between 1 and 6 the die landed on.
                        d.DieValue = Roll();
                        this.DiceList.Add(d.DieValue);
                    }

                    break;

                // Roll 3 dice
                case 3:

                    // An array of 3 dice.
                    myDice = new Dice[3];

                    // Loop through and add a random number "foreach" die then add to list. 
                    foreach (Dice d in myDice)
                    {
                        // The number between 1 and 6 the die landed on.
                        d.DieValue = Roll();
                        this.DiceList.Add(d.DieValue);
                    }

                    break;

                // Roll 2 dice
                case 2:

                    // An array of 2 dice.
                    myDice = new Dice[2];

                    // Loop through and add a random number "foreach" die then add to list. 
                    foreach (Dice d in myDice)
                    {
                        // The number between 1 and 6 the die landed on.
                        d.DieValue = Roll();
                        this.DiceList.Add(d.DieValue);
                    }

                    break;
                
                // Roll 1 die
                default:

                    // An array of 1 dice.. err die.
                    myDice = new Dice[1];

                    // Loop through and add a random number "foreach" die then add to list. 
                    foreach (Dice d in myDice)
                    {
                        // The number between 1 and 6 the die landed on.
                        d.DieValue = Roll();
                        this.DiceList.Add(d.DieValue);
                    }

                    // Warn the player of their greed? You better hope to get hot dice!
                    break;
            }
        }

        private int Roll()
        {
            // Create instance of random number between 1 and 6.
            Random rand = new Random();

            // Return the random number.
            return rand.Next(1, 7);
        }
    }
}
