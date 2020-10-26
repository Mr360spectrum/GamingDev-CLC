/*
Karter Ence
App Order Form
10/26/2020
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppOrderFormKE
{
    public partial class Form1 : Form
    {
        int HEIGHT = 500;
        int WIDTH = 500;

        public TextBox txtBox = new TextBox();
        public Label nameLbl = new Label();
        public Button bttn1 = new Button();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form setup
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.BackColor = Color.CornflowerBlue;
            this.ForeColor = Color.Black;
            this.Size = new System.Drawing.Size(WIDTH, HEIGHT);
            this.Text = "Form Setup";
            this.StartPosition = FormStartPosition.CenterScreen;

            //Textbox setup
            this.txtBox.Text = "Enter your name:";
            this.txtBox.Location = new System.Drawing.Point((WIDTH/2)-50, (HEIGHT/4)-25);
            this.txtBox.Size = new System.Drawing.Size(100, 50);
            this.txtBox.Visible = true;
            this.txtBox.Enabled = true;
            this.txtBox.Multiline = true;
            this.txtBox.ScrollBars = ScrollBars.Vertical;
            this.txtBox.TextChanged += new EventHandler(txtBox_TextChanged);
            this.txtBox.MouseHover += new EventHandler(txtBox_MouseHover);

            //Label setup
            this.nameLbl.Location = new System.Drawing.Point(WIDTH / 2 - 50, (HEIGHT / 4 - 50));
            this.Visible = true;
            this.nameLbl.Text = "Starting text";

            //Button setup
            this.bttn1.Text = "Button";
            this.bttn1.Location = new System.Drawing.Point(0, 0);
            this.bttn1.Size = new System.Drawing.Size(100, 50);
            this.bttn1.BackColor = Color.White;
            
            //Add controls to form
            this.Controls.Add(txtBox);
            this.Controls.Add(nameLbl);
            this.Controls.Add(bttn1);
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            this.nameLbl.Text = this.txtBox.Text;
        }

        private void txtBox_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Your mouse is on the box.");
        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
