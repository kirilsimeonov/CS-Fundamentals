using System;

namespace _3_Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double originalBudget = budget;
            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${originalBudget-budget:f2}. Remaining: ${budget:f2}");
                    return;
                }
                else if (command=="OutFall 4")
                {
                    if (budget>=39.99)
                    {
                        Console.WriteLine($"Bought {command}");
                        budget -= 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                   
                }
                else if (command=="CS: OG")
                {
                    if (budget >= 15.99)
                    {
                        Console.WriteLine($"Bought {command}");
                        budget -= 15.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "Zplinter Zell")
                {
                    if (budget >= 19.99)
                    {
                        Console.WriteLine($"Bought {command}");
                        budget -= 19.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "Honored 2")
                {
                    if (budget >= 59.99)
                    {
                        Console.WriteLine($"Bought {command}");
                        budget -= 59.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "RoverWatch")
                {
                    if (budget >= 29.99)
                    {
                        Console.WriteLine($"Bought {command}");
                        budget -= 29.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    if (budget >= 39.99)
                    {
                        Console.WriteLine($"Bought {command}");
                        budget -= 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (budget==0)
                {
                    Console.WriteLine("Ou of money!");
                    return;
                }
            }
        }
    }
}
