using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        double value = 0;       //浮點數，value為四則運算的第一個數字
        string operation = "";  //字串，operaton為"+ - * /"
        bool operation_pressed = false; //布林，按"+ - * /"後設為true，用於清除第一個數字

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text=="0")||operation_pressed)    //當 文字方塊上有0 或"+-*/"被按下去
                textBox1.Clear();                           //清除文字方塊
            
            operation_pressed = false;                      //清除後設定為沒有按"+-*/"，以免無法打2位數以上
            Button b = (Button)sender;                      //將被按的數字按鈕傳回當成一個物件
            textBox1.Text = textBox1.Text+b.Text;           //將文字方塊加上數字按鈕的Text屬性
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;                             //將operation設為"+-*/"之一
            value = Double.Parse(textBox1.Text);            //將目前文字方塊上的數字，轉成數值後記錄在value
            operation_pressed = true;                       //標記"+-*/"被按下
            label1.Text = value+" "+operation;              //label1上顯示第一個數字和運算子
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
            value = 0;
            label1.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (operation == "+")
                textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();   //將第一個數字加上目前文字方塊的數字(第二個數字)，將結果轉成字串後設定到文字方塊
            else if(operation == "-")
                textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
            else if (operation == "*")
                textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
            else if (operation == "/")
                textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();

            operation_pressed = true;
        }

   
    }
}
