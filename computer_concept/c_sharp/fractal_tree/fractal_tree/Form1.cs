using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fractal_tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = panel2.CreateGraphics();
            Pen pen = new Pen(Color.Green);

            int depth = Convert.ToInt32(nudDepth.Value);
            float len= Convert.ToSingle(nudLen.Value);
            float scale = Convert.ToSingle(txtScale.Text);
            float angle = -90;
            float x0 = panel2.Width / 2;
            float y0 = panel2.Height;


            drawBranch(gr, pen, depth, len, scale, angle, x0, y0);
        }

        private void drawBranch(Graphics gr, Pen pen, int depth, float len, float scale, float angle, float x0, float y0)
        {
            // 計算此分枝結束點的座標
            float x1 = (float)(x0 + len * Math.Cos(angle * 3.14 / 180));
            float y1 = (float)(y0 + len * Math.Sin(angle * 3.14 / 180));

            gr.DrawLine(pen, x0, y0, x1, y1);

            // 如果深度 > 1, 遞迴畫出其它分枝
            if (depth > 1)
            {
                drawBranch(gr, pen, depth - 1, len * scale, scale, angle + Convert.ToSingle(nudAngle.Value), x1, y1);
                drawBranch(gr, pen, depth - 1, len * scale, scale, angle - Convert.ToSingle(nudAngle.Value), x1, y1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Refresh();
        }
    }
}
