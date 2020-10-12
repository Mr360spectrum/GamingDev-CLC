/*
Karter Ence
Tic Tac Toe
10/8/2020
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

namespace TicTacToeKE
{
     
    public partial class Form1 : Form
    {
        //Class level variables
        public int player = 2;
        public int turns = 0;
        public int score1 = 0;
        public int score2 = 0;
        public int score3 = 0;
        public int start;
        public Form1()
        {
            InitializeComponent();
        }
        void NewGame()
        {
            start += 1;
            player = 2;
            turns = 0;
            xWinsLbl.Text = "X:  " + score1;
            oWinsLbl.Text = "O:  " + score2;
            drawLbl.Text = "Draws:  " + score3;
            button00.Text = button01.Text = button02.Text = button10.Text = button11.Text = button12.Text = button20.Text = button21.Text = button22.Text = "";

            if (start % 2 == 0)
            {
                player = 0;
            }
            else
            {
                player = 1;
            }
        }

        bool CheckDraw()
        {
            if (turns >= 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool CheckWinner()
        {
            //Horizontal checks
            if ((button00.Text == button01.Text) && (button01.Text == button02.Text) && (button00.Text != ""))
            {
                return true;
            }
            else if ((button10.Text == button11.Text) && (button11.Text == button12.Text) && (button10.Text != ""))
            {
                return true;
            }
            else if ((button20.Text == button21.Text) && (button21.Text == button22.Text) && (button20.Text != ""))
            {
                return true;
            }
            //Vertical Checks
            else if ((button00.Text == button10.Text) && (button10.Text == button20.Text) && (button00.Text != ""))
            {
                return true;
            }
            else if ((button01.Text == button11.Text) && (button11.Text == button21.Text) && (button01.Text != ""))
            {
                return true;
            }
            else if ((button02.Text == button12.Text) && (button12.Text == button22.Text) && (button02.Text != ""))
            {
                return true;
            }
            //Diagonal Checks
            else if ((button00.Text == button11.Text) && (button11.Text == button22.Text) && (button00.Text != ""))
            {
                return true;
            }
            else if ((button02.Text == button11.Text) && (button11.Text == button20.Text) && (button02.Text != ""))
            {
                return true;
            }
            //No win
            else
            {
                return false;
            }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            //Cast sender as a Button
            Button button = (Button)sender;

            //Check for existing text in the button
            if (button.Text == "")
            { 
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
            }
            else
            {
                Console.WriteLine("hehe button click go brrr");
            }

            if (CheckWinner())
            {
                if (button.Text == "X")
                {
                    score1++;
                    MessageBox.Show("X Wins!");
                    NewGame();
                }
                else
                {
                    score2++;
                    MessageBox.Show("O Wins!");
                    NewGame();
                }
            }
            else if (CheckDraw())
            {
                MessageBox.Show("Tie Game!");
                score3++;
                NewGame();
            }

            //button.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start = -1;
            NewGame();
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            //Close the window
            this.Close();
        }

        private void resetBttn_Click(object sender, EventArgs e)
        {
            //Reset all scores to 0
            score1 = 0;
            score2 = 0;
            score3 = 0;
            start = -1;
            NewGame();
        }

        private void newGameBttn_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
