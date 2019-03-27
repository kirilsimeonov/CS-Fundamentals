using System;

namespace _5_Print_Part_of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());

            for (int i = first; i <= last; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
