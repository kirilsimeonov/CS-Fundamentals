using System;
 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
 
                if (input == "END")
                {
                    return;
                }
                int number = 0;
                char symbol = ' ';
                float floating = 0.0f;
                bool isBool;
 
                if (bool.TryParse(input, out isBool))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (int.TryParse(input, out number))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (char.TryParse(input, out symbol))
                {
                    Console.WriteLine($"{symbol} is character type");
                }
                else if (float.TryParse(input, out floating))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
 
            }
        }
    }
}
