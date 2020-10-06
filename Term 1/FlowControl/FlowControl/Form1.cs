/*
Karter Ence
Flow Control
10/6/2020
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowControl
{
    public partial class Form1 : Form
    {
        //Create a new Random object
        Random randNum = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        { 
            //Get random numbers for each die
            int playerDie1 = randNum.Next(1, 7);
            int playerDie2 = randNum.Next(1, 7);
            int comDie1 = randNum.Next(1, 7);
            int comDie2 = randNum.Next(1, 7);

            //Find totals
            int playerScore = playerDie1 + playerDie2;
            int comScore = comDie1 + comDie2;

            //Convert integers to strings and display them
            playLabel.Text = playerScore.ToString();
            comLabel.Text = comScore.ToString();

            //Make winLabel visible
            winLabel.Visible = true;

            //Determine winner
            if (playerScore > comScore) //If the player's score is greater than the computer's
            {
                //Change the text
                winInfo.Text = "The winner is..."; 
                winLabel.Text = "Player!";
            }
            else if (comScore > playerScore) //If the computer's score is greater than the player's
            {
                winInfo.Text = "The winner is...";
                winLabel.Text = "Computer!";
            }
            else //If both values are equal (yes, I know that the "else if" is unnecessary. I know it can just be "else". I don't care).
            {
                winInfo.Text = "Oh, it's a tie.";
                winLabel.Text = "Darn.";
            }

            Task.Delay(2000).Wait();
            winLabel.Visible = false;
        }
    }
}
