using System;
using System.Linq;
using System.Collections.Generic;

namespace AssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();

            string command = Console.ReadLine();
            while (command!="exam finished")
            {
                List<string> input = command.Split('-').ToList();
                string name = input[0];

                if (input[1] == "banned")
                {
                    if (students.ContainsKey(name))
                    {
                        students.Remove(name);
                    }
                }
                else
                {

                    string language = input[1];
                    int grade = int.Parse(input[2]);

                    if (!students.ContainsKey(name))
                    {
                        students[name] = grade;
                    }
                    else if (students.ContainsKey(name) && grade > students[name])
                    {
                        students[name] = grade;
                    }

                    if (!languages.ContainsKey(language))
                    {
                        languages[language] = 0;
                    }
                    languages[language]++;
                }


                command = Console.ReadLine();
               
            }
            var orderedStudents = students.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            Console.WriteLine("Results:");
            foreach (var item in orderedStudents)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");

            }
            var orderedLanguages = languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            Console.WriteLine("Submissions:");
            foreach (var item in orderedLanguages)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
