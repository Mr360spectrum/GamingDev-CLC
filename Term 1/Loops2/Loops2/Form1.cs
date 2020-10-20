using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runBttn_Click(object sender, EventArgs e)
        {
            //int count = 0;
            //while (count <= 100)
            //{
            //    outputLbl.Text = "Count = " + count;
            //    Console.WriteLine(count);
            //    MessageBox.Show("Count = " + count);
            //    count++;
            //}

            //String target = "Paper or plastic?";
            //for (int i = 0; i<target.Length; i++)
            //{
            //    outputLbl.Text = "count = " + i;
            //    Console.WriteLine(i);
            //    MessageBox.Show("Count = " + i);
            //}

            //for (int dayOfWeek = 0; dayOfWeek < 7; dayOfWeek++)
            //{
            //    outputLbl.Text = "Day: " + dayOfWeek;
            //    for (int hour = 0; hour < 24; hour++)
            //    {
            //        MessageBox.Show("Hour: " + hour);
            //        for (int minute = 0; minute < 60; minute++)
            //        {
            //            MessageBox.Show("Minute: " + minute);
            //            for (int sec = 0; sec < 60; sec++)
            //            {
            //                Console.WriteLine(sec);
            //            }
            //        }
            //    }
            //}

            String text = "Paper or plastic?";
            foreach (char letter in text)
            {
                MessageBox.Show(letter.ToString());
            }
        }
    }
}
