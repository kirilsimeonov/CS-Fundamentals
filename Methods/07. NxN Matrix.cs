using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Print(n);
        }

        private static void Print(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int d = 1; d <= n; d++)
                {
                    Console.Write(n+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
