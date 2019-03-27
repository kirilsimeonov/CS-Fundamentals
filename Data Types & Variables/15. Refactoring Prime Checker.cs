using System;

namespace More_Ex_4_Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i =2; i <= num; i++)
            {
                bool isPrime = true;

                for (int d = 2; d < i; d++)
                {
                    if (i%d ==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{i} -> {"true"}");
                }
                else
                {
                    Console.WriteLine($"{i} -> {"false"}");
                }
               
            }
        }
    }
}
