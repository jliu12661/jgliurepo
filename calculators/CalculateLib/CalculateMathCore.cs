namespace CalculateLib
{
    public class CalculateMathCore
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Power(double a, double b)
        {
            return System.Math.Pow(a, b);
        }

        public double Modulus(double a, double b)
        {
            return a % b;
        }
    }
}
