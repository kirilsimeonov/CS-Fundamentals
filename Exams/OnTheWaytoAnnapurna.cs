using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> stores = new Dictionary<string, List<string>>();

            while (input!="END")
            {
                List<string> command = input.Split("->").ToList();
                string task = command[0];
                string store = command[1];

                if (task=="Add")
                {
                    if (!command[2].Contains(','))
                    {
                        string items = command[2];
                        if (!stores.ContainsKey(store))
                        {
                            stores[store] = new List<string>();
                        }
                        stores[store].Add(items);
                    }
                    else if (command[2].Contains(','))
                    {
                        List<string> itemList = command[2].Split(",").ToList();
                        if (!stores.ContainsKey(store))
                        {
                            stores[store] = new List<string>();
                        }
                        foreach (var item in itemList)
                        {
                            stores[store].Add(item);
                        }
                    }
                }
                else if (task=="Remove")
                {
                    if (stores.ContainsKey(store))
                    {
                        stores.Remove(store);
                    }
                }

                input = Console.ReadLine();
            }


            Console.WriteLine("Stores list:");
            var orderedstores = stores.OrderByDescending(x => x.Value.Count()).ThenByDescending(x=>x.Key);
            foreach (var item in orderedstores)
            {
                Console.WriteLine(item.Key);
                var orderedItems = item.Value;
                foreach (var lists in orderedItems)
                {
                    Console.WriteLine($"<<{lists}>>");
                }
            }
        }
    }
}

