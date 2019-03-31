using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = Sum(a, b);
            int Subst = Substract(sum, c);
           
            Console.WriteLine(Subst);
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }
        private static int Substract(int sum, int c)
        {
            return sum - c;
        }
    }
}
