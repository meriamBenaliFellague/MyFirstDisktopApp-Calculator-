using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        private object txtstore;

        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            Text1.Text = Text1.Text + "4";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            Text1.Text = Text1.Text + ".";
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            Text1.Text = Text1.Text + "0";
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            Text1.Text = Text1.Text + "1";
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            Text1.Text = Text1.Text + "2";
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            Text1.Text = Text1.Text + "3";
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            Text1.Text = Text1.Text + "5";
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            Text1.Text = Text1.Text + "6";
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Text1.Text = Text1.Text + "7";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Text1.Text = Text1.Text + "8";
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Text1.Text = Text1.Text + "9";
        }

        

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Text1.Clear();
            Text2.Clear();
        }
        float number;
        int count;
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (Text1.Text != "" )
            {
                number = float.Parse(Text1.Text);
                Text2.Text = Text1.Text + "-";
                Text1.Clear();
                count = 1;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (Text1.Text != "")
            {
                number = float.Parse(Text1.Text);
                Text2.Text = Text1.Text + "+";
                Text1.Clear();
                count = 2;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (Text1.Text != "")
            {
                number = float.Parse(Text1.Text);
                Text2.Text = Text1.Text + "*";
                Text1.Clear();
                count = 3;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Text1.Text != "")
            {
                number = float.Parse(Text1.Text);
                Text2.Text = Text1.Text + "/";
                Text1.Clear();
                count = 4;
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
           
            if (Text1.Text != "")
            {
                number = float.Parse(Text1.Text);
                Text2.Text = Text1.Text + "%";
                Text1.Clear();
                count = 5;
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            float ans;
            switch(count)
            {
                case 1:
                    ans = number-float.Parse(Text1.Text);
                    Text2.Text = Text2.Text + Text1.Text + "=" + ans;
                    Text1.Text = ans.ToString();
                    
                    break;
                case 2:
                    ans = number + float.Parse(Text1.Text);
                    Text2.Text = Text2.Text + Text1.Text + "=" + ans;
                    Text1.Text = ans.ToString();
                    break;
                case 3:
                    ans = number * float.Parse(Text1.Text);
                    Text2.Text = Text2.Text + Text1.Text + "=" + ans;
                    Text1.Text = ans.ToString();
                    break;
                case 4:
                    ans = number / float.Parse(Text1.Text);
                    Text2.Text = Text2.Text + Text1.Text + "=" + ans;
                    Text1.Text = ans.ToString();
                    break;
                case 5:
                    ans = number / 100;
                    Text2.Text = Text2.Text + Text1.Text + "=" + ans;
                    Text1.Text = ans.ToString();
                    break;
            }
        }
    }
}
