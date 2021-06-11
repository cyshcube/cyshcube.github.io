using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();               //宣告random為Random物件
        List<string> icons = new List<string>()     //宣告icons為List物件，並設初值。List可以放不同形態的元素。
        {
                "!" , "!" , "N" , "N" , "," , "," , "k" , "k" ,
                "b" , "b" , "v" , "v" , "w" , "w" , "z" , "z"
        };

        Label firstclicked = null;                  //第一個被按的Label
        Label secondclicked = null;                 //第二個被按的Label

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();                 //呼叫函式放入圖案
        }

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls) //宣告control變數，儲存控制項
            {
                Label iconlabel = control as Label;                 //將control變數轉換成Label物件，取名為iconlabel
                if (iconlabel != null)                              //如果上一行轉換成功
                {
                    int randomNumber = random.Next(icons.Count);    //宣告一個亂數randomNumber，此亂數由random物件的Next方法產生。用icons.Count屬性決定亂數的範圍。
                    iconlabel.Text = icons[randomNumber];           //iconlabel的Text屬性設為icons內的字元
                    iconlabel.ForeColor = iconlabel.BackColor;      //iconlabel的文字顏色設為背景顏色，所以看不到圖
                    icons.RemoveAt(randomNumber);                   //將已加入的字元，從icons刪除
                }
            }
        }

        private void label_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
                return;
            
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                
                if (firstclicked == null)
                {
                    firstclicked = clickedLabel;
                    clickedLabel.ForeColor = Color.Black;
                    return;
                }
                secondclicked = clickedLabel;
                secondclicked.ForeColor = Color.Black;

                winner();                                           //檢查是否全翻完

                if (firstclicked.Text == secondclicked.Text)        //如果成對
                {
                    firstclicked = null;
                    secondclicked = null;
                    return;
                }

                timer1.Start();
            }

/*          if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                clickedLabel.ForeColor = Color.Black;
            }
*/
/*          if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                if (firstclicked == null)
                {
                    firstclicked = clickedLabel;
                    clickedLabel.ForeColor = Color.Black;
                    return;
                }
            }
*/        
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstclicked.ForeColor = firstclicked.BackColor;
            secondclicked.ForeColor = secondclicked.BackColor;
            firstclicked = null;
            secondclicked = null;
        }

        private void winner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconlabel = control as Label;
                if (iconlabel != null)
                {
                    if (iconlabel.ForeColor == iconlabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("You Won,Congratulations");
            Close();
        }

    }
}
