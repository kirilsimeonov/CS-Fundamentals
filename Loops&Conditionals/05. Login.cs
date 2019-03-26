using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = string.Empty;
            string command = string.Empty;
            int counter = 0;

            for (int i = user.Length-1; i >= 0; i--)
            {
                pass += user[i];
            }

            while (true)
            {
                command = Console.ReadLine();
                if (command==pass)
                {
                    Console.WriteLine($"User {user} logged in.");
                    return;
                }
                else
                {
                    counter++;
                    if (counter<4)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                   
                    
                }

                if (counter==4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    return;
                }
            }
        
        }
    }
}
