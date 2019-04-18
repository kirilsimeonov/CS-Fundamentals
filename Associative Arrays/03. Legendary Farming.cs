using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            items["shards"] = 0;
            items["motes"] = 0;
            items["fragments"] = 0;
            Dictionary<string, int> junkItems = new Dictionary<string, int>();


            while (true)
            {
                //if (items.Any(x=>x.Value>=250))
                //{
                //    Console.WriteLine("Yes");
                //}
                
                List<string> input = Console.ReadLine().ToLower().Split(' ').ToList();
                for (int i = 0; i < input.Count; i += 2)
                {
                    if (input[i+1]=="motes" || input[i + 1] == "shards" || input[i + 1] == "fragments")
                    {
                        {
                            items[input[i + 1]] += int.Parse(input[i]);
                            if (items[input[i+1]]>=250)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (junkItems.ContainsKey(input[i + 1]))
                        {
                            junkItems[input[i + 1]] += int.Parse(input[i]);
                        }
                        else
                        {
                            junkItems[input[i + 1]] = int.Parse(input[i]);
                        }
                    }
                    

                }
                if (items.ContainsKey("shards") && items["shards"] >= 250)
                {
                    Console.WriteLine("Shadowmourne obtained!");
                    items["shards"] -= 250;
                    break;
                }
                if (items.ContainsKey("fragments") && items["fragments"] >= 250)
                {
                    Console.WriteLine("Valanyr obtained!");
                    items["fragments"] -= 250;
                    break;
                }
                if (items.ContainsKey("motes") && items["motes"] >= 250)
                {
                    Console.WriteLine("Dragonwrath obtained!");
                    items["motes"] -= 250;
                    break;
                }
                //foreach (var item in items)
                //{
                //    Console.WriteLine($"{item.Key}: {item.Value}");
                //}
                //foreach (var item in junkItems)
                //{
                //    Console.WriteLine($"{item.Key}: {item.Value}");
                //}

            }

            var sortedItems = items.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key);
            var sortedJunk = junkItems.OrderBy(x => x.Key);
            foreach (var item in sortedItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in sortedJunk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
