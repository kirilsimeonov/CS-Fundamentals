using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command!="End")
            {
                List<string> input = command.Split(" -> ").ToList();
                var company = input[0];
                var employee = input[1];

                if (!companies.ContainsKey(company))
                {
                    companies[company] = new List<string>();
                    companies[company].Add(employee);
                }
                else
                {
                    if (!companies[company].Contains(employee))
                    {
                        companies[company].Add(employee);
                    }
                }
                
                



                command = Console.ReadLine();
            }
            var orderedCompanies= companies.OrderBy(x => x.Key);
            foreach (var item in orderedCompanies)
            {
                Console.WriteLine($"{item.Key}");
                //var orderedEmployee = item.Value.OrderBy(x=>x);
                foreach (var employee in item.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
