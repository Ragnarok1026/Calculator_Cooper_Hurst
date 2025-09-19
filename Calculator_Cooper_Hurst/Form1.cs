using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Cooper_Hurst
{
    public partial class Form1 : Form
    {
        public string result;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "";
            result = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result += "1";
            textBox1.Text = result;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result += "2";
            textBox1.Text = result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result += "3";
            textBox1.Text = result;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result += "4";
            textBox1.Text = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result += "5";
            textBox1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result += "6";
            textBox1.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result += "7";
            textBox1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result += "8";
            textBox1.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result += "9";
            textBox1.Text = result;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result += "0";
            textBox1.Text = result;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
            object resultvalue = new DataTable().Compute(result, null);
            double finalresult = Convert.ToDouble(resultvalue);
            result = finalresult.ToString();
            textBox1.Text = result;
            }
            catch
            {
                textBox1.Text = "[[Hyperlink Blocked]]";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result += ".";
            textBox1.Text = result;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result += "+";
            textBox1.Text = result;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result += "-";
            textBox1.Text = result;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result += "*";
            textBox1.Text = result;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result += "/";
            textBox1.Text = result;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result = "";
            textBox1.Text = result;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
