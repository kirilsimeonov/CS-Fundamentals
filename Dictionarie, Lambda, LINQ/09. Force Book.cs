using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command!="Lumpawaroo")
            {

                if (command.Contains(" | "))
                {
                    List<string> input = command.Split(" | ").ToList();

                    bool userExists = false;
                    foreach (var item in sides)
                    {
                        if (item.Value.Contains(input[1]))
                        {
                            userExists = true;
                        }
                        // Console.WriteLine($"{input[0]} -> {userExists}");
                    }

                    if (!sides.ContainsKey(input[0]))
                    {
                        sides[input[0]] = new List<string>();
                    }
                    if (!userExists)
                    {
                        sides[input[0]].Add(input[1]);
                    }

                }
                else if (command.Contains(" -> "))
                {
                    List<string> input = command.Split(" -> ").ToList();

                    bool userExists = false;
                    foreach (var item in sides)
                    {
                        if (item.Value.Contains(input[0]))
                        {
                            userExists = true;
                        }
                       // Console.WriteLine($"{input[0]} -> {userExists}");
                    }
                    if (!userExists)
                    {
                        if (!sides.ContainsKey(input[1]))
                        {
                            sides[input[1]] = new List<string>();
                            
                        }
                        sides[input[1]].Add(input[0]);
                    }
                    else
                    {
                        foreach (var item in sides)
                        {
                            if (item.Value.Contains(input[0]))
                            {
                                item.Value.Remove(input[0]);
                            }
                        }
                        if (!sides.ContainsKey(input[1]))
                        {
                            sides[input[1]] = new List<string>();

                        }
                        sides[input[1]].Add(input[0]);

                    }
                    Console.WriteLine($"{input[0]} joins the {input[1]} side!");
                }

               
                
                command = Console.ReadLine();
            }
            var ordererdSide = sides.OrderByDescending(x => x.Value.Count()).ThenBy(x=>x.Key).Where(x=>x.Value.Count()>0);
            foreach (var item in ordererdSide)
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                var orderedPlayers = item.Value.OrderBy(x => x);

                foreach (var player in orderedPlayers)
                {
                    Console.WriteLine($"! {player}");
                }
            }
        }
    }
}
