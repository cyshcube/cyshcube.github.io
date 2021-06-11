using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropDown
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int speed = 12, score = 0, gravity=8;
        bool goLeft, goRight;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            score = 0;
            timer1.Start();
            picPlayer.Top = 150;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //此行不可以自已打
        {
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
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) //此行不可以自已打
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;
            if (e.KeyCode == Keys.Right)
                goRight = false;
        }

        private void timer1_Tick(object sender, EventArgs e) //此行不可以自已打
        {
            label1.Text = "分數: " + score;

            if (goLeft && picPlayer.Left > 1)
                picPlayer.Left -= speed;
            if (goRight && picPlayer.Left + picPlayer.Width < panel1.Width)
                picPlayer.Left += speed;

            picPlayer.Top += gravity;   //讓picPlayer往下掉

            foreach (Control x in panel1.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    x.Top -= 5;                             //平台往上移動

                    if (x.Top < panel1.Top - x.Height)      //平台超出上邊界
                    {
                        x.Top = panel1.Height + x.Height;   //將平台位子重新設為下邊界
                        x.Width = rnd.Next(100, 350);       //改變平台寬度
                        score++;
                    }

                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))  //picPlayer碰到平台
                    {
                        gravity = 0;                                //不再往下掉
                        picPlayer.Top = x.Top - picPlayer.Height;   //重設picPlayer的Top為？使其可以站在平台上
                    }
                    else
                    {
                        gravity = 8;                                //沒碰到平台，則恢復往下掉
                    }
                }
            }

            if (picPlayer.Top < 0 || picPlayer.Top > panel1.Height)
                timer1.Stop();
            //Q：新增一個『重玩』的label，點擊後重新開始遊戲(timer1啟動，分數歸0，picPlay位置重設)

        }
    }
}

