using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Dungeons_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            int health = 100;
            int coins = 0;

            for (int i = 0; i < input.Count; i++)
            {
                string currentCommand = input[i];
                List<string> current = currentCommand.Split().ToList();

                if (current[0]=="chest")
                {
                    coins += int.Parse(current[1]);
                    Console.WriteLine($"You found {current[1]} coins.");
                }
                else if (current[0]=="potion")
                {
                    int initialHealth = health;
                health += int.Parse(current[1]);
                    int healedFor = int.Parse(current[1]);
                    if (health>100)
                    {
                        health = 100;
                        healedFor = 100 - initialHealth;
                        
                    }
                    Console.WriteLine($"You healed for {healedFor} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else 
                {
                    health -= int.Parse(current[1]);
                    if (health<=0)
                    {
                        Console.WriteLine($"You died! Killed by {current[0]}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {current[0]}.");
                    }
                }




            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");

        }
    }
}

