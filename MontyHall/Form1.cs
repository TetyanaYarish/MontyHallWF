using Monty_Hall;
using MontyHall.Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontyHall
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool dragging, lose;
        //Game game;
        bool firstClick = true;
        //RunTheGame runGame;
        object n1 = null;
        //RandomPrizeGenerator prizeGenerator = new RandomPrizeGenerator();
        Bitmap bitmap = new Bitmap(@"C:\Users\User\Documents\Resume\Doors\MontyHall\MontyHall\Resources\Car1.jpeg");
        Bitmap bitmapGoat = new Bitmap(@"C:\Users\User\Documents\Resume\Doors\MontyHall\MontyHall\Resources\Goat.jpeg");
        int rndDor = RandomDoorGenerator();
        public Form1()
        {
            InitializeComponent();
            //game = new Game();
            //runGame = new RunTheGame();
            //prizeGenerator = new RandomPrizeGenerator();
            playerChoise.Visible = false;
            textPlayerLost.Visible = false;
            textPlayerWon.Visible = false;
        }
        RandomPrizeGenerator randomGenerator = new RandomPrizeGenerator();
        
        private void Door1_Click(object sender, EventArgs e)
        {
            n1 = randomGenerator.YourPrize();
            if (firstClick)
            {
              //  n1 = randomGenerator.YourPrize();
                if (rndDor == 1)
                    Door2.Image = bitmapGoat;
                if (rndDor == 2)
                    Door3.Image = bitmapGoat;
                firstClick = false;
                playerChoise.Visible = true;

            }
            else
            {
                playerChoise.Visible = false;
                if (n1 == "Luxury car")
                {
                   Door1.Image = bitmap;
                    if (rndDor == 2)
                        Door2.Image = bitmapGoat;
                    if (rndDor == 1)
                        Door3.Image = bitmapGoat;
                    textPlayerWon.Visible = true;
                }
                else if(n1 == "Goat")
                {
                    Door1.Image = bitmapGoat;
                    if (rndDor  == 2)
                        Door2.Image = bitmap;
                    if (rndDor == 1)
                        Door3.Image = bitmap;
                    textPlayerLost.Visible = true;
                }

            }
          
        }
        private static int RandomDoorGenerator()
        {
            Random rnd = new Random();
            int rndDoor = rnd.Next(1, 3);
            return rndDoor;
        }

        private void Door2_Click(object sender, EventArgs e)
        {
            n1 = randomGenerator.YourPrize();
            if (firstClick)
            {
                //n1 = randomGenerator.YourPrize();
                if (rndDor == 1)
                    Door1.Image = bitmapGoat;
                if (rndDor == 2)
                    Door3.Image = bitmapGoat;
                firstClick = false;
                playerChoise.Visible = true;

            }
            else
            {
                playerChoise.Visible = false;
                if (n1 == "Luxury car")
                {
                    Door2.Image = bitmap;
                    if (rndDor == 2)
                        Door1.Image = bitmapGoat;
                    if (rndDor == 1)
                        Door3.Image = bitmapGoat;
                    textPlayerWon.Visible = true;
                }
                else if (n1 == "Goat")
                {
                    Door2.Image = bitmapGoat;
                    if (rndDor == 1)
                        Door1.Image = bitmap;
                    if (rndDor == 2)
                        Door3.Image = bitmap;
                    //if (rndDor == 2)
                    //    Door1.Image = bitmap;
                    //if (rndDor == 1)
                    //    Door3.Image = bitmap;
                    textPlayerLost.Visible = true;
                }

            }
        }

        private void BackGround_MouseClick(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y );
            }

        }

        private void Form1_Load(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y);
            }


        }


        private void Door3_Click(object sender, EventArgs e)
        {
            n1 = randomGenerator.YourPrize();
            if (firstClick)
            {
               // n1 = randomGenerator.YourPrize();
                if (rndDor == 1)
                    Door2.Image = bitmapGoat;
                if (rndDor == 2)
                    Door1.Image = bitmapGoat;
                firstClick = false;
                playerChoise.Visible = true;

            }
            else
            {
                playerChoise.Visible = false;
                if (n1 == "Luxury car")
                {
                    Door3.Image = bitmap;
                    if (rndDor == 2)
                        Door2.Image = bitmapGoat;
                    if (rndDor == 1)
                        Door1.Image = bitmapGoat;
                    textPlayerWon.Visible = true;
                }
                else if (n1 == "Goat")
                {
                    Door3.Image = bitmapGoat;
                    if (rndDor == 2)
                        Door2.Image = bitmap;
                    if (rndDor == 1)
                        Door1.Image = bitmap;
                    textPlayerLost.Visible = true;
                }

            }

            // this.Close();
        }

      
    }
}
