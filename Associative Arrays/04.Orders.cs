using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command=="buy")
                {
                    break;
                }

                List<string> input = command.Split(' ').ToList();

                if (!products.ContainsKey(input[0]))

                {
                    products[input[0]] = new List<double>();
                    products[input[0]].Add(double.Parse(input[1]));
                    products[input[0]].Add(double.Parse(input[2]));
                }
                else
                {
                    var price = products[input[0]].ElementAt(0);
                    var quantity = products[input[0]].ElementAt(1);
                    products[input[0]].Clear();
                    products[input[0]].Add(double.Parse(input[1]));
                    products[input[0]].Add(double.Parse(input[2])+quantity);

                    //Console.WriteLine(products[input[0]].ElementAt(0)  ); 
                }

               
            }
            foreach (var item in products)
            {
                double sum = item.Value.ElementAt(0) * item.Value.ElementAt(1);
                Console.WriteLine($"{item.Key} -> {sum:f2}");
            }

        }
    }
}
