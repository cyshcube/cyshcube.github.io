using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace zombieShooter
{
    class ClassBullet
    {
        public string direction;
        public int x, y, bulletMoveSpan = 20;

        PictureBox picBullet = new PictureBox();
        Timer tmrBullet = new Timer();

        public void makeBullet(Form frm)
        {
            picBullet.BackColor = System.Drawing.Color.Blue;
            picBullet.Size = new Size(5, 5);
            picBullet.Tag = "bullet";
            picBullet.Location = new Point(x, y);
            picBullet.BringToFront();
            frm.Controls.Add(picBullet);

            tmrBullet.Interval = 20;
            tmrBullet.Tick += new EventHandler(tmrBullet_Tick);
            tmrBullet.Start();
        }

        public void tmrBullet_Tick(object sender, EventArgs e)
        {
            if (direction == "left")
                picBullet.Left -= bulletMoveSpan;
            else if (direction == "right")
                picBullet.Left += bulletMoveSpan;
            else if (direction == "up")
                picBullet.Top -= bulletMoveSpan;
            else if (direction == "down")
                picBullet.Top += bulletMoveSpan;

            if (picBullet.Left < 0 || picBullet.Left > 900 || picBullet.Top < 0 || picBullet.Top > 700)
            {
                tmrBullet.Stop();
                tmrBullet.Dispose();
                tmrBullet = null;
                picBullet.Dispose();
                picBullet = null;
            }
        }
    }
}
