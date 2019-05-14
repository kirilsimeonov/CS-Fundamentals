using System;
using System.Linq;
using System.Collections.Generic;

namespace DemoFinalExam1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();

            Dictionary<string, double> games = new Dictionary<string, double>();
            Dictionary<string, string> dlc = new Dictionary<string, string>();

            foreach (var item in input)
            {
                if (item.Contains("-"))
                {
                    string[] current = item.Split("-");
                    string name = current[0];
                    double price = double.Parse(current[1]);

                    games[name] = price;

                }
                else if (item.Contains(":"))
                {
                    string[] current = item.Split(":");
                    string name = current[0];
                    string content = current[1];

                    if (games.ContainsKey(name))
                    {
                        dlc[name] = content;
                        games[name] *= 1.2;
                    }
                }

            }
            Dictionary<string, double> final = new Dictionary<string, double>();
            Dictionary<string, double> finalDLC = new Dictionary<string, double>(); 

            foreach (var item in games)
            {
                if (dlc.ContainsKey(item.Key))
                {
                    finalDLC[item.Key] = item.Value * 0.5;
                }
               
            }
            foreach (var item in games)
            {
                if (!dlc.ContainsKey(item.Key))
                {
                     
                        final[item.Key] = item.Value * 0.8;
                    
                }
            }

            var listDLC = finalDLC.OrderBy(x => x.Value);
            var list = final.OrderByDescending(x => x.Value);

            foreach (var item in listDLC)
            {
                Console.WriteLine($"{item.Key} - {dlc[item.Key]} - {item.Value:f2}");
            }
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value:f2}");
            }

        }
    }
}
