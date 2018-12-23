
using System;
using System.Windows.Forms;
using CalculateLib;

namespace calculators
{
    public partial class Form1 : Form
    {
        CalculateMathCore mathCore;
        public Form1()
        {
            InitializeComponent();
            mathCore = new CalculateMathCore();
        }

        enum Operation {ADD, SUBTRACT, MULTIPLY, DIVIDE, POWER}

        private void button_add_Click(object sender, EventArgs e)
        {
            Calculate(Operation.ADD);
        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            Calculate(Operation.SUBTRACT);
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            Calculate(Operation.MULTIPLY);
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            Calculate(Operation.DIVIDE);
        }

        private void button_Power_Click(object sender, EventArgs e)
        {
            Calculate(Operation.POWER);
        }

        private void Calculate(Operation op)
        {
            double input_1 = Double.Parse(textBox_input_1.Text);
            double input_2 = Double.Parse(textBox_input_2.Text);

            double results = 0;
            switch(op)
            {
                case Operation.ADD:
                    results = mathCore.Add(input_1, input_2);
                    break;
                case Operation.SUBTRACT:
                    results = mathCore.Subtract(input_1, input_2);
                    break;
                case Operation.MULTIPLY:
                    results = mathCore.Multiply(input_1, input_2);
                    break;
                case Operation.DIVIDE:
                    results = mathCore.Divide(input_1, input_2);
                    break;
                case Operation.POWER:
                    results = mathCore.Power(input_1, input_2);
                    break;
            }

            textBox_results.Text = results.ToString("G5");
        }
    }
}
