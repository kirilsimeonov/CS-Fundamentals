using System;
using System.Linq;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            string topInteger = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                for (int d = i + 1; d < array.Length; d++)
                {
                   
                    if (array[i] > array[d])
                    {
                        counter++;
                    }
                    // counter = 0;
                }
                if (counter==(array.Length-1-i))
                {
                    topInteger += array[i] + " ";
                }
                counter = 0;

            }
            Console.WriteLine(topInteger);
            
        }
    }
}
