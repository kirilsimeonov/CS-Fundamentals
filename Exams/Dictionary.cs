using System;
using System.Linq;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> definitions = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" | ");

            foreach (var item in input)
            {
                var command = item.Split(": ");
                string name = command[0];
                string def = command[1];

                if (!definitions.ContainsKey(name))
                {
                    definitions[name] = new List<string>();
                  
                }

                definitions[name].Add(def);

            }
            string[] input2 = Console.ReadLine().Split(" | ");



            foreach (var item in input2)
            {

                if (definitions.ContainsKey(item))
                {
                    Console.WriteLine(item);
                    var ordered = definitions[item].OrderByDescending(x => x.Length);
                    foreach (var list in ordered)
                    {
                        Console.WriteLine($" -{list}");
                    }
                }

            }

            string final = Console.ReadLine();
            if (final=="List")
            {
                var orderedWords = definitions.OrderBy(x => x.Key);
                foreach (var item in orderedWords)
                {
                    Console.Write(item.Key + " ");
                }
            }

        }
    }
}

