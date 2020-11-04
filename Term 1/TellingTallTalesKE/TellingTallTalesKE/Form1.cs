/*
Karter Ence
Telling Tall Tales
10/28/2020
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

namespace TellingTallTalesKE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StoryButton_Click(object sender, EventArgs e)
        {
            //Reset the FinalStoryText
            FinalStoryText.Text = "";

            String myStoryText = "Once upon a time, there was a ";
            //Concatenate the strings together
            myStoryText += SpeciesComboBox.Text;
            myStoryText += " named ";
            myStoryText += nameTextBox.Text;
            myStoryText += ". This creature was always ";
            myStoryText += ActivityList.Text;
            if (checkBox1.Checked == true)
            {
                myStoryText += " and " + checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                myStoryText += " and " + checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                myStoryText += " and " + checkBox3.Text;
            }
            myStoryText += ". One day this creature saw a ";
            if (radioButton1.Checked)
            {
                myStoryText += radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                myStoryText += radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                myStoryText += radioButton3.Text;
            }
            myStoryText += "This was a " + GoodBadList.Text + " day.";

            FinalStoryText.Text = myStoryText;
        }
    }
}
