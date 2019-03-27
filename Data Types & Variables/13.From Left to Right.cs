using System;
using System.Linq;
using System.Numerics;

namespace More_Ex_2_From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {

            long n = long.Parse(Console.ReadLine());

            string input = string.Empty;
            string first = string.Empty;
            string second = string.Empty;
            int counterSecond = 0;

            for (int z = 0; z < n; z++)
            {
                input = Console.ReadLine();

                for (int d = 0; d < input.Length; d++)
                {
                    char a = (char)input[d];


                    if (a.Equals(' '))
                    {
                        counterSecond = d;
                        break;
                    }

                    if (!a.Equals(' '))
                    {
                        first += input[d];
                    }
                }
                for (int i = counterSecond + 1; i < input.Length; i++)
                {
                    second += input[i];
                }
                
                long firstNumber = long.Parse(first);
                long secondNumber = long.Parse(second);
                

                long firstSum = 0;
                long secondSum = 0;

                if (firstNumber > secondNumber)
                {
                    firstNumber = Math.Abs(firstNumber);
                    while (firstNumber > 0)
                    {
                        firstSum += firstNumber % 10;
                        firstNumber /= 10;
                    }
                    Console.WriteLine(firstSum);
                    
                }
                else
                {
                    secondNumber = Math.Abs(secondNumber);
                    while (secondNumber > 0)
                    {
                        secondSum += secondNumber % 10;
                        secondNumber /= 10;
                    }
                    Console.WriteLine(secondSum);
                    
                }
                firstSum = 0;
                secondSum = 0;
                first = string.Empty;
                second = string.Empty;
            }

        }
    }
}
