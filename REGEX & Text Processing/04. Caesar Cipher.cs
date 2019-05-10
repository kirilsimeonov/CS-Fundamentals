using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = (char)(input[i] + 3);
            }
            foreach (var item in input)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
