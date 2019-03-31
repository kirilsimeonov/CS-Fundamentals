using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            PrintCharactersInRange(a, b);
        }

        private static void PrintCharactersInRange(char a, char b)
        {

            if (a<b)
            {
                for (char i = (char)(int)(a + 1); i < b; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                for (char i = (char)(int)(b + 1); i < a ; i++)
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}
