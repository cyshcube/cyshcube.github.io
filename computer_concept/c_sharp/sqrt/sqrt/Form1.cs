using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqrt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
                        long n = Convert.ToInt64(txtNum.Text);
                        bool ans=false;

                        for (long i=1;i<n/2;i++)
                        {
                            if (i*i==n)
                            {
                                label1.Text = Convert.ToString(i);
                                ans = true;
                                break;
                            }
                        }

                        if (!ans)
                            label1.Text = "只能求平方數的平方根！";

            */
            //二分搜尋法
            /*
                double n = Convert.ToDouble(txtNum.Text);
                double low = 1, high = n - 1, mid = n;

                while (high - low > 1e-15)      // 不斷逼近，直到誤差<1e-15。
                {
                    mid = (low + high) / 2;

                    if (mid * mid > n)          // 平方根小於 mid , 將上限調為 mid
                        high = mid;
                    else if (mid * mid < n)
                        low = mid;              // 平方根大於 mid , 將下限調為 mid
                    else
                        break;
                }
                label1.Text = Convert.ToString(mid);
            */
            //Bonus:牛頓法
            //http://mathcenter.ck.tp.edu.tw/Resources/Ctrl/ePaper/ePaperOpenFileX.ashx?autoKey=55


            double n = Convert.ToDouble(txtNum.Text);
            double ans = n;

            while (ans * ans - n > 1e-15)
            {
                ans = (ans * ans + n) / (2 * ans);
            }
            label1.Text = Convert.ToString(ans);

        }

        private void txtNum_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            label1.Text = "";
        }
    }
}

