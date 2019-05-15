using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo_Exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> days = Console.ReadLine().Split('|',StringSplitOptions.RemoveEmptyEntries).ToList();
            double energy = 100;
            double coins = 100;
            

            for (int i = 0; i < days.Count; i++)
            {
                List<string> input = days[i].Split('-',StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = input[0];
                double value = double.Parse(input[1]);

                if (command=="rest")
                {
                    double initialEnergy = energy;
                    double gainedEnergy = value;
                    energy += value;
                    if (energy>100)
                    {
                        energy = 100;
                        gainedEnergy = 100 - initialEnergy;
                    }
                    Console.WriteLine($"You gained {gainedEnergy} energy.");
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (command=="order")
                {
                    
                    if (energy>=30)
                    {
                        Console.WriteLine($"You earned {value} coins.");
                        energy -= 30;
                        coins += value;
                    }
                    else
                    {
                        Console.WriteLine($"You had to rest!");
                        energy += 50;
                        
                    }
                }
                else
                {
                    if (coins>value)
                    {
                        Console.WriteLine($"You bought {command}.");
                        coins -= value;
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {command}.");
                        return;
                    }
                    
                }

                

            }
            Console.WriteLine($"Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
            
            

        }
    }
}
