using System;
using System.Numerics;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double factorial1 = Factorial1(a);
            double factorial2 = Factorial2(b);

            double result = factorial1 / factorial2;
            Console.WriteLine($"{result:f2}");

        }

        private static double Factorial1(double a)
        {
            double fact =1;

            for (double i = 1; i <= a; i++)
            {
                fact *= i;               
            }
            
            return fact;
        }
        private static double Factorial2(double b)
        {
            double fact = 1;

            for (double i = 1; i <= b; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
