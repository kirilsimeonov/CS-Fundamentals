using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int newNum = num;
            int factorial = 1;
            int sum = 0;

            while (newNum > 0)
            {
                for (int i = 1; i <= newNum % 10; i++)
                {
                    factorial *= i;
                  
                }
                sum += factorial;
                factorial = 1;
            newNum /= 10;
            
            }
            if (sum == num)
            {
                Console.WriteLine("yes");
                
            }
            else
            {
                Console.WriteLine("no");
            }

            
        }
    }
}
