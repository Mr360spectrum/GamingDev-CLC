/*
Karter Ence
Player One (Chapter 6)
10/26/2020
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

namespace PlayerOneChapter6KE
{
    public partial class Form1 : Form
    {
        int HEIGHT = 300;
        int WIDTH = 350;

        public Label nameLbl = new Label();
        public TextBox nameTxt = new TextBox();
        public Button buttonStart = new Button();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form setup
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Size = new System.Drawing.Size(WIDTH, HEIGHT);
            this.Text = "Player One";

            //Label setup
            this.nameLbl.Text = "Enter your player name:";
            this.nameLbl.Location = new System.Drawing.Point(WIDTH / 2-125, HEIGHT / 4);
            this.nameLbl.AutoSize = true;

            //Textbox setup
            this.nameTxt.Location = new System.Drawing.Point(WIDTH / 2 - 120, HEIGHT / 4 + 20);
            this.nameTxt.Size = new System.Drawing.Size(WIDTH - 125, 20);

            //Button setup
            this.buttonStart.Text = "Start";
            this.buttonStart.Location = new System.Drawing.Point(WIDTH / 2 - 120, HEIGHT / 2);
            this.buttonStart.Size = new System.Drawing.Size(WIDTH - 125, 50);
            //Create a new event handler for when the button is clicked
            this.buttonStart.Click += new EventHandler(buttonStart_Click);

            //Add controls to form
            this.Controls.Add(nameLbl);
            this.Controls.Add(nameTxt);
            this.Controls.Add(buttonStart);
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your player name is: " + nameTxt.Text);
            nameTxt.Text = "";
        }
    }
}
