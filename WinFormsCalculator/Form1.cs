using System;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double fNum = 0;
        double sNum = 0;
        string operation;
        double result;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void but0_Click(object sender, EventArgs e)
        {
            textBox.Text += 0;
        }

        private void but1_Click(object sender, EventArgs e)
        {
            textBox.Text += 1;
        }

        private void but2_Click(object sender, EventArgs e)
        {
            textBox.Text += 2;
        }

        private void but3_Click(object sender, EventArgs e)
        {
            textBox.Text += 3;
        }

        private void but4_Click(object sender, EventArgs e)
        {
            textBox.Text += 4;
        }

        private void but5_Click(object sender, EventArgs e)
        {
            textBox.Text += 5;
        }

        private void but6_Click(object sender, EventArgs e)
        {
            textBox.Text += 6;
        }

        private void but7_Click(object sender, EventArgs e)
        {
            textBox.Text += 7;
        }

        private void but8_Click(object sender, EventArgs e)
        {
            textBox.Text += 8;
        }

        private void but9_Click(object sender, EventArgs e)
        {
            textBox.Text += 9;
        }

        private void butPoint_Click(object sender, EventArgs e)
        {
            textBox.Text += '.';
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            fNum = Convert.ToDouble(textBox.Text);
            textBox.Clear();
        }

        private void butMin_Click(object sender, EventArgs e)
        {
            operation = "-";
            fNum = Convert.ToDouble(textBox.Text);
            textBox.Clear();
        }

        private void butDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            fNum = Convert.ToDouble(textBox.Text);
            textBox.Clear();
        }

        private void butMulti_Click(object sender, EventArgs e)
        {
            operation = "*";
            fNum = Convert.ToDouble(textBox.Text);
            textBox.Clear();
        }

        private void butEql_Click(object sender, EventArgs e)
        {
            sNum = Convert.ToDouble(textBox.Text);
            switch (operation)
            {
                case "+":
                    result = fNum + sNum;
                    break;
                case "-":
                    result = fNum - sNum;
                    break;
                case "*":
                    result = fNum * sNum;
                    break;
                case "/":
                    result = fNum / sNum;
                    break;

            }
            textBox.Clear();
            textBox.Text += result;
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            result = 0;
            fNum = 0;
            sNum = 0;
        }
    }
}
