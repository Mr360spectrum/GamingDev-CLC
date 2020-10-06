/*
Karter Ence
Guess My Number
10/6/2020
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMyNumber
{
    public partial class Form1 : Form
    {
        //Create a Random object
        Random random = new Random();

        //Declare public variables
        private int number;
        private int guesses;
        private bool win;

        public Form1()
        {
            InitializeComponent();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            //Make the upDownLabel visible
            upDownLabel.Visible = true;

            //Get player guess
            int guess = Decimal.ToInt32(guessUpDown.Value);

            //See if guess is equal to, lower than, or greater than number
            if (guess == number)
            {
                upDownLabel.Text = "You guessed it!";
                win = true;
            }
            else if (guess > number)
            {
                upDownLabel.Text = "Guess lower.";
            }
            else
            {
                upDownLabel.Text = "Guess higher.";
            }

            if (guesses == 2 && !win)
            {
                upDownLabel.Text = "You lost.";
                guessButton.Enabled = false;
            }

            //Add one to total guesses
            guesses++;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            number = random.Next(1, 11);
            guesses = 0;
        }
    }
}
