using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> cars = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                if (command[0]=="register")
                {
                    if (cars.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {cars[command[1]]}");
                    }
                    else
                    {
                        cars[command[1]] = command[2];
                        Console.WriteLine($"{command[1]} registered {cars[command[1]]} successfully");
                    }

                }
                else if (command[0]=="unregister")
                {
                    if (!cars.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                    else
                    {
                        cars.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                }
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
