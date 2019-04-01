using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleChar(input);
        }

        private static void MiddleChar(string input)
        {
            int length = input.Length;
            if (length % 2 == 0)
            {

                Console.Write(input[length / 2 - 1]);
                Console.Write(input[length / 2]);
            }
            else
            {
                Console.WriteLine(input[(length-1)/2]);
            }
        }
    }
}
