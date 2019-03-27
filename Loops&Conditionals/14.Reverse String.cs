using System;

namespace _4_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = name.Length-1; i >= 0; i--)
            {
                reverse += name[i];
            }

            Console.WriteLine(reverse);
        }
    }
}
