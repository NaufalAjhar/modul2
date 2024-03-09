using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302223040
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public int angka1 = 0;
        public int angka2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text = "1";
            if (angka1 == 0) {
                angka1 = 1;
            } else
            {
                angka2 = 1;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            output.Text = "2";
            if (angka1 == 0)
            {
                angka1 = 2;
            }
            else
            {
                angka2 = 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output.Text = "3";
            if (angka1 == 0)
            {
                angka1 = 3;
            }
            else
            {
                angka2 = 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            output.Text = "4";
            if (angka1 == 0)
            {
                angka1 = 4;
            }
            else
            {
                angka2 = 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output.Text = "5";
            if (angka1 == 0)
            {
                angka1 = 5;
            }
            else
            {
                angka2 = 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            output.Text = "6";
            if (angka1 == 0)
            {
                angka1 = 6;
            }
            else
            {
                angka2 = 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            output.Text = "7";
            if (angka1 == 0)
            {
                angka1 = 7;
            }
            else
            {
                angka2 = 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            output.Text = "8";
            if (angka1 == 0)
            {
                angka1 = 8;
            }
            else
            {
                angka2 = 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            output.Text = "9";
            if (angka1 == 0)
            {
                angka1 = 9;
            }
            else
            {
                angka2 = 9;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            output.Text = "0";
            if (angka1 == 0)
            {
                angka1 = 0;
            }
            else
            {
                angka2 = 0;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            output.Text = "+";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            int angka = angka1 + angka2;
            angka1 = angka;
            output.Text = angka +"";
        }
    }
}
