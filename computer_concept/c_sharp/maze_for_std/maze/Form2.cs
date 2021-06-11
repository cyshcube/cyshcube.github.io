using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; //新增 openFileDialog 和 saveFileDialog 至 Form2

namespace maze
{
    public partial class Form2 : Form
    {
        int Num = 20;
        PictureBox[,] pbx;
        char[,] map;
        string currentFile = "";  //打開的地圖檔

        public Form2()
        {
            InitializeComponent();

            this.Size = new Size(600, 500);
            Button btnLoadMap = new Button();
            btnLoadMap.Text = "載入要編輯的迷宮";
            btnLoadMap.Size = new Size(120, 60);
            btnLoadMap.Location = new Point(440, 20);
            btnLoadMap.Click += new EventHandler(btnLoadMap_Click);
            this.Controls.Add(btnLoadMap);

            Button btnSaveMap = new Button();
            btnSaveMap.Text = "儲存編輯完的迷宮";
            btnSaveMap.Size = new Size(120, 60);
            btnSaveMap.Location = new Point(440, 100);
            btnSaveMap.Click += new EventHandler(btnSaveMap_Click);
            this.Controls.Add(btnSaveMap);

            pbx = new PictureBox[Num, Num];
            map = new char[Num, Num];

            for (int i = 0; i < Num; i++)
            {
                for (int j = 0; j < Num; j++)
                {
                    pbx[i, j] = new System.Windows.Forms.PictureBox();
                    pbx[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    pbx[i, j].Location = new Point(j * 20, i * 20);  //左上角座標
                    pbx[i, j].Size = new System.Drawing.Size(20, 20);
                    pbx[i, j].Click += new EventHandler(pictureBox_Click);

                    if (i == 0 || i == Num - 1 || j == 0 || j == Num - 1)
                    {
                        pbx[i, j].Image = Properties.Resources.wall;
                        map[i, j] = '1';
                    }
                    else if (i == 1 && j == 1)
                    {
                        pbx[i, j].Image = Properties.Resources.start;
                        map[i, j] = 'S';
                    }
                    else if (i == Num - 2 && j == Num - 2)
                    {
                        pbx[i, j].Image = Properties.Resources.goal;
                        map[i, j] = 'G';
                    }
                    else
                    {
                        pbx[i, j].Image = Properties.Resources.black;
                        map[i, j] = '0';
                    }

                    this.Controls.Add(pbx[i, j]);                    //把pictureBox加到當前視窗
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pbxClicked = (PictureBox)sender;
            int x = pbxClicked.Location.X / 20;
            int y = pbxClicked.Location.Y / 20;

            //判断是不是在编辑范围内
            if (y == 0 || y == Num - 1 || x == 0 || x == Num - 1) return;
            if (x == 1 && y == 1) return;
            if (x == Num - 2 && y == Num - 2) return;

            if (map[y, x] == '0')
            {
                pbx[y, x].Image = Properties.Resources.wall;
                map[y, x] = '1';

            }
            else // map[y, x] == '1'
            {
                pbx[y, x].Image = Properties.Resources.black;
                map[y, x] = '0';
            }

        }

        private void btnLoadMap_Click(object sender, EventArgs e)   //載入地圖
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)  //openFileDialog 需加入 using System.IO;
            {
                currentFile = openFileDialog1.FileName;
                byte[] line = new byte[Num + 2];                //因為每一行結束有Enter，多加2個空間
                FileStream File = new FileStream(currentFile, FileMode.Open);//打開地圖檔案
                File.Seek(0, SeekOrigin.Begin);                 //定位到文件起點

                for (int i = 0; i < Num; i++)
                {
                    File.Read(line, 0, Num + 2);  //讀1行

                    for (int j = 0; j < Num; j++)
                    {
                        if (line[j] == '0') //路
                        {
                            pbx[i, j].Image = Properties.Resources.black; //先雙擊WindowsFormsApp1/Properties/Resources.resx/加入資源/加入現有檔案
                            map[i, j] = '0';
                        }
                        if (line[j] == '1') //牆
                        {
                            pbx[i, j].Image = Properties.Resources.wall;
                            map[i, j] = '1';
                        }
                        if (line[j] == 'S') //起點
                        {
                            pbx[i, j].Image = Properties.Resources.start;
                            map[i, j] = 'S';
                        }
                        if (line[j] == 'G') //終點
                        {
                            pbx[i, j].Image = Properties.Resources.goal;
                            map[i, j] = 'G';
                        }

                        this.Controls.Add(pbx[i, j]);//把pictureBox加到當前視窗
                    }
                }

                File.Close();//關閉地圖檔案
            }
        }

        private void btnSaveMap_Click(object sender, EventArgs e)   //地圖存檔
        {
            if (currentFile != "")  //有開啟地圖編輯，直接存到currentFile
            {
                FileStream File = new FileStream(currentFile, FileMode.Create);
                File.Seek(0, SeekOrigin.Begin);
                byte[] line = new byte[Num + 2];

                for (int i = 0; i < Num; i++)
                {
                    for (int j = 0; j < Num; j++)
                    {
                        line[j] = (byte)map[i, j];
                    }
                    line[Num] = (byte)'\r';     //加入換行字元
                    line[Num + 1] = (byte)'\n';
                    File.Write(line, 0, Num + 2);
                }
                File.Close();
                MessageBox.Show("迷宮地圖存檔成功");
            }
            else //沒開啟地圖編輯
            {
                saveFileDialog1.Filter = "地圖文件（*.txt）|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentFile = saveFileDialog1.FileName.ToString();
                    FileStream File = new FileStream(currentFile, FileMode.Create);
                    File.Seek(0, SeekOrigin.Begin);
                    byte[] line = new byte[Num + 2];

                    for (int i = 0; i < Num; i++)
                    {
                        for (int j = 0; j < Num; j++)
                        {
                            line[j] = (byte)map[i, j];

                        }
                        line[Num] = (byte)'\r';
                        line[Num + 1] = (byte)'\n';
                        File.Write(line, 0, Num + 2);
                    }
                    File.Close();
                    MessageBox.Show("迷宮地圖存檔成功");

                }
            }
        }
    }
}
