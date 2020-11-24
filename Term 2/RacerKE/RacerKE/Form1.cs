using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacerKE
{
    public partial class road : Form
    {
        int speed = 0;
        public road()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            moveLine(speed);
        }

        public void moveLine(int speed)
        {
            if (pictureBox1.Top >= 800)
            {
                pictureBox1.Top = -70;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 800)
            {
                pictureBox2.Top = -70;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 800)
            {
                pictureBox3.Top = -70;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 800)
            {
                pictureBox4.Top = -70;
            }
            else
            {
                pictureBox4.Top += speed;
            }
            if (pictureBox5.Top >= 800)
            {
                pictureBox5.Top = -70;
            }
            else
            {
                pictureBox5.Top += speed;
            }
            if (pictureBox6.Top >= 800)
            {
                pictureBox6.Top = -70;
            }
            else
            {
                pictureBox6.Top += speed;
            }
            if (pictureBox7.Top >= 800)
            {
                pictureBox7.Top = -70;
            }
            else
            {
                pictureBox7.Top += speed;
            }
            if (pictureBox8.Top >= 800)
            {
                pictureBox8.Top = -70;
            }
            else
            {
                pictureBox8.Top += speed;
            }

        }

        private void road_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (playerCar.Left > 0)
                {
                    playerCar.Left += -8;
                }
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (playerCar.Right < 400)
                {
                    playerCar.Left += 8;
                }
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (speed < 21)
                {
                    speed++;
                }
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (speed > -20)
                {
                    speed--;
                }
            }
        }
    }
}
