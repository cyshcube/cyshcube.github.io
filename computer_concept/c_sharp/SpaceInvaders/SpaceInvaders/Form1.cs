using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        bool goLeft,goRight,isPressed; 
        int speed = 5, score = 0, playerSpeed = 6; 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.bullet;
            bullet.Size = new Size(5, 20);
            bullet.Tag = "bullet";
            bullet.Left = picPlayer.Left + picPlayer.Width / 2;
            bullet.Top = picPlayer.Top - 20;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) 
                goLeft = true; 
            if (e.KeyCode == Keys.Right) 
                goRight = true;
            if (e.KeyCode == Keys.Space && !isPressed)
            {
                isPressed = true;
                makeBullet();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) 
                goLeft = false; 
            if (e.KeyCode == Keys.Right) 
                goRight = false;
            if (isPressed)
                isPressed = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goLeft) 
                picPlayer.Left -= playerSpeed; 
            else if (goRight) 
                picPlayer.Left += playerSpeed;

            foreach (Control b in this.Controls)
            {
                if (b is PictureBox && b.Tag == "bullet")
                {
                    b.Top -= 20;
                    if (((PictureBox)b).Top < this.Height - 490)
                        this.Controls.Remove(b);
                }
            }
            //Q：如何連發？

            foreach (Control s in this.Controls)
            {
                if (s is PictureBox && s.Tag == "invaders")
                {
                    if (((PictureBox)s).Bounds.IntersectsWith(picPlayer.Bounds))
                        timer1.Stop();

                    ((PictureBox)s).Left += speed;
                    if (((PictureBox)s).Left > 720)
                    {
                        ((PictureBox)s).Top += ((PictureBox)s).Height + 10;
                        ((PictureBox)s).Left = -50;
                    }
                }
            }

            foreach (Control i in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (i is PictureBox && i.Tag == "invaders" && j is PictureBox && j.Tag == "bullet" && i.Bounds.IntersectsWith(j.Bounds))
                    {
                        score++;
                        this.Controls.Remove(i);
                        this.Controls.Remove(j);
                    }
                }
            }

            label1.Text = "Score : " + score;

        }



    }
}
