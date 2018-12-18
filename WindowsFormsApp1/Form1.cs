using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public double? result = 0;
        public double? operand1 = null, operand2 = null;
        public string output = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            output += "1";
            textBox1.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            output += "2";
            textBox1.Text = output;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            output += "3";
            textBox1.Text = output;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            output += "4";
            textBox1.Text = output;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output += "5";
            textBox1.Text = output;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            output += "6";
            textBox1.Text = output;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            output += "7";
            textBox1.Text = output;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            output += "8";
            textBox1.Text = output;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            output += "9";
            textBox1.Text = output;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            output += "0";
            textBox1.Text = output;
        }

        //addition
        

        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(output);

            output += "+";
            textBox1.Text = output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(output);

            output += "-";
            textBox1.Text = output;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(output);

            output += "X";
            textBox1.Text = output;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(output);

            output += "/";
            textBox1.Text = output;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            output += ".";
            textBox1.Text = output;
        }

        public void EvaluateExpression()
        {
            if (output.Contains('+'))
                result = operand1 + operand2;
            else if (output.Contains('-'))
                result = operand1 - operand2;
            else if (output.Contains('X'))
                result = operand1 * operand2;
            else if (output.Contains('/'))
                result = operand1 / operand2;

            textBox1.Text = result.ToString();
          
        }

        private void button11_Click(object sender, EventArgs e)
        {
            output = String.Empty;
            textBox1.Text = output;
        }

        //need lots of logic for evaluating multiple operands
        //count of operands
        //loop through, splitting strings i times into operand 1/2
        private void button12_Click(object sender, EventArgs e)
        {
            char[] operatorChars = new char[] { '+', '-', 'X', '/' };
            int operatorPos = output.IndexOfAny(operatorChars) + 1;
            operand2 = Double.Parse(output.Substring(operatorPos));

            


            EvaluateExpression();


        }
    }

}