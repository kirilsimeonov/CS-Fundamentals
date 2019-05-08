using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command!="end")
            {
                List<string> input = command.Split(" : ").ToList();
                var course = input[0];
                var student = input[1];

                if (!courses.ContainsKey(course))
                {
                    courses[course] = new List<string>();
                    
                }
                courses[course].Add(student);

                command = Console.ReadLine();
            }
            var orderedCourses = courses.OrderByDescending(x => x.Value.Count());

            foreach (var item in orderedCourses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                var orderedNames = item.Value.OrderBy(x => x);
                foreach (var student in orderedNames)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
