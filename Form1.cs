using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Self
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // private void button3_Click(object sender, EventArgs e)
        //{

        //}
        int result;
        int num1, num2;
        String option;

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "9";
        }

       

        private void btn0_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "0";
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(DisplayBox.Text);
            DisplayBox.Clear();
        }

        private void mulbtn_Click(object sender, EventArgs e)
        {
            option = "X";
            num1 = int.Parse(DisplayBox.Text);
            DisplayBox.Clear();
        }

        private void divbtn_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(DisplayBox.Text);
            DisplayBox.Clear();
        }

        

        private void sumbtn_Click(object sender, EventArgs e)
        {
            option = "+";
            num1=int.Parse(DisplayBox.Text);
            DisplayBox.Clear();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            DisplayBox.Clear();
        }

        private void eqalbtn_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(DisplayBox.Text);
            if (option.Equals("+"))
            {
                result = num1 + num2;
            }
            if(option.Equals("-"))
            {
                result = num1 - num2;
            }
            if(option.Equals("X"))
            {
                result = num1 * num2;
            }
            if(option.Equals("/"))
                {
                result = num1 / num2;
            }
            DisplayBox.Text=result.ToString()+" ";
        }

    }
}
