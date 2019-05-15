using System;
using System.Linq;
using System.Collections.Generic;

namespace Exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("|").ToList();
            double budget = double.Parse(Console.ReadLine());
            double maxClothes = 50;
            double maxShoes = 35;
            double maxAccessories = 20.5;
            double totalExpense = 0;
            double value = 0;
            List<double> values = new List<double>();

            for (int i = 0; i < items.Count; i++)
            {
                string[] command = items[i].Split("->");
                string item = command[0];
                double price = double.Parse(command[1]);

                if (item=="Clothes" && price<=maxClothes)
                {
                    if (budget>=price)
                    {
                        budget -= price;
                        totalExpense += price;
                        value = price * 1.4;
                        //value = Math.Round(value, 2);
                        values.Add(value);
                    }
                    else
                    {
                        continue;
                    }

                }
                if (item == "Shoes" && price <= maxShoes)
                {
                    if (budget>=price)
                    {
                        budget -= price;
                        totalExpense += price;
                        value = price * 1.4;
                        //value = Math.Round(value, 2);
                        values.Add(value);
                    }
                    else
                    {
                        continue;
                    }

                }
                if (item == "Accessories" && price <= maxAccessories)
                {
                    if (budget>=price)
                    {
                        budget -= price;
                        totalExpense += price;
                        value = (price * 1.4);
                        //value = Math.Round(value, 2);
                        values.Add(value);
                    }
                    else
                    {
                        continue;
                    }

                }

            }
            double valueSum = values.Sum();
            
            double newBudget = budget + valueSum;

            //Console.WriteLine($"{string.Join(" ",values):f2}");

            for (int i = 0; i < values.Count; i++)
            {
                Console.Write($"{values[i]:f2} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {valueSum- totalExpense:f2}");

            if (newBudget>=150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }

        }
    }
}
