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
        int HEIGHT = 450;
        int WIDTH = 350;

        public Label nameLbl = new Label();
        public TextBox nameTxt = new TextBox();
        public Button buttonStart = new Button();
        public Label listLbl = new Label();
        public ListBox equipmentBox = new ListBox();
        public Label vehicleLbl = new Label();
        public ComboBox vehicleCombo = new ComboBox();

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
            this.nameLbl.Location = new System.Drawing.Point(WIDTH / 2-125, HEIGHT / 8 - 30);
            this.nameLbl.AutoSize = true;

            //Textbox setup
            this.nameTxt.Location = new System.Drawing.Point(WIDTH / 2 - 120, HEIGHT / 7 - 20);
            this.nameTxt.Size = new System.Drawing.Size(WIDTH - 125, 20);

            //Button setup
            this.buttonStart.Text = "Start";
            this.buttonStart.Location = new System.Drawing.Point(WIDTH / 2 - 120, HEIGHT / 2 + 100);
            this.buttonStart.Size = new System.Drawing.Size(WIDTH - 125, 50);
            //Create a new event handler for when the button is clicked
            this.buttonStart.Click += new EventHandler(buttonStart_Click);

            //Box label setup
            this.listLbl.Text = "Select your starting equipment:";
            this.listLbl.Location = new System.Drawing.Point(WIDTH / 2 - 120, HEIGHT / 5);
            this.listLbl.Size = new System.Drawing.Size(WIDTH - 125, 20);

            //ListBox setup
            this.equipmentBox.Items.Add("Utility Belt");
            this.equipmentBox.Items.Add("Rocket Boots");
            this.equipmentBox.Items.Add("Hockey Mask");
            this.equipmentBox.Items.Add("Rubber Ducky");
            this.equipmentBox.Location = new System.Drawing.Point(WIDTH / 2 - 120, HEIGHT / 4);
            this.equipmentBox.Size = new System.Drawing.Size(WIDTH - 125, 100);

            //Vehicle label setup
            this.vehicleLbl.Text = "Select your starting vehicle:";
            this.vehicleLbl.Location = new System.Drawing.Point(WIDTH / 2 - 120, HEIGHT / 2);
            this.vehicleLbl.Size = new System.Drawing.Size(WIDTH - 125, 20);

            //Vehicle ComboBox setup
            this.vehicleCombo.Items.Add("Turbo Car");
            this.vehicleCombo.Items.Add("Space Plane");
            this.vehicleCombo.Items.Add("Stealth Sub");
            this.vehicleCombo.Items.Add("Pogo Stick");
            this.vehicleCombo.Location = new System.Drawing.Point(WIDTH / 2 - 120, HEIGHT / 2 + 20);
            this.vehicleCombo.Size = new System.Drawing.Size(WIDTH - 125, 20);

            //Add controls to form
            this.Controls.Add(nameLbl);
            this.Controls.Add(nameTxt);
            this.Controls.Add(buttonStart);
            this.Controls.Add(equipmentBox);
            this.Controls.Add(listLbl);
            this.Controls.Add(vehicleLbl);
            this.Controls.Add(vehicleCombo);
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Concatenate strings
            String message = "Your player name is: " + nameTxt.Text + ". You have chosen the equipment " +
                equipmentBox.SelectedItem + " and the vehicle " + vehicleCombo.SelectedItem + ".";
            MessageBox.Show(message);

            //Reset selections
            nameTxt.Text = "";
            equipmentBox.SelectedIndex = -1;
            vehicleCombo.SelectedIndex = -1;
        }
    }
}
