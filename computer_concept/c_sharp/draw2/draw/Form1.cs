using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace draw
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Pen bPen = new Pen(Color.Black);
            Point[] p = new Point[2];
            int num = Int32.Parse(txtNum.Text);
            int angle = 0;
            int len = Int32.Parse(txtLen.Text);

            for (int i = 0; i < num; i++)
            {
                p[0].X = panel2.Width / 2;
                p[0].Y = panel2.Height / 2;

                for (int j = 0; j < 4; j++)
                {
                    p[1].X = p[0].X + (int)(len * Math.Cos(angle * 3.14159 / 180));
                    p[1].Y = p[0].Y + (int)(len * Math.Sin(angle * 3.14159 / 180));

                    g.DrawLines(bPen, p);

                    angle -= 90;
                    p[0].X = p[1].X;
                    p[0].Y = p[1].Y;
                }

                angle -= Int32.Parse(txtAngle.Text);
                len += Int32.Parse(txtInc.Text);
            }
        }
    

    private void btnGo_Click(object sender, EventArgs e)
    {
        panel2.Refresh();
    }
    }


}