
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

        private void button_add_Click(object sender, EventArgs e)
        {
            Calculate("Add");
        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            Calculate("Subtract");
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            Calculate("Multiply");
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            Calculate("Divide");
        }

        private void Calculate(string op)
        {
            double input_1 = Double.Parse(textBox_input_1.Text);
            double input_2 = Double.Parse(textBox_input_2.Text);

            double results = 0;
            switch(op)
            {
                case "Add":
                    results = mathCore.Add(input_1, input_2);
                    break;
                case "Subtract":
                    results = mathCore.Subtract(input_1, input_2);
                    break;
                case "Multiply":
                    results = mathCore.Multiply(input_1, input_2);
                    break;
                case "Divide":
                    results = mathCore.Divide(input_1, input_2);
                    break;
            }

            textBox_results.Text = results.ToString("G5");
        }

    }
}
