using System;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            
            CountVowels(input);
        }

        private static void CountVowels(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='a' || input[i] == 'o' || input[i] == 'e' || input[i] == 'i' || input[i] == 'u' || input[i] == 'y')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
