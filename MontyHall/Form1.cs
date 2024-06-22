using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void Door2_Click(object sender, EventArgs e)
        {

        }
        int flag = 1;

        private void Door2_MouseClick(object sender, MouseEventArgs e)
        {
            flag *= -1;
            if (flag == -1)
            {
                // Door1.Enabled = true;
                Bitmap bitmap = new Bitmap(@"C:\Users\User\Documents\Resume\Doors\MontyHall\MontyHall\Resources\Car1.jpeg");
                BackgroundImage = new Bitmap(bitmap);

            }
            else
            {
                Bitmap bitmap = new Bitmap(@"C:\Users\User\Documents\Resume\Doors\MontyHall\MontyHall\Resources\Door1.jpeg");
            }
            Door2.BackgroundImage = null;
            BackGround.BackColor = Color.White;
            //BackColor = Color.Aqua;
        }


        private void Door1_Click(object sender, EventArgs e)
        {
            Door1.BackgroundImage = Door2.BackgroundImage;
        }


    }
}
