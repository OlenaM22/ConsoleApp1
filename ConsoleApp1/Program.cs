using System;






namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5.0;
            double result = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
            Console.WriteLine("Result of -6*x^3+5*x^2-10*x+15 for x=5.0: " + result);
        }
    }
}
