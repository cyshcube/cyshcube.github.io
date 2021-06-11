using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n_puzzle
{
    public partial class Form1 : Form
    {
        Button[,] buttons = new Button[3, 3];       //宣告一個二維陣列儲存3x3按鈕
        int[] num = new int[9] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        int r, c;                                   //空白格的座標，row，col

        public Form1()
        {
            InitializeComponent();
        }

        private int calcRev()
        {
            int sum = 0;

            for (int i = 0; i < 9; i++)
                for (int j = i + 1; j < 9; j++)
                    if (num[j] < num[i])
                        sum++;

            return sum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();                               //產生3x3按鈕置於二維陣列
                    buttons[i, j].Location = new Point(j * 100, i * 100);       //設定按鈕位置
                    buttons[i, j].Size = new Size(100, 100);                    //設定按鈕大小
                    buttons[i, j].Text = num[i * 3 + j].ToString();             //設定按鈕上的編號
                    buttons[i, j].Font = new Font("Serif", 16, FontStyle.Bold); //設定按鈕文字大小
                    buttons[i, j].Click += new EventHandler(Button1_Click);     //設定銨鈕click時處理的事件
                    this.Controls.Add(buttons[i, j]);                           //產生按鈕
                }
            }

            Random rnd = new Random();

            do { 
                for (int i = 0; i < 10; i++)       //將num陣列裏的數字順序打亂。產生10次亂數，亂數位子的數字和第一個交換。
                {
                    int t, r = rnd.Next(0, 9);     //產生一個0~8的亂數。t,r為區塊變數。
                        
                    t = num[0];
                    num[0] = num[r];
                    num[r] = t;
                }
            } while (calcRev() % 2 == 1);

            label1.Text = calcRev().ToString();
            
            for (int i = 0; i < 3; i++)         //將打亂的數字重新放入按鈕
            {
                for (int j = 0; j < 3; j++)
                {
                    if (num[i * 3 + j] != 0)
                        buttons[i, j].Text = num[i * 3 + j].ToString();
                    else
                    {
                        buttons[i, j].Text = "";
                        r = i;                  //記錄空白的坐標
                        c = j;
                    }
                }
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        { 
            if (r > 0 && sender == buttons[r - 1, c])           //按空白上面按鈕。r>0 避免空白在最上面時(r=0)，按自已會使陣列索引值超出範圍。
            {
                buttons[r, c].Text = buttons[r - 1, c].Text;
                buttons[r - 1, c].Text = "";
                r = r - 1;
            }
            else if (r < 2 && sender == buttons[r + 1, c])      //按空白下面按鈕
            {
                buttons[r, c].Text = buttons[r + 1, c].Text;
                buttons[r + 1, c].Text = "";
                r = r + 1;
            }
            else if (c > 0 && sender == buttons[r, c - 1])      //按空白左邊按鈕
            {
                buttons[r, c].Text = buttons[r, c - 1].Text;
                buttons[r, c - 1].Text = "";
                c = c - 1;
            }
            else if (c < 2 && sender == buttons[r, c + 1])      //按空白右邊按鈕
            {
                buttons[r, c].Text = buttons[r, c + 1].Text;
                buttons[r, c + 1].Text = "";
                c = c + 1;
            }
            //Q：一定有解嗎？

        }

    }
}
