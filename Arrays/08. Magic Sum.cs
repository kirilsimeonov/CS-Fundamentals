using System;
using System.Linq;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                for (int d = i + 1; d < array.Length; d++)
                {
                    if (array[i] + array[d] == num)
                    {
                        Console.WriteLine($"{array[i]} {array[d]}");
                    }
                }
            }
        }
    }
}
