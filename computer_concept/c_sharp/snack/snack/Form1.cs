using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snack
{
    public partial class Form1 : Form
    {
        Point[] snkLct = new Point[100];
        int snkLen=5;
        int snkDrt=2;//Up=1,Right=2,Down=3,Left=4                                                                                                                                                                    
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void drawSnk()
        {
            Graphics g = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Red);

            for (int i = 1; i <= snkLen; i++)
                g.FillRectangle(brush, snkLct[i].X, snkLct[i].Y, 15, 15);
        }

        private void moveFood()
        {
            Random rnd = new Random();
            lblFood.Location = new Point(rnd.Next(1, 30) * 20, rnd.Next(1, 30) * 20);
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            int x = 0;                      //尾巴的x座標
            for (int i = 5; i >= 1; i--)    //由「尾巴」往「蛇頭」設座標
            {
                snkLct[i].X = x;            //0 20 40 60 80
                snkLct[i].Y = 40;
                x += 20;
            }

            drawSnk();
            moveFood();
            timer1.Enabled = true;
        }

        private void nextPos()
        {
            // for (int i = 2; i <= snkLen; i++) ->為何此寫法會造成錯誤？
            for (int i = snkLen; i >= 2; i--)
            {
                snkLct[i].X = snkLct[i - 1].X;
                snkLct[i].Y = snkLct[i - 1].Y;
            }

            if (snkDrt == 1)                //根據方向調整蛇頭的位置
                snkLct[1].Y -= 20;
            else if (snkDrt == 2)
                snkLct[1].X += 20;
            else if (snkDrt == 3)
                snkLct[1].Y += 20;
            else if (snkDrt == 4)
                snkLct[1].X -= 20;
        }

        private bool dead()
        {
            for (int i = 2; i <= snkLen; i++)
                if (snkLct[1].X == snkLct[i].X && snkLct[1].Y == snkLct[i].Y)
                    return true;

            if (snkLct[1].X > 600 || snkLct[1].X < 0 || snkLct[1].Y > 600 || snkLct[1].Y < 0)
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)    //此行不能自己打
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            nextPos();
            drawSnk();

            if (snkLct[1].X == lblFood.Location.X && snkLct[1].Y == lblFood.Location.Y) // 判斷是否吃到食物
            {
                snkLen++;
                score += 10;
                moveFood();
                //Q：為何不用設定增加的尾巴節座標？
            }
            label1.Text = score.ToString();//先新增一個label在Form1上

            if (dead())
            {
                timer1.Enabled = false;
                MessageBox.Show("GG! 分數：" + score);
            }
            //Q：玩第2次時，蛇長和方向如何恢復預設值？
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //此行不能自己打
        {
            if (e.KeyCode == Keys.Up)
                snkDrt = 1;
            else if (e.KeyCode == Keys.Right)
                snkDrt = 2;
            else if (e.KeyCode == Keys.Down)
                snkDrt = 3;
            else if (e.KeyCode == Keys.Left)
                snkDrt = 4;

            //Q：如何讓蛇不能回頭？
        }
    }
}



