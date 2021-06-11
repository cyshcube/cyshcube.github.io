using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = new int[6];
            int[] check = new int[49];  //數值陣列的初值=0
            int t;
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                num[i] = rnd.Next(1, 7); // 隨機產生1~6間的數字
            }

            //產生的數字不重複
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    t = rnd.Next(1, 7); //完成後改為50，按幾次後會錯誤？
                } while (check[t] == 1);
                num[i] = t;
                check[t] = 1;
            }

            //bubble sort
            /*
                        for (int i=0;i<5;i++)
                        {
                            for (int j=0;j<5-i;j++)
                            {
                                if (num[j]>num[j+1])
                                {
                                    t = num[j];
                                    num[j] = num[j+1];
                                    num[j + 1] = t;
                                }
                            }
                        }
            */

            //exchange sort
            //Q：What's wrong? 新增中斷點，逐步執行除錯

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (num[j] < num[i])
                    {
                        t = num[i];
                        num[i] = num[j];
                        num[j] = t;
                    }
                }
            }


            label1.Text = "";
            for (int i = 0; i < 6; i++)
            {
                label1.Text += num[i].ToString() + " ";
            }
        }
    }
}
