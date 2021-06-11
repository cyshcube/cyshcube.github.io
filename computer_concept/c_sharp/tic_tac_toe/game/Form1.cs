using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        int c = 0;                          //全域變數，記錄目前第幾步

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //此行不可以自己輸入
        {
            int r; 
            c = c + 1;                      //每按一下，c就加1
            r = c % 2;                      //求c除2的餘數(r為0或1)，0顯示"X"，1顯示"O" 

            label1.Text = r.ToString();     //先在Form1上放一個label，輸入提示沒有看到label1，表示沒有這個元件 

            Button b = (Button)sender;

            if (r == 1)
            {
                b.Text = "O";
            }
            else
            {
                b.Text = "X";
            }

            b.Enabled = false;              //按過不能再按
            checkWinner();                  //呼叫判斷輸贏的函式
        }

        private void checkWinner()
        {
            /*
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O Win!");
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O Win!");
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O Win!");
            }
            */

            if ( (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                 (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                 (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                 (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                 (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                 (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
                 (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                 (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") )
            {
                MessageBox.Show("O Win!");
            }
            else if ( (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                 (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                 (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                 (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                 (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                 (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
                 (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
                 (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") )
            {
                MessageBox.Show("X Win!");
            }
            else if (c == 9)
            {
                MessageBox.Show("平手！");
            }
        }

        private void button10_Click(object sender, EventArgs e) //此行不可以自己輸入
        {
            c = 0;
            /*
                        button1.Text = "";
                        button2.Text = "";
                        button3.Text = "";
                        button4.Text = "";
                        button5.Text = "";
                        button6.Text = "";
                        button7.Text = "";
                        button8.Text = "";
                        button9.Text = "";

                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                        button6.Enabled = true;
                        button7.Enabled = true;
                        button8.Enabled = true;
                        button9.Enabled = true;
            */
            for (int i = 1; i <= 9; i++)
            {
                this.Controls["button" + i].Text = "";
                this.Controls["button" + i].Enabled = true;
            }

        }
    }
}


