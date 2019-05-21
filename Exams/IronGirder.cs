using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace IronGrinder
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Dictionary<string, int> times = new Dictionary<string, int>();
            var passengers = new Dictionary<string, int>();

            while (input != "Slide rule")
            {
                List<string> command = input.Split(":").ToList();
                string town = command[0];

                string restOfInput = command[1];

                List<string> input2 = restOfInput.Split("->").ToList();
                int travellers = int.Parse(input2[1]);

                if (input2[0] == "ambush")
                {
                    if (times.ContainsKey(town))
                    {
                        times[town] = 0;
                    }
                    if (passengers.ContainsKey(town))
                    {
                        passengers[town] -= travellers;
                        if (passengers[town]<0)
                        {
                            passengers[town] = 0;
                        }
                    }
                }
                else
                {
                    int time = int.Parse(input2[0]);





                    if (!times.ContainsKey(town))
                    {
                        times[town] = time;
                    }
                    else if (times[town]==0)
                    {
                        times[town] = time;
                    }
                    else if (times[town] > time)
                    {
                        times[town] = time;
                    }

                    if (!passengers.ContainsKey(town))
                    {
                        passengers[town] = 0;
                    }
                    passengers[town] += travellers;
                }
                //foreach (var item in times)
                //{
                //    Console.WriteLine($"{item.Key} - {item.Value}");
                //}
                //foreach (var item in passengers)
                //{
                //    Console.WriteLine($"{item.Key} - {item.Value}");
                //}
                input = Console.ReadLine();

            }
            var orderedTimes = times.OrderBy(x => x.Value).ThenBy(x => x.Key);
            foreach (var item in orderedTimes)
            {
                if (item.Value>0 && passengers[item.Key]>0)
                {
                    Console.WriteLine($"{item.Key} -> Time: {item.Value} -> Passengers: {passengers[item.Key]}");
                }

            }
        }
    }
}
