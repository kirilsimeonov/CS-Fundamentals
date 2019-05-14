using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split('@').Select(int.Parse).Where(x => x % 2 == 0 && x>=0).ToList();
            
            string command = Console.ReadLine();
            int santaPosition = 0;
            while (command!="Merry Xmas!")
            {
                string[] input = command.Split(' ');
                int jumps = int.Parse(input[1]);
                santaPosition += jumps;
                while (santaPosition>houses.Count-1)
                {
                    santaPosition -= houses.Count;
                }
                // Console.WriteLine(santaPosition);
                if (houses[santaPosition] > 0)
                {
                    houses[santaPosition] -= 2;
                }
                else if (houses[santaPosition] == 0)
                {
                    Console.WriteLine($"House {santaPosition} will have a Merry Christmas.");
                }








               // Console.WriteLine(houses[santaPosition]);
                command = Console.ReadLine();
            }
            Console.WriteLine($"Santa's last position was {santaPosition}.");

           
           if (houses.Sum()==0)
           {
                Console.WriteLine("Mission was successful.");
           }
            else
            {
                int[] sorted = houses.Where(x => x > 0).ToArray();
                Console.WriteLine($"Santa has failed {sorted.Length} houses.");
            }
        }
    }
}
