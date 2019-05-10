using System;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            char[] first = input[0].ToCharArray(); 
            char[] second = input[1].ToCharArray();

            int sum = 0;

            int multiplicationIndex = Math.Min(first.Length, second.Length);
            
            for (int i = 0; i < multiplicationIndex; i++)
            {
                sum += first[i] * second[i];
            }
            if (first.Length>second.Length)
            {
                for (int i = multiplicationIndex; i < first.Length;i++)
                {
                    sum += first[i];
                }
            }
            else
            {
                for (int i = multiplicationIndex; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }
           
            Console.WriteLine(sum);
        }
    }
}
