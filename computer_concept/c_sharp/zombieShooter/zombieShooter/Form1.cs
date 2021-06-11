using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zombieShooter
{
    public partial class Form1 : Form
    {
        bool goUp, goDown, goLeft, goRight;
        int playerSpeed = 10, zombieSpeed = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //不能自已打！屬性視窗/form1/事件，KeyDown雙擊
        {
            //label1.Text = e.KeyCode.ToString();
            //label1.Text = e.KeyValue.ToString();
            //if (e.KeyValue==38)
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                picPlayer.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                picPlayer.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                picPlayer.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                picPlayer.Image = Properties.Resources.down;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;
            if (e.KeyCode == Keys.Right)
                goRight = false;
            if (e.KeyCode == Keys.Up)
                goUp = false;
            if (e.KeyCode == Keys.Down)
                goDown = false;
        }

        private double calcDist(PictureBox a, PictureBox b)
        {
            double xSquare = (a.Left - b.Left) * (a.Left - b.Left);
            double ySquare = (a.Top - b.Top) * (a.Top - b.Top);
            double ans = Math.Sqrt(xSquare + ySquare);
            return ans;
        //  return Math.Sqrt((a.Left - b.Left) * (a.Left - b.Left) + (a.Top - b.Top) * (a.Top - b.Top));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goLeft && picPlayer.Left > 0)
            //  picPlayer.Left = picPlayer.Left - playerSpeed;
                picPlayer.Left -= playerSpeed;
            if (goRight && picPlayer.Left + picPlayer.Width < 930)
                picPlayer.Left += playerSpeed;
            if (goUp && picPlayer.Top > 0)
                picPlayer.Top -= playerSpeed;
            if (goDown && picPlayer.Top + picPlayer.Height < 700)
                picPlayer.Top += playerSpeed;
            
            //Q：只能向右、向下各一次？
            //Q：如何防止跑出邊界？

/*         穿越
           if (goLeft)
                picPlayer.Left -= playerSpeed;
            if (goRight)
                picPlayer.Left += playerSpeed;
            if (goUp)
                picPlayer.Top -= playerSpeed;
            if (goDown)
                picPlayer.Top += playerSpeed;

            if (picPlayer.Left > this.Width-picPlayer.Width)
                picPlayer.Left = 0;
            if (picPlayer.Left < 0 )
                picPlayer.Left = this.Width-picPlayer.Width;
            if (picPlayer.Top > this.Height - picPlayer.Height)
                picPlayer.Top = 0;
            if (picPlayer.Top < 0)
                picPlayer.Top = this.Height - picPlayer.Height;
*/

            if (picZombie.Left > picPlayer.Left)
            {
                picZombie.Left -= zombieSpeed;
                picZombie.Image = Properties.Resources.zleft;
            }
            if (picZombie.Left < picPlayer.Left) 
            {
                picZombie.Left += zombieSpeed;
                picZombie.Image = Properties.Resources.zright;
            }

            if (picZombie.Top > picPlayer.Top)
            {
                picZombie.Top -= zombieSpeed;
                picZombie.Image = Properties.Resources.zup;
            }
            if (picZombie.Top < picPlayer.Top) 
            {
                picZombie.Top += zombieSpeed;
                picZombie.Image = Properties.Resources.zdown;
            }
            //Q：zombie喀藥？

            if (picPlayer.Bounds.IntersectsWith(picZombie.Bounds))
            {
                MessageBox.Show("GG!");
                timer1.Enabled = false;
                //timer1.Stop();
            }
            if (picPlayer.Bounds.IntersectsWith(picCastle.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("You are safe!");
            }

        }


    }
}


