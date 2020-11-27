using System;
using System.Drawing;
using System.Windows.Forms;

namespace RacerKE
{
    public partial class road : Form
    {
        //Initialize variables and random object
        int speed = 0;
        Random random = new Random();
        int score = 0;
        int laserPow = 0;
        
        public road()
        {
            InitializeComponent();
            //Make gameOverLbl not visible and initialize score
            gameOverLbl.Visible = false;
            laser.Visible = false;
            score = 0;
        }

        public void gameOver()
        {
            //Check to see if the player collides with enemy cars
            if (playerCar.Bounds.IntersectsWith(enemyCar1.Bounds) || playerCar.Bounds.IntersectsWith(enemyCar2.Bounds)
                || playerCar.Bounds.IntersectsWith(enemyCar3.Bounds))
            {
                //Stop the game and prevent the player from moving
                gameLoop.Enabled = false;
                speed = 0;
                //Show the gameOverLbl
                gameOverLbl.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //Move objects and check for collisions every single tick
            moveLine(speed);
            enemy1(speed);
            enemy2(speed);
            enemy3(speed);
            collectable1(speed);
            collectable2(speed);
            collectable3(speed);
            
            //Only move the laser if it is on screen
            if (laser.Visible == true)
            {
                moveLaser();
            }

            gameOver();
        }

        public void enemy1(int speed)
        {
            //If the enemy car goes off screen, move it back above the screen at a random point
            if (enemyCar1.Top >= 800)
            {
                int x = random.Next(25, 275);
                int y = random.Next(-100, 0);
                enemyCar1.Location = new Point(x, y);
            }
            else
            {
                //change the car's speed at the rate of "speed"
                enemyCar1.Top += Convert.ToInt32(Math.Round((double)(speed / 2)));
            }
        }

        public void enemy2(int speed)
        {
            if (enemyCar2.Top >= 800)
            {
                
                int x = random.Next(25, 275);
                int y = random.Next(-100, 0);
                enemyCar2.Location = new Point(x, y);
            }
            else
            {
                enemyCar2.Top += Convert.ToInt32(Math.Round((double)(speed / 2)));
            }
        }

        public void enemy3(int speed)
        {
            if (enemyCar3.Top >= 800)
            {
                int x = random.Next(25, 275);
                int y = random.Next(-100, 0);
                enemyCar3.Location = new Point(x, y);
            }
            else
            {
                enemyCar3.Top += Convert.ToInt32(Math.Round((double)(speed / 2)));
            }
        }

        //If the tire goes off the screen, move it back above the screen at a random point
        public void collectable1(int speed)
        {
            if (tire1.Top >= 800)
            {
                int x = random.Next(25, 275);
                int y = random.Next(-100, 0);
                tire1.Location = new Point(x, y);
            }
            else
            {
                //Change the tire's speed
                 tire1.Top += Convert.ToInt32(Math.Round((double)(speed / 2)));
            }
            
            //Check for collision between tire and player
            if (playerCar.Bounds.IntersectsWith(tire1.Bounds))
            {
                //Increase score by 1
                score++;
                //Update score label
                scoreLbl.Text = "Score:" + score.ToString();
                //Change location of tire
                int x = random.Next(25, 330);
                int y = random.Next(-100, 0);
                tire1.Location = new Point(x, y);
                laserPow += 1;
                laserLbl.Text = laserPow.ToString();
            }
        }

        public void collectable2(int speed)
        {
            if (tire2.Top >= 800)
            {
                int x = random.Next(25, 275);
                int y = random.Next(-100, 0);
                tire2.Location = new Point(x, y);
            }
            else
            {
                tire2.Top += Convert.ToInt32(Math.Round((double)(speed / 2)));
            }

            //Check for collision between tire and player
            if (playerCar.Bounds.IntersectsWith(tire2.Bounds))
            {
                //Increase score by 1
                score += speed;
                //Update score label
                scoreLbl.Text = "Score:" + score.ToString();
                //Change location of tire
                int x = random.Next(25, 330);
                int y = random.Next(-100, 0);
                tire2.Location = new Point(x, y);
                laserPow += 1;
                laserLbl.Text = laserPow.ToString();
            }
        }

        public void collectable3(int speed)
        {
            if (tire3.Top >= 800)
            {
                int x = random.Next(25, 275);
                int y = random.Next(-100, 0);
                tire3.Location = new Point(x, y);
            }
            else
            {
                tire3.Top += Convert.ToInt32(Math.Round((double)(speed / 2)));
            }

            //Check for collision between tire and player
            if (playerCar.Bounds.IntersectsWith(tire3.Bounds))
            {
                //Increase score by 1
                score++;
                //Update score label
                scoreLbl.Text = "Score:" + score.ToString();
                //Change location of tire
                int x = random.Next(25, 330);
                int y = random.Next(-100, 0);
                tire3.Location = new Point(x, y);
                laserPow += 1;
                laserLbl.Text = laserPow.ToString();
            }
        }

        //Make the laser visible and put it above the player's car
        public void shoot()
        {
            laser.Visible = true;
            laser.Location = new Point(playerCar.Location.X + 17, playerCar.Location.Y - 33);
            laserPow -= 3;
        }

        public void moveLaser()
        {
            //Move the laser up the screen and check for collisions with enemies
            laser.Top -= 5;
            if (laser.Bounds.IntersectsWith(enemyCar1.Bounds))
            {
                laser.Visible = false;
                int x = random.Next(25, 275);
                int y = random.Next(-100, 0);
                enemyCar1.Location = new Point(x, y);
            }
            
            if (laser.Bounds.IntersectsWith(enemyCar2.Bounds))
            {
                laser.Visible = false;
                int x = random.Next(25, 275);
                int y = random.Next(-100, 0);
                enemyCar2.Location = new Point(x, y);
            }

            if (laser.Bounds.IntersectsWith(enemyCar3.Bounds))
            {
                laser.Visible = false;
                int x = random.Next(25, 275);
                int y = random.Next(-100, 0);
                enemyCar3.Location = new Point(x, y);
            }

            if (laser.Top <= -30)
            {
                laser.Visible = false;
            }
        }

        //Move white center lines
        //If they go off the screen, move them back above the screen
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

        //Check for input
        private void road_KeyDown(object sender, KeyEventArgs e)
        {
            //Move playerCar left
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                //Only move left if speed is not 0
                if (speed != 0)
                {
                    if (playerCar.Left > 0)
                    {
                        playerCar.Left += -8;
                    }
                } 
            }
            //Move playerCar right
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                //Only move right if speed is not 0
                if (speed != 0)
                {
                    if (playerCar.Right < 400)
                    {
                        playerCar.Left += 8;
                    }
                }
            }
            //Increase speed
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (speed < 21)
                {
                    speed++;
                    if (speed == 1)
                    {
                        speed = 2;
                    }
                }
            }
            //Decrease speed
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (speed > -20)
                {
                    speed--;
                    if (speed == 1)
                    {
                        speed = 0;
                    }
                }
            }

            //Only allow shooting if the game over label is not visible and if laserPow is greater than or equal to 3
            if (e.KeyCode == Keys.Space)
            {
                if (gameOverLbl.Visible != true)
                {
                    if (laserPow >= 3)
                    {
                        shoot();
                    }
                }
            }
        }
    }
}
