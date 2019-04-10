using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string command = string.Empty;
            int quantity = 0;

            while (true)
            {
                command = Console.ReadLine();
                if (command=="stop")
                {
                    break;
                }
                
                quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(command))
                {
                    resources[command] += quantity;
                }
                else
                {
                    resources[command] = quantity;
                }
                


               
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
