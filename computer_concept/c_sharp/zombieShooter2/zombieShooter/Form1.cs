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
        bool goUp,goDown,goLeft,goRight; 
        int playerSpeed = 10, zombieSpeed = 3, playerBlood = 100, score = 0, bulletNum=10 , ammoNum = 0;  
        string facing = "right";

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void tmrAmmo_Tick(object sender, EventArgs e)
        {
            //   Q：如何限製畫面中最多只有3個彈匣？
            //   方法一：宣告一個計錄彈匣數的區域變數ammoNum(初值為0)，每次產生彈匣前，都重新計算畫面中的彈匣數量，如果<3，才產生彈匣。
            //   方法二：宣告一個計錄彈匣數的全域變數ammoNum(初值為0)，當產生彈匣時 + 1，玩家拿到彈匣時 - 1。 

            if (ammoNum<3)  // 如果彈匣數量 <3
            {
                PictureBox picAmmo = new PictureBox();
                picAmmo.Tag = "ammo";
                picAmmo.Image = Properties.Resources.ammo;
                picAmmo.Location = new Point(rnd.Next(0, 900), rnd.Next(0, 700));
                picAmmo.Size = new Size(50, 50);
                picAmmo.SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(picAmmo);
                picPlayer.BringToFront();
                ammoNum++;  //彈匣數量+1
            }
        }

        private void tmrZombie_Tick(object sender, EventArgs e)
        {
            PictureBox picZombie = new PictureBox();
            picZombie.Tag = "zombie";
            picZombie.Image = Properties.Resources.zdown;
            picZombie.Location = new Point(rnd.Next(0, 900), rnd.Next(0, 700));
            picZombie.Size = new Size(50, 50);
            picZombie.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(picZombie);
            picPlayer.BringToFront();
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
                facing = "left";
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                picPlayer.Image = Properties.Resources.right;
                facing = "right";
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                picPlayer.Image = Properties.Resources.up;
                facing = "up";
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                picPlayer.Image = Properties.Resources.down;
                facing = "down";
            }
            if (e.KeyCode == Keys.Space && bulletNum > 0)       //如果按了空白鍵 而且 子彈數 > 0 時，才能發射。(宣告一個全域變數bulletNum，初值設為0)
            {
                ClassBullet shoot = new ClassBullet();
                shoot.direction = facing;
                shoot.x = picPlayer.Left + (picPlayer.Width / 2);
                shoot.y = picPlayer.Top + (picPlayer.Height / 2);
                shoot.makeBullet(this);
                bulletNum--;                                    //子彈數量減1。
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
            //  pipicPlayer.Left = pipicPlayer.Left - playerSpeed;
                picPlayer.Left -= playerSpeed;
            if (goRight && picPlayer.Left + picPlayer.Width < 930)
                picPlayer.Left += playerSpeed;
            if (goUp && picPlayer.Top > 0)
                picPlayer.Top -= playerSpeed;
            if (goDown && picPlayer.Top + picPlayer.Height < 700)
                picPlayer.Top += playerSpeed;
            //Q：如何防止跑出邊界？
            //Q：只能向右、向下各一次？

            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && z.Tag == "zombie")
                {
                    if (((PictureBox)z).Left > picPlayer.Left)
                    {
                        ((PictureBox)z).Left -= zombieSpeed;
                        ((PictureBox)z).Image = Properties.Resources.zleft;
                    }
                    if (((PictureBox)z).Left < picPlayer.Left)
                    {
                        ((PictureBox)z).Left += zombieSpeed;
                        ((PictureBox)z).Image = Properties.Resources.zright;
                    }
                    if (((PictureBox)z).Top > picPlayer.Top)
                    {
                        ((PictureBox)z).Top -= zombieSpeed;
                        ((PictureBox)z).Image = Properties.Resources.zup;
                    }
                    if (((PictureBox)z).Top < picPlayer.Top)
                    {
                        ((PictureBox)z).Top += zombieSpeed;
                        ((PictureBox)z).Image = Properties.Resources.zdown;
                    }

                    if (picPlayer.Bounds.IntersectsWith( ((PictureBox)z).Bounds) )
                        playerBlood--;
                }
            }

            if (playerBlood > 1)
            {
                progressBar1.Value = playerBlood;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("GG!");
            }

            if (picPlayer.Bounds.IntersectsWith(picCastle.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("You are safe!");
            }

            foreach (Control i in this.Controls)
                foreach (Control j in this.Controls)
                    if ((i is PictureBox && i.Tag == "bullet") && (j is PictureBox && j.Tag == "zombie") && i.Bounds.IntersectsWith(j.Bounds))
                    {
                        score++;                //宣告一個全域變數score，初值設為0
                        this.Controls.Remove(i);
                        i.Dispose();
                        this.Controls.Remove(j);
                        j.Dispose();
                    }
            lblKill.Text= "Kills: " + score;    //Form1上新增一個label，取名為lblKill

            foreach (Control a in this.Controls)
                if ((a is PictureBox && a.Tag == "ammo") && a.Bounds.IntersectsWith(picPlayer.Bounds))
                {
                    this.Controls.Remove(a);
                    a.Dispose();
                    bulletNum += 10;
                    ammoNum--;  //彈匣數量-1
                }
            lblBulletNum.Text = "剩餘子彈：" + bulletNum;   //此行從Form1_KeyDown按空白發射子彈的條件式裡移過來，才能即時更新子彈數。
        }
    }
}


