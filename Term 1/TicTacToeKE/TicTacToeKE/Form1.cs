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
        public Form1()
        {
            InitializeComponent();
        }
        void NewGame()
        {
            player = 2;
            turns = 0;
            xWinsLbl.Text = "X:  " + score1;
            oWinsLbl.Text = "O:  " + score2;
            drawLbl.Text = "Draws:  " + score3;
            button00.Text = button01.Text = button02.Text = button10.Text = button11.Text = button12.Text = button20.Text = button21.Text = button22.Text = "";
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
                }
            }
            else
            {
                Console.WriteLine("hehe button click go brrr");
            }
                
            //button.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetBttn_Click(object sender, EventArgs e)
        {
            score1 = 0;
            score2 = 0;
            score3 = 0;
            NewGame();
        }

        private void newGameBttn_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
