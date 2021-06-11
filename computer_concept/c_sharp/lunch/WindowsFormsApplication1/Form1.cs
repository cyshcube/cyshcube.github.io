using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text=="" || textBox1.Text == "")
            {
//                MessageBox.Show("便當種類未選取或數量未輸入！","提醒",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                if (comboBox1.Text== "")
                {
                    MessageBox.Show("便當種類未選取！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("便當數量未輸入！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                listBox1.Items.Add(comboBox1.Text + " " + textBox1.Text + "個");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar < 48 || (int)e.KeyChar > 57)
//          if ( (e.KeyChar<48 || e.KeyChar>57) && e.KeyChar!=8 )
//          if ( e.KeyChar<8 || (e.KeyChar>=9 && e.KeyChar<=47) || e.KeyChar>57 )
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().Substring(0, 3) == comboBox1.Text)
                {
                    listBox1.Items.RemoveAt(i);
                    i = -1;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show(i.ToString());
            }

            DialogResult result = MessageBox.Show("好玩嗎？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("再賞你100個");
                for (int i = 0; i < 100; i++)
                {
                    MessageBox.Show(i.ToString());
                }
            }
            else
            {
                MessageBox.Show("處罰1000個");
                for (int i = 0; i < 1000; i++)
                {
                    MessageBox.Show(i.ToString());
                }
            }       
        }
       
    }
}
