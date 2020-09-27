/*
Karter Ence
Event Form
9/24/2020
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

namespace EventFormKE
{
    public partial class Main : Form
    {
        public Main()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text; //Get text from the text boxes
            string midName = textBox2.Text;
            string lastName = textBox3.Text;
            MessageBox.Show("Welcome to my game, " + name + " " + midName + " " + lastName + ".", "Welcome"); //Display a message box using the text from the text boxes
        }

        private void Main_Load(object sender, EventArgs e)
        {
            BackColor = Color.LemonChiffon;
            MessageBox.Show("Form loaded."); //Show a message when the program opens
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            MessageBox.Show("Text in textBox1 was changed."); //Show a message when the text in textBox1 is changed

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Font = new Font("Wingdings", 56); //Change the font of label2
            label2.Text = "Why are you clicking on me?"; //Change the text of label2
            MessageBox.Show("label2 clicked."); //Show a message when label2 is clicked
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Rude. Go back to school.";
            MessageBox.Show("label3 clicked.");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "Would you stop?";
            MessageBox.Show("label4 clicked.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string middleName = textBox2.Text;
            MessageBox.Show("Text in textBox2 was changed.");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string lastName = textBox3.Text;
            MessageBox.Show("Text in textBox3 was changed.");
            Console.WriteLine(lastName);
        }
    }
}
