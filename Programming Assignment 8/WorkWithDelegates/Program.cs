using System.Security.Cryptography.X509Certificates;

namespace Assignment8ex2
{
    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        public delegate double myDelegate(double a, double b);
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}");
            Console.WriteLine($" {num1} + {num2} = {answer.GetProduct(num1, num2)}");
            answer.GetSmaller(num1, num2);

            Action<double, double> calculate = answer.GetSmaller;
            calculate(num1, num2);

            Func<double, double, double> funcCalc = answer.GetSum;
            funcCalc(num1, num2);

            myDelegate myD = new myDelegate(answer.GetProduct);
        }
    }
}