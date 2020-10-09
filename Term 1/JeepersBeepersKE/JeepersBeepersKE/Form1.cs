/*
Karter Ence
Jeepers, Beepers!
10/9/2020
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

namespace JeepersBeepersKE
{
    public partial class jeepBeepForm : Form
    {
        public jeepBeepForm()
        {
            InitializeComponent();
        }

        private void ForButton_Click(object sender, EventArgs e)
        {
            //Declare numBeeps equal to what whas entered into NumBeepsText
            int numBeeps = int.Parse(NumBeepsText.Text);
            int i; //Declare index
            
            //Why in the world would you not use a NumericUpDown?
            //This lesson makes NO logical sense. I mean, I know how to do it, but these methods
            //used in solving issues are more complicated than they need to be.
            if (numBeeps > 0)
            {
                //Start for loop
                for (i = numBeeps; numBeeps > 0; numBeeps--)
                {
                    Console.Beep();
                }
            }
            else
            {
                MessageBox.Show("Please enter a positive number.");
            }

        }

        private void WhileButton_Click(object sender, EventArgs e)
        {
            //I don't know why the CompuScholar lesson wants us to do it this way.
            //It's really not particularly the most intuitive method, in my opinion.
            int count = 0;
            int numBeeps = int.Parse(NumBeepsText.Text);

            if (numBeeps > 0)
            {
                //Run until count is not less than numBeeps
                while (count < numBeeps)
                {
                    Console.Beep();
                    count++;
                }
            }
            else
            {
                MessageBox.Show("Please enter a positive number.");
            }

            
        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            int numBeeps = int.Parse(NumBeepsText.Text);

            if (numBeeps > 0)
            {
                //Create a do while loop
                do
                {
                    Console.Beep();
                    count++;
                } while (count < numBeeps);
            }
            else
            {
                MessageBox.Show("Please enter a positive number.");
            }
        }
    }
}
