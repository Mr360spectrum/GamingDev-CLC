using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_GUI
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void creatorName_Click(object sender, EventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            nameMessage.Text = "Changed on startup.";
           
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(ageSpn.Value);
            ageLabel.Text = Convert.ToString(age);
            pictureBox.Image = Windows_GUI.Properties.Resources.house;
            if (progressBar.Value != 100) 
            {
                progressBar.Value += 10;
            }
        }
    }
}
