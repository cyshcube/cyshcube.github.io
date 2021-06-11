using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            pictureBox1.BringToFront();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:	
                    pictureBox1.Image = imageList1.Images[3];
                    pictureBox1.Top -= 5;
                    break;
                case Keys.Down:	
                    pictureBox1.Image = imageList1.Images[0];
                    pictureBox1.Top += 5;
                    break;
                case Keys.Left:	
                    pictureBox1.Image = imageList1.Images[1];
                    pictureBox1.Left -= 5;
                    break;
                case Keys.Right:
                    pictureBox1.Image = imageList1.Images[2];
                    pictureBox1.Left += 5;
                    break;
            }
            //Q：如何不超出邊界？
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
        }

        public double getDistance(PictureBox a,PictureBox b)    //求兩物件距離
        {
            double x2 = Math.Pow(a.Left - b.Left, 2);
            double y2 = Math.Pow(a.Top - b.Top, 2);

            return Math.Sqrt(x2 + y2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top -= (pictureBox2.Top - pictureBox1.Top) / 10;
            pictureBox2.Left -= (pictureBox2.Left - pictureBox1.Left) / 10;
            
            double d = getDistance(pictureBox1, pictureBox2);
            label1.Text = pictureBox1.Left.ToString() + " " + pictureBox1.Top.ToString() + " " + d;

            if (d <= 15)
            {
                MessageBox.Show("GG!");
//                timer1.Enabled = false;
            }

            double cd = getDistance(pictureBox1, pictureBox3);
            if (cd < 15)
            {
                Random rnd = new Random();
                int x = rnd.Next(1, 701);
                int y = rnd.Next(1, 701);
                pictureBox2.Location = new Point(x, y);
                //pictureBox3.Visible = false;
            }
            //pictureBox1.BringToFront();

        }

    }
}

