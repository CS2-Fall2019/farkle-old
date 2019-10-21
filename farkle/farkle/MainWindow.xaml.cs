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
            allDice.Die1 = allDice.DiceList[0];
            allDice.Die2 = allDice.DiceList[1];
            allDice.Die3 = allDice.DiceList[2];
            allDice.Die4 = allDice.DiceList[3];
            allDice.Die5 = allDice.DiceList[4];
            allDice.Die6 = allDice.DiceList[5];



            // For die 1
            if (allDice.Die1 >= 1 && allDice.Die1 <= 6)
            {
                imgRoll1.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + allDice.Die1.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 2
            if (allDice.Die2 >= 1 && allDice.Die2 <= 6)
            {
                imgRoll2.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + allDice.Die2.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 3
            if (allDice.Die3 >= 1 && allDice.Die3 <= 6)
            {
                imgRoll3.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + allDice.Die3.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 4
            if (allDice.Die4 >= 1 && allDice.Die4 <= 6)
            {
                imgRoll4.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + allDice.Die4.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            // For die 5
            if (allDice.Die5 >= 1 && allDice.Die5 <= 6)
            {
                imgRoll5.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + allDice.Die5.ToString() + "Die.jpg"));
            }
            else
            {
                // die 1 is null and nothing needs to be done
            }
            //For die 6
            if (allDice.Die6 >= 1 && allDice.Die6 <= 6)
            {
                imgRoll6.Source = new BitmapImage(new Uri(@"pack://application:,,,/farkle;component/Resources/" + allDice.Die6.ToString() + "Die.jpg"));
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
                imgRoll1.Visibility = Visibility.Hidden;
                cbxRoll1.IsChecked = false;
                allDice.Die1Visible = true;
                // add the roll to the dice kept array for that player
                player1.DieKept[0] = allDice.Die1;              
            }
            else
            {
                imgSavedDie1.Visibility = Visibility.Hidden;
                imgRoll1.Visibility = Visibility.Visible;
                cbxRoll1.IsChecked = false;
                allDice.Die1Visible = false;
                // if the roll is saved, and between 1 and 6, remove it from the dice kept array and set the image source back to the original
                player1.DieKept[0] = 0;
                imgRoll1.Source = imgSavedDie1.Source;


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
                imgRoll2.Visibility = Visibility.Hidden;
                cbxRoll2.IsChecked = false;
                allDice.Die2Visible = true;
                // second spot in the array holds die #2
                player1.DieKept[1] = allDice.Die2; 
            }
            else
            {
                imgSavedDie2.Visibility = Visibility.Hidden;
                imgRoll2.Visibility = Visibility.Visible;
                cbxRoll2.IsChecked = false;
                allDice.Die2Visible = false;
                // if the roll is saved, and between 1 and 6, remove it from the dice kept array and set the image source back to the original
                player1.DieKept[1] = 0;
                imgRoll2.Source = imgSavedDie2.Source;
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
                imgRoll3.Visibility = Visibility.Hidden;
                cbxRoll3.IsChecked = false;
                allDice.Die3Visible = true;
                // third spot in the array holds die #3
                player1.DieKept[2] = allDice.Die3;
            }
            else
            {
                imgSavedDie3.Visibility = Visibility.Hidden;
                imgRoll3.Visibility = Visibility.Visible;
                cbxRoll3.IsChecked = false;
                allDice.Die3Visible = false;
                // if the roll is saved, and between 1 and 6, remove it from the dice kept array and set the image source back to the original

                player1.DieKept[2] = 0;
                imgRoll3.Source = imgSavedDie3.Source;

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
                imgRoll4.Visibility = Visibility.Hidden;
                cbxRoll4.IsChecked = false;
                allDice.Die4Visible = true;
                // fourth spot in the array holds die #4
                player1.DieKept[3] = allDice.Die4;
            }
            else
            {
                imgSavedDie4.Visibility = Visibility.Hidden;
                imgRoll4.Visibility = Visibility.Visible;
                cbxRoll4.IsChecked = false;
                allDice.Die4Visible = false;
                // if the roll is saved, and between 1 and 6, remove it from the dice kept array and set the image source back to the original
                player1.DieKept[3] = 0;
                imgRoll4.Source = imgSavedDie4.Source;
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
                imgRoll5.Visibility = Visibility.Hidden;
                cbxRoll5.IsChecked = false;
                allDice.Die5Visible = true;
                // fifth spot in the array holds die #5
                player1.DieKept[4] = allDice.Die5;
            }
            else
            {
                imgSavedDie5.Visibility = Visibility.Hidden;
                imgRoll5.Visibility = Visibility.Visible;
                cbxRoll5.IsChecked = false;
                allDice.Die5Visible = false;
                // if the roll is saved, and between 1 and 6, remove it from the dice kept array and set the image source back to the original
                player1.DieKept[4] = 0;
                imgRoll5.Source = imgSavedDie5.Source;
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
                imgRoll6.Visibility = Visibility.Hidden;
                cbxRoll6.IsChecked = false;
                allDice.Die6Visible = true;
                // sixth spot in the array holds die #6
                player1.DieKept[5] = allDice.Die6;
            }
            else
            {
                imgSavedDie6.Visibility = Visibility.Hidden;
                imgRoll6.Visibility = Visibility.Visible;
                cbxRoll6.IsChecked = false;
                allDice.Die6Visible = true;
                // if the roll is saved, and between 1 and 6, remove it from the dice kept array and set the image source back to the original
                player1.DieKept[5] = 0;              
                imgRoll6.Source = imgSavedDie6.Source;
            }
        }

        /// <summary>
        /// Method to Check the Dice.
        /// </summary>
        public int CheckDice()
        {
            int dv1 = player1.DieKept[0];
            int dv2 = player1.DieKept[1];
            int dv3 = player1.DieKept[2];
            int dv4 = player1.DieKept[3];
            int dv5 = player1.DieKept[4];
            int dv6 = player1.DieKept[5];



        }

        /// <summary>
        /// Method for BtnRoll Click.
        /// </summary>
        private void BtnRoll_Click(object sender, RoutedEventArgs e)
        {

            CheckDice();
            // Call RollDice method using the return value from check dice.
            Random rand = new Random();
            allDice.RollDice(rand.Next(4));
            allDice.Die1 = allDice.DiceList[0];
            allDice.Die2 = allDice.DiceList[1];
            allDice.Die3 = allDice.DiceList[2];
            allDice.Die4 = allDice.DiceList[3];
            allDice.Die5 = allDice.DiceList[4];
            allDice.Die6 = allDice.DiceList[5];
            // todo set text content of lblPendingScore. Im not sure how were going to do this continuously.

            // Call the SetDiceImg method.
            SetDiceImg();
            //allDice.DiceList.Clear();
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

        private void btnScoring_Click(object sender, RoutedEventArgs e)
        {
            Scoring ScoreSheet = new Scoring();
            ScoreSheet.Show();
        }

    }
}
