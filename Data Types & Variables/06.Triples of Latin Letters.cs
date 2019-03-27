using System;

namespace _6_Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int last = 97 + n;
            for (int i = 97; i < last; i++)
            {
                for (int k = 97; k < last; k++)
                {
                    for (int d = 97; d < last; d++)
                    {
                        Console.WriteLine($"{(char)i}{(char)k}{(char)d}");
                    }
                }
            }
        }
    }
}
