using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Collections;

namespace maze
{
    public partial class Form1 : Form
    {

        struct Node             //每一個節點
        {
            public char flag;   //記錄為牆(1)、通道(0)
            public int r;       //列
            public int c;       //行
            public int prev_r;  //前一個節點的列
            public int prev_c;  //前一個節點的行
        }

        int Num = 20;           //方形迷宫的階數
        Node[,] map;            //二維地圖
        PictureBox[,] pbx;      //二維PictureBox
        Node mazeStart;         //記錄起點座標

        bool loadMap = false;   //是否載入迷宮地圖
        int step;                //走了幾步


        public Form1()
        {
            InitializeComponent();

            map = new Node[Num, Num];                 //建立二維地圖
            pbx = new PictureBox[Num, Num];           //建立二維PictureBox
            Node mazeStart = new Node();              //記錄起點座標建立

            for (int i = 0; i < Num; i++)             //指定每個pictureBox的座標、大小、圖片
            {
                for (int j = 0; j < Num; j++)
                {
                    pbx[i, j] = new System.Windows.Forms.PictureBox();
                    pbx[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    pbx[i, j].Location = new Point(j * 20, i * 20);  //左上角座標
                    pbx[i, j].Size = new System.Drawing.Size(20, 20);
                    pbx[i, j].Image = Properties.Resources.black;    //先雙擊WindowsFormsApp1/Properties/Resources.resx/加入資源/加入現有檔案
                    this.Controls.Add(pbx[i, j]);                    //把pictureBox加到當前視窗
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  //openFileDialog 需加入 using System.IO;
            {
                loadMap = true;
                step = 1;

                byte[] line = new byte[Num + 2];                //因為每一行結束有Enter，多加2個空間
                FileStream File = new FileStream(openFileDialog1.FileName, FileMode.Open);//打開地圖檔案
                File.Seek(0, SeekOrigin.Begin);                 //定位到文件起點

                for (int i = 0; i < Num; i++)
                {
                    File.Read(line, 0, Num + 2);  //讀1行

                    for (int j = 0; j < Num; j++)
                    {
                        map[i, j] = new Node();
                        map[i, j].r = i;
                        map[i, j].c = j;

                        if (line[j] == '0') //路
                        {
                            pbx[i, j].Image = Properties.Resources.black; //先雙擊WindowsFormsApp1/Properties/Resources.resx/加入資源/加入現有檔案
                            map[i, j].flag = '0';
                        }
                        if (line[j] == '1') //牆
                        {
                            pbx[i, j].Image = Properties.Resources.wall;
                            map[i, j].flag = '1';
                        }
                        if (line[j] == 'S') //起點
                        {
                            pbx[i, j].Image = Properties.Resources.start;
                            map[i, j].flag = 'S';
                            mazeStart.r = i;
                            mazeStart.c = j;
                        }
                        if (line[j] == 'G') //終點
                        {
                            pbx[i, j].Image = Properties.Resources.goal;
                            map[i, j].flag = 'G';
                        }

                        this.Controls.Add(pbx[i, j]);//把pictureBox加到當前視窗
                    }
                }
                File.Close();//關閉地圖檔案
            }
        }

        private void showPath(int r,int c)
        {
            //Q4
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (loadMap == false)
            {
                MessageBox.Show("請先載入迷宮地圖");
                return;
            }

            //使用系統stack，需加入using System.Collections;

            //將迷宮起點放入stack

            //目前正在處理的點


            while (true)
            {
                //Q3 無解

                //取stack最上面那個結點
                
                if (now.flag == 'G')
                {
                    MessageBox.Show("成功! 走了 " + step.ToString() + " 步");
                    //Q4 showPath(now.prev_r, now.prev_c);  
                    break;
                }
                else
                {
                    if (now.flag != 'S')
                    {
                        //走過就設為牆

                        //改為藍色

                        step++;

                        int t = Environment.TickCount;  //延時
                        while (Environment.TickCount - t < 100) Application.DoEvents();
                    }

                    //如果上方可走，放入stack
                    if (map[now.r - 1, now.c].flag == '0' || map[now.r - 1, now.c].flag == 'G')  
                    {
                        map[now.r - 1, now.c].prev_r = now.r;   //設定上方點的來源為現在
                        map[now.r - 1, now.c].prev_c = now.c;
                        stk.Push(map[now.r - 1, now.c]);
                    }

                    //如果右方可走，放入stack
                    if (map[now.r, now.c + 1].flag == '0' || map[now.r, now.c + 1].flag == 'G')  
                    {
                        
                    }
                    
                    //如果下方可走，放入stack
                    
                    //如果左方可走，放入stack

                }
            }

            //Q1：設計一個地圖，讓老師的程式要走最多的步驟。
            //提示：讓程式多走回頭路。

            //Q2：有些地圖(如map4、map5)此演算法很笨，請改進演算法，讓map1~map10的步數加總(X)最小，1151-X為小組分數。
            //提示：最簡單的方法可以改變上、右、下、左 這個進stack的順序。
            //進階：使用A*... 參考  https://www.slideshare.net/frankchang0125/a-algorithm 或 http://swf.com.tw/?p=67

            //Q3：改正無解時會出錯(除錯教學)，如果無解以MessageBox顯示無解。
            //提示：在while迴圈一開始加入if，如果 stack內沒有東西(stk.count可取得 stack中所包含的項目數)，就用 return結束此函式。
            //      stack用法說明可參考 https://msdn.microsoft.com/zh-tw/library/3278tedw(v=vs.110).aspx

            //Q4：完成showPath函式，將起點至終點的路徑解，以車的圖形表示出。
            //提示：以while迴圈，將路徑由終點往起點顯示出。

        }

        private void btnEditMap_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // 先增加Form2.cs->WindowsFormsApp1/右鍵/加入/Windows Form
            f2.Show();
        }
    }
}
