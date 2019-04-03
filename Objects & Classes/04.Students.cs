using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            List<Students> studentsList = new List<Students>();

            for (int i = 0; i < students; i++)
            {
                studentsList.Add(new Students());
            }

            List<Students> sortedStudents = studentsList.OrderByDescending(x => x.Grade).ToList();
            Print(sortedStudents);

        }
        private static void Print(List<Students> articles)
        {
            for (int i = 0; i < articles.Count; i++)
            {
                Console.WriteLine(articles[i]);
            }
        }
        class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Students()
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                this.FirstName = command[0];
                this.LastName = command[1];
                this.Grade = double.Parse(command[2]);
           }

            public override string ToString()
            {
                string newOverride = $"{FirstName} {LastName}: {Grade:f2}";
                return newOverride;
            }
        }
    }
}

