using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Debug_Program
{
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
        }

        private void ErrorButton_Click(object sender, EventArgs e)
        {
            // Create a string variable
            String myDay = "";

            // Create a date/time variable and initialize to the current date and time
            DateTime currentDate = DateTime.Now;

           
            //Set myDay to the current day of the week
            myDay = currentDate.DayOfWeek.ToString();
            

            // If myDay is 'Monday', display a special message
            if (myDay.Equals("Monday"))
            {
                MessageBox.Show("It is Monday!");
            }
            else //if myDay is not Monday, just display the day
            {
                MessageBox.Show("The current day is: " + myDay);
            }

        }
    }
}
