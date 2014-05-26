using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string first;
        int temp = -1;

        private void button1Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                label1.Text = button1.Text;
                temp = -1;
            }
            else
            label1.Text += button1.Text;
        }

        private void button2Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                label1.Text = button2.Text;
                temp = -1;
            }
            else
            label1.Text += button2.Text;
        }

        private void button3Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                label1.Text = button3.Text;
                temp = -1;
            }
            else
            label1.Text += button3.Text;
        }

        private void button4Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                label1.Text = button4.Text;
                temp = -1;
            }
            else
            label1.Text += button4.Text;
        }

        private void button5Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                label1.Text = button5.Text;
                temp = -1;
            }
            else
            label1.Text += button5.Text;
        }

        private void button6Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                label1.Text = button6.Text;
                temp = -1;
            }
            else
            label1.Text += button6.Text;
        }

        private void button7Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                label1.Text = button7.Text;
                temp = -1;
            }
            else
            label1.Text += button7.Text;
        }

        private void button8Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                label1.Text = button8.Text;
                temp = -1;
            }
            else
            label1.Text += button8.Text;
        }

        private void button9Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                label1.Text = button9.Text;
                temp = -1;
            }
            else
            label1.Text += button9.Text;
        }

        private void button10Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                label1.Text = button10.Text;
                temp = -1;
            }
            else
            label1.Text += button10.Text;
        }

        private void button11Click(object sender, EventArgs e)
        {
            first = label1.Text;
            label1.Text = "";
            temp = 1;
        }

        private void button15Click(object sender, EventArgs e)
        {
            var second = label1.Text;
            if (temp == 1)
            {
                first = (int.Parse(first) + int.Parse(second)).ToString(); 
            }
            if (temp == 2)
            {
                first = (int.Parse(first) - int.Parse(second)).ToString();
            }
            if (temp == 3)
            {
                if (second == "0")
                {
                    MessageBox.Show("Деление на 0");
                }
                else
                first = (int.Parse(first) / int.Parse(second)).ToString();
            }
            if (temp == 4)
            {
                first = (int.Parse(first) * int.Parse(second)).ToString();
            }
            label1.Text = first;
            temp = 0;
        }

        private void button12Click(object sender, EventArgs e)
        {
            first = label1.Text;
            label1.Text = "";
            temp = 2;
        }

        private void button13Click(object sender, EventArgs e)
        {
            first = label1.Text;
            label1.Text = "";
            temp = 3;
        }

        private void button14Click(object sender, EventArgs e)
        {
            first = label1.Text;
            label1.Text = "";
            temp = 4;
        }
    }
}
