using System;
using System.Collections.Generic;
using System.Linq;

namespace InternationalSoftuniada
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> countries = new Dictionary<string, Dictionary<string, int>>();

            while (input!="END")
            {
                List<string> command = input.Split(" -> ").ToList();
                string country = command[0];
                string name = command[1];
                int points = int.Parse(command[2]);
               
                if (!countries.ContainsKey(country))
                {
                    countries[country] = new Dictionary<string, int>();
                    countries[country].Add(name, points);
                }
                else if (countries.ContainsKey(country) && !countries[country].ContainsKey(name))
                {
                    countries[country].Add(name, points);
                }
                else
                {
                    countries[country][name] += points;
                }



                input = Console.ReadLine();
            }

            //foreach (var item in countries)
            //{
            //    var orderedName = item.Value.OrderByDescending(x => x.Value);
            //    foreach (var name in orderedName)
            //    {
            //        Console.WriteLine($"{name.Key} -> {name.Value}");
            //    }
            //}
            var orderedCountries = countries.OrderByDescending(x=>x.Value.Values.Sum());
            foreach (var item in orderedCountries)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()}");

                var ordName = item.Value;
                foreach (var name in ordName)
                {
                    Console.WriteLine($" -- {name.Key} -> {name.Value}");
                }
                //Console.WriteLine(string.Join(" ",item.Value.Keys));
            }
        }
    }
}
