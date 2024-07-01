
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontyHall
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool dragging, lose, firstDoor, secondDoor, thirdDoor;
        SoundPlayer goatSound = new SoundPlayer("C:..\\..\\Resources\\goat-sound.wav\r\n");
        SoundPlayer successSound = new SoundPlayer("C:..\\..\\Resources\\success.wav\r\n");
        bool firstClick = true;
        string n1;
        Bitmap bitmap = new Bitmap(@"C:\Users\User\Documents\Resume\Doors\MontyHall\MontyHall\Resources\Car1.jpeg");
        Bitmap bitmapGoat = new Bitmap(@"C:\Users\User\Documents\Resume\Doors\MontyHall\MontyHall\Resources\Goat.jpeg");
        int rndDor = RandomDoorGenerator();
        public Form1()
        {
            InitializeComponent();
            playerChoise.Visible = false;
            textPlayerLost.Visible = false;
            textPlayerWon.Visible = false;
            n1 = randomGenerator.YourPrize();
        }
        RandomPrizeGenerator randomGenerator = new RandomPrizeGenerator();
        private void Congratulation()
        {

            textPlayerWon.Visible = true;
            successSound.Play();
        }        
        private void Looser()
        {

            textPlayerLost.Visible = true;
            goatSound.Play();
        }
        private void Door1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(n1);


            if (firstClick)
            {
                if (rndDor == 1)
                    Door3.Image = bitmapGoat;
                if (rndDor == 2)
                    Door2.Image = bitmapGoat;
                firstClick = false;
                playerChoise.Visible = true;
                goatSound.Play();
                wellcomeMSG2.Visible = false;
                firstDoor = true;

            }
            else
            {
                wellcomeMSG1.Visible = false;
                playerChoise.Visible = false;
                if (firstDoor)
                {
                    if (n1 == "Luxury car")
                    {
                        Door1.Image = bitmap;
                        Door3.Image = bitmapGoat;
                        Door2.Image = bitmapGoat; Congratulation();
                    }
                    else if (n1 == "Goat")
                    {
                        Door1.Image = bitmapGoat;
                        if (rndDor == 2)
                            Door3.Image = bitmap;
                        if (rndDor == 1)
                            Door2.Image = bitmap;
                        Looser();
                    }
                }

                else if (rndDor == 1 || rndDor==2 && n1 == "Goat") //change the door and player won
                {
                    Door1.Image = bitmap;
                    Door2.Image = bitmapGoat;
                    Door3.Image = bitmapGoat;
                    Congratulation();
                }


                else if (n1 == "Luxury car" && rndDor == 2)//change the door and player loose
                {
                    Door2.Image = bitmap;
                    Door1.Image = bitmapGoat;
                    Door3.Image = bitmapGoat;
                    Looser();
                }
                else if (n1 == "Luxury car" && rndDor == 1)//change the door and player loose
                {
                    Door2.Image = bitmap;
                    Door1.Image = bitmapGoat;
                    Door3.Image = bitmapGoat;
                    Looser();
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
            Console.WriteLine(n1);

            //n1 = randomGenerator.YourPrize();
            if (firstClick)
            {
                if (rndDor == 1)
                    Door1.Image = bitmapGoat;
                if (rndDor == 2)
                    Door3.Image = bitmapGoat;
                firstClick = false;
                playerChoise.Visible = true;
                goatSound.Play();
                wellcomeMSG2.Visible = false;
                secondDoor = true;
            }
            else
            {
                wellcomeMSG1.Visible = false;
                playerChoise.Visible = false;

                if (secondDoor)
                {
                    if (n1 == "Goat")
                    {
                        Door2.Image = bitmapGoat;
                        if (rndDor == 1)
                            Door3.Image = bitmap;

                        if (rndDor == 2)
                            Door1.Image = bitmap;
                        Looser();
                    }
                    else if (n1 == "Luxury car")
                    {
                        Door2.Image = bitmap;
                        Door3.Image = bitmapGoat;
                        Door1.Image = bitmapGoat;
                        Congratulation();
                    }
                }

                else if (rndDor == 1 || rndDor == 2 && n1 == "Goat") //change the door and player won
                {
                    Door2.Image = bitmap;
                    Door1.Image = bitmapGoat;
                    Door3.Image = bitmapGoat;
                    Congratulation();
                }
                else if (n1 == "Luxury car" && rndDor == 2)//change the door and player loose
                {
                    Door1.Image = bitmap;
                    Door2.Image = bitmapGoat;
                    Door3.Image = bitmapGoat;
                    Looser();
                }
                else if (n1 == "Luxury car" && rndDor == 1)//change the door and player loose
                {
                    Door3.Image = bitmap;
                    Door1.Image = bitmapGoat;
                    Door2.Image = bitmapGoat;
                    Looser();
                }
            }
        }
        private void Door3_Click(object sender, EventArgs e)
        {

            if (firstClick)
            {
                if (rndDor == 1)
                    Door1.Image = bitmapGoat;
                else if (rndDor == 2)
                    Door2.Image = bitmapGoat;
                firstClick = false;
                playerChoise.Visible = true;
                goatSound.Play();
                wellcomeMSG2.Visible = false;
                thirdDoor = true;
            }
            else
            {
                wellcomeMSG1.Visible = false;
                playerChoise.Visible = false;
                if (thirdDoor)
                {
                    if (n1 == "Luxury car")
                    {
                        Door3.Image = bitmap;
                        Door2.Image = bitmapGoat;
                        Door1.Image = bitmapGoat;
                        Congratulation();
                    }
                    else if (n1 == "Goat")
                    {
                        Door3.Image = bitmapGoat;
                        if (rndDor == 2)
                            Door1.Image = bitmap;
                        else if (rndDor == 1)
                            Door2.Image = bitmap;
                        Looser();
                    }
                }
                else if (rndDor == 1 || rndDor == 2 && n1 == "Goat") //change the door and player won
                {
                    Door3.Image = bitmap;
                    Door2.Image = bitmapGoat;
                    Door1.Image = bitmapGoat;
                    Congratulation();
                }


                else if (n1 == "Luxury car" && rndDor == 2)//change the door and player loose
                {
                    Door1.Image = bitmap;
                    Door2.Image = bitmapGoat;
                    Door3.Image = bitmapGoat;
                    Looser();
                }
                else if (n1 == "Luxury car" && rndDor == 1)//change the door and player loose
                {
                    Door2.Image = bitmap;
                    Door1.Image = bitmapGoat;
                    Door3.Image = bitmapGoat;
                    Looser();
                }
            }
        }
            private void BackGround_MouseClick(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y);
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

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
