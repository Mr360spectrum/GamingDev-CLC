/*
Karter Ence
What's your Birthday?
11/29/2020
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

namespace FindBirthdayKE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String FindDay(int year, int month, int day)
        {
            //Get the amount of days in a certain month of a certain year
            //If the given day exceeds the amount of days in that month, make the message reflect that
            int maxDays = DateTime.DaysInMonth(year, month);
            if (day > maxDays)
            {
                String message = "Invalid date.";
                return message;
            }
            else
            {
                //Get the moment in time with the given information
                DateTime birthdayDate = new DateTime(year, month, day);
                //Get the day of the week of the given date
                String dayOfWeek = birthdayDate.DayOfWeek.ToString();
                String message = "You were born on a " + dayOfWeek;
                return message;
            }
            
        }
       

        private void FindButton_Click(object sender, EventArgs e)
        {
            //Get values from numeric Up Downs and cast them to integers
            int year = (int)numericYear.Value;
            int month = (int)numericMonth.Value;
            int day = (int)numericDay.Value;

            //Get the message from the FindDay() method
            String message = FindDay(year, month, day);

            MessageBox.Show(message);
        }
    }
}
