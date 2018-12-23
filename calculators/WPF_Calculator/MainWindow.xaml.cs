using System;
using System.Windows;
using CalculateLib;

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculateMathCore mathCore;
        public MainWindow()
        {
            InitializeComponent();
            mathCore = new CalculateMathCore();
        }

        private void button_Add_Click(object sender, RoutedEventArgs e)
        {
            Calculate("Add");
        }

        private void button_Subtract_Click(object sender, RoutedEventArgs e)
        {
            Calculate("Subtract");
        }

        private void button_Multiply_Click(object sender, RoutedEventArgs e)
        {
            Calculate("Multiply");
        }

        private void button_Divide_Click(object sender, RoutedEventArgs e)
        {
            Calculate("Divide");
        }

        private void button_Power_Click(object sender, RoutedEventArgs e)
        {
            Calculate("Power");
        }

        private void Calculate(string op)
        {
            double input_1 = Double.Parse(textBox_Input.Text);
            double input_2 = Double.Parse(textBox_Input_1.Text);

            double results = 0;
            switch (op)
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
                case "Power":
                    results = mathCore.Power(input_1, input_2);
                    break;
            }

            textBox_results.Text = results.ToString("G5");
        }
    }
}
