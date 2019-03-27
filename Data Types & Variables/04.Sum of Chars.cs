using System;

namespace _4_Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = n;
            int sum = 0;

            while (counter>0)
            {
                char l = char.Parse(Console.ReadLine());
                sum += (int)l;
                counter--;
            }
            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}
