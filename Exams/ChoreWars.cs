using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace ChoreWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex dishes = new Regex(@"<[a-z0-9]*>");
            Regex house = new Regex(@"\[[A-Z0-9]*\]");
            Regex laundry = new Regex(@"\{.*\}");
            int dishesTime = 0;
            int houseTime = 0;
            int laundryTime = 0;

            
            string input = Console.ReadLine();

            while (input!="wife is happy")
            {
                if (dishes.IsMatch(input))
                {
                    //Console.WriteLine(dishes.Match(input));
                    string current = string.Empty;
                    current += dishes.Match(input);
                    for (int i = 0; i < current.Length; i++)
                    {
                        if (char.IsDigit(current[i]))
                        {
                            dishesTime += int.Parse(current[i].ToString());
                        }
                    }
                    //Console.WriteLine(dishesTime);
                }
                else if (house.IsMatch(input))
                {
                    string current = string.Empty;
                    current += house.Match(input);
                    for (int i = 0; i < current.Length; i++)
                    {
                        if (char.IsDigit(current[i]))
                        {
                            houseTime += int.Parse(current[i].ToString());
                        }
                    }
                }
                else if (laundry.IsMatch(input))
                {
                    string current = string.Empty;
                    current += laundry.Match(input);
                    for (int i = 0; i < current.Length; i++)
                    {
                        if (char.IsDigit(current[i]))
                        {
                            laundryTime += int.Parse(current[i].ToString());
                        }
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Doing the dishes - {dishesTime} min.");
            Console.WriteLine($"Cleaning the house - {houseTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTime} min.");
            Console.WriteLine($"Total - {dishesTime+houseTime+laundryTime} min.");
        }
    }
}
