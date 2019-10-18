//-----------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
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
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // New instance of the Dice Class.
        Dice allDice = new Dice();

        // New instance of the Player Class.
        Player player1 = new Player();

        /// <summary>
        /// Method to set the images of the dice.
        /// </summary>
        public void SetDiceImg()
        {
            // For die 1
            if (allDice.Die1 >= 1 && allDice.Die1 <= 6)
            {
                imgRoll1.Source = new BitmapImage(new Uri("Resources/" + allDice.Die1.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 2
            if (allDice.Die2 >= 1 && allDice.Die2 <= 6)
            {
                imgRoll2.Source = new BitmapImage(new Uri("Resources/" + allDice.Die2.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 3
            if (allDice.Die3 >= 1 && allDice.Die3 <= 6)
            {
                imgRoll3.Source = new BitmapImage(new Uri("Resources/" + allDice.Die3.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 4
            if (allDice.Die4 >= 1 && allDice.Die4 <= 6)
            {
                imgRoll4.Source = new BitmapImage(new Uri("Resources/" + allDice.Die4.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 5
            if (allDice.Die5 >= 1 && allDice.Die5 <= 6)
            {
                imgRoll5.Source = new BitmapImage(new Uri("Resources/" + allDice.Die5.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            //For die 6
            if (allDice.Die6 >= 1 && allDice.Die6 <= 6)
            {
                imgRoll6.Source = new BitmapImage(new Uri("Resources/" + allDice.Die6.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
        }

        /// <summary>
        /// Method for if cbxRoll1 is checked.
        /// </summary>
        private void cbxRoll1_Checked(object sender, RoutedEventArgs e)
        {

            if (imgSavedDie1.Visibility == Visibility.Hidden)
            {
                imgSavedDie1.Visibility = Visibility.Visible;
                imgSavedDie1.Source = imgRoll1.Source;
                cbxRoll1.IsChecked = false;
            }
            else
            {
                imgSavedDie1.Visibility = Visibility.Hidden;
                cbxRoll1.IsChecked = false;
            }
        }

        /// <summary>
        /// Method to check if cbxRoll2 is checked.
        /// </summary>
        private void cbxRoll2_Checked(object sender, RoutedEventArgs e)
        {

            if (imgSavedDie2.Visibility == Visibility.Hidden)
            {
                imgSavedDie2.Visibility = Visibility.Visible;
                imgSavedDie2.Source = imgRoll2.Source;
                cbxRoll2.IsChecked = false;
            }
            else
            {
                imgSavedDie2.Visibility = Visibility.Hidden;
                cbxRoll2.IsChecked = false;
            }
        }

        /// <summary>
        /// Method to check if cbxRoll3 is checked.
        /// </summary>
        private void cbxRoll3_Checked(object sender, RoutedEventArgs e)
        {

            if (imgSavedDie3.Visibility == Visibility.Hidden)
            {
                imgSavedDie3.Visibility = Visibility.Visible;
                imgSavedDie3.Source = imgRoll3.Source;
                cbxRoll3.IsChecked = false;
            }
            else
            {
                imgSavedDie3.Visibility = Visibility.Hidden;
                cbxRoll3.IsChecked = false;
            }
        }

        /// <summary>
        /// Method to check if cbxRoll4 is checked.
        /// </summary>
        private void cbxRoll4_Checked(object sender, RoutedEventArgs e)
        {

            if (imgSavedDie4.Visibility == Visibility.Hidden)
            {
                imgSavedDie4.Visibility = Visibility.Visible;
                imgSavedDie4.Source = imgRoll4.Source;
                cbxRoll4.IsChecked = false;
            }
            else
            {
                imgSavedDie4.Visibility = Visibility.Hidden;
                cbxRoll4.IsChecked = false;
            }
        }

        /// <summary>
        /// Method to check if cbxRoll5 is checked.
        /// </summary>
        private void cbxRoll5_Checked(object sender, RoutedEventArgs e)
        {

            if (imgSavedDie5.Visibility == Visibility.Hidden)
            {
                imgSavedDie5.Visibility = Visibility.Visible;
                imgSavedDie5.Source = imgRoll5.Source;
                cbxRoll5.IsChecked = false;
            }
            else
            {
                imgSavedDie5.Visibility = Visibility.Hidden;
                cbxRoll5.IsChecked = false;
            }
        }

        /// <summary>
        /// Method to check if cbxRoll6 is checked.
        /// </summary>
        private void cbxRoll6_Checked(object sender, RoutedEventArgs e)
        {

            if (imgSavedDie6.Visibility == Visibility.Hidden)
            {
                imgSavedDie6.Visibility = Visibility.Visible;
                imgSavedDie6.Source = imgRoll6.Source;
                cbxRoll6.IsChecked = false;
            }
            else
            {
                imgSavedDie6.Visibility = Visibility.Hidden;
                cbxRoll6.IsChecked = false;
            }
        }

        /// <summary>
        /// Method to Check the Dice.
        /// </summary>
        public int CheckDice()
        {
            // For roll 1
            if(imgSavedDie1.Visibility == Visibility.Visible)
            {
                allDice.DiceKept += 1;
            }
            else if (imgSavedDie1.Visibility == Visibility.Hidden)
            {
                allDice.DiceKept -= 1;
            }
            // For roll 2
            if (imgSavedDie2.Visibility == Visibility.Visible)
            {
                allDice.DiceKept += 1;
            }
            else if (imgSavedDie2.Visibility == Visibility.Hidden)
            {
                allDice.DiceKept -= 1;
            }
            // For roll 3
            if (imgSavedDie3.Visibility == Visibility.Visible)
            {
                allDice.DiceKept += 1;
            }
            else if (imgSavedDie3.Visibility == Visibility.Hidden)
            {
                allDice.DiceKept -= 1;
            }
            // For roll 4
            if (imgSavedDie4.Visibility == Visibility.Visible)
            {
                allDice.DiceKept += 1;
            }
            else if (imgSavedDie4.Visibility == Visibility.Hidden)
            {
                allDice.DiceKept -= 1;
            }
            // For roll 5
            if (imgSavedDie5.Visibility == Visibility.Visible)
            {
                allDice.DiceKept += 1;
            }
            else if (imgSavedDie5.Visibility == Visibility.Hidden)
            {
                allDice.DiceKept -= 1;
            }
            // For roll 6
            if (imgSavedDie6.Visibility == Visibility.Visible)
            {
                allDice.DiceKept += 1;
            }
            else if (imgSavedDie6.Visibility == Visibility.Hidden)
            {
                allDice.DiceKept -= 1;
            }

            int reroll = 6 - allDice.DiceKept;
            return reroll;
        }

        /// <summary>
        /// Method for BtnRoll Click.
        /// </summary>
        private void BtnRoll_Click(object sender, RoutedEventArgs e)
        {
            // Call RollDice method using the return value from check dice.
            allDice.RollDice(CheckDice());

            // todo set text content of lblPendingScore. Im not sure how were going to do this continuously.

            // Call the SetDiceImg method.
            SetDiceImg();
        }

        /// <summary>
        /// Method for BtnNextTurn Click.
        /// </summary>
        private void BtnNextTurn_Click(object sender, RoutedEventArgs e)
        {
            // Call the score dice method.
            player1.ScoreDice();

            // Set text content of lblCurrentScore.
            lblCurrentScore.Content = player1.CurrentScore;
        }

        /// <summary>
        /// Method for BtnExitTurn Click.
        /// </summary>
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
