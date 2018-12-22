using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            double input_1 = Double.Parse(textBox_input_1.Text);
            double input_2 = Double.Parse(textBox_input_2.Text);
            double results = input_1 + input_2;
            textBox_results.Text = results.ToString();
        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            double input_1 = Double.Parse(textBox_input_1.Text);
            double input_2 = Double.Parse(textBox_input_2.Text);
            double results = input_1 - input_2;
            textBox_results.Text = results.ToString();
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            double input_1 = Double.Parse(textBox_input_1.Text);
            double input_2 = Double.Parse(textBox_input_2.Text);
            double results = input_1 * input_2;
            textBox_results.Text = results.ToString();
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            double input_1 = Double.Parse(textBox_input_1.Text);
            double input_2 = Double.Parse(textBox_input_2.Text);
            double results = input_1 / input_2;
            textBox_results.Text = results.ToString();
        }
    }
}
