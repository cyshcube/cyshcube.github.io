using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Rex_Endless_Runner
{
    public partial class Form1 : Form
    {
        public static readonly int JUMPSPEED_INIT = 15;
        public static readonly int FORCE_INIT = 12;
        public static readonly int CACTUSSPEED_INIT = 10;

        bool jumping = false;
        int jumpSpeed = JUMPSPEED_INIT; //跳的高度
        int force = FORCE_INIT;         //按空白的力量，即按空白的時間
        int score = 0;
        int cactusSpeed = CACTUSSPEED_INIT;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) //此行不可自己輸入
        {
            lblScore.Text = score.ToString();
            picTrex.Top += jumpSpeed;           //不斷的向下掉

            if (jumping && force > 0)
            {
                jumpSpeed = -JUMPSPEED_INIT;    //向上為-
                force -= 1;                     //按住空白鍵會一直往上跳，所以設一個變數表示能連續按空白鍵的時間，此變數要不斷減少。
            }
            else
            {
                jumpSpeed = JUMPSPEED_INIT;

                if (picTrex.Top >= 390)
                {
                    picTrex.Top = picFloor.Top - picTrex.Height;
                    jumpSpeed = 0;
                    force = FORCE_INIT;
                }

            }
            //Q：如何跳高一點？

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "cactus")
                {
                    x.Left -= cactusSpeed;
                    if (x.Left + x.Width < -100) //仙人掌的右邊界
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 900);
                        score++;
                    }

                    if (picTrex.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        picTrex.Image = Properties.Resources.dead;
                        lblScore.Text += " Press R to restart";
                    }

                }
            }
            //Q：調參數
        }

        public void resetGame()
        {
            score = 0;
            picCactus1.Left = rnd.Next(400, 500);
            picCactus2.Left = rnd.Next(600, 800);
            picTrex.Image = Properties.Resources.running;
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //此行不可自己輸入
        {
            if (e.KeyCode == Keys.Space && !jumping)
                jumping = true;
            if (e.KeyCode == Keys.R)
                resetGame();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) //此行不可自己輸入
        {
            if (jumping)
                jumping = false;
        }
    }
}
