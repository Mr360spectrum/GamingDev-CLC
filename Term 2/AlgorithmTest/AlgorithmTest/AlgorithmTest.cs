using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* TeenCoder: Windows Programming
   
   Algorithm Test Application

   Copyright 2013 CompuScholar, Inc.
*/

namespace AlgorithmTest
{
    public partial class AlgorithmTest : Form
    {
        public AlgorithmTest()
        {
            InitializeComponent();
        }

        // TODO BY STUDENT
        // The student will add code to this method in the Chapter Activity.
        private int findMagicNumber(int myNumber)
        {
            // replace with student code
            return 0;
        }

        // TODO BY STUDENT
        // The student will add code to this method in the Chapter Activity.
        private char convertToLetterGrade(int numberGrade)
        {
            // replace with student code
            return 'A';
        }

        // This code is provided complete in the Activity Starter
        private void MagicNumberButton_Click(object sender, EventArgs e)
        {
            // The result of this line should be a MessageBox with the value 2
            MessageBox.Show("Starting number = 16, ending number = " + findMagicNumber(16).ToString());

            // The result of this line should be a MessageBox with the value 2
            MessageBox.Show("Starting number = 5, ending number = " + findMagicNumber(5).ToString());
        }

        private void ConvertGradeButton_Click(object sender, EventArgs e)
        {
            // get numeric input from the user
            int numberGrade = Convert.ToInt32(userTextBox.Text);

            // call funciton to convert to a letter
            char letterGrade = convertToLetterGrade(numberGrade);

            // display the results
            MessageBox.Show("The number grade " + numberGrade + " has a letter grade of " + letterGrade);

        }

      
    }
}
