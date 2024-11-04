using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Calculator : Form
    {
        double resultvalue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;

        }

        private void Operator_Click(object sender, EventArgs e)
        {
                Button button = (Button)sender;

                operationPerformed = button.Text;
                resultvalue = double.Parse(textBox1.Text);
                labelCurrentOperation.Text = resultvalue + " " + operationPerformed;
                isOperationPerformed=true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "÷":
                    textBox1.Text = (resultvalue / double.Parse(textBox1.Text)).ToString(); 
                break;

                case "x":
                    textBox1.Text = (resultvalue * double.Parse(textBox1.Text)).ToString(); 
                break;

                case "-":
                    textBox1.Text = (resultvalue - double.Parse(textBox1.Text)).ToString(); 
                break;

                case "+":
                    textBox1.Text= (resultvalue + double.Parse(textBox1.Text)).ToString(); 
                break;

                case "%":
                    textBox1.Text = (resultvalue * double.Parse(textBox1.Text) / 100).ToString();
                break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultvalue = 0;
            operationPerformed = "";
            labelCurrentOperation.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        double memory = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            memory = double.Parse(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            memory += double.Parse(textBox1.Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            textBox1.Text = Math.Sqrt(number).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                textBox1.Text = (value / 100).ToString();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            if (number != 0)
            {
                textBox1.Text = (1 / number).ToString();
            }
            else
            {
                MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
 
                if (double.TryParse(textBox1.Text, out double number))
                {
                    number = -number;
                    textBox1.Text = number.ToString();
                }
        }
    }
}
