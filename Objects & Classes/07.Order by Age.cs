using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Person> persons = new List<Person>();

            while (command!="End")
            {
                persons.Add(new Person(command));

                command = Console.ReadLine();
            }
            List<Person> sortedPersons = persons.OrderBy(x =>x.Age).ToList();

            for (int i = 0; i < sortedPersons.Count; i++)
            {
                Console.WriteLine(sortedPersons[i]);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string command)
        {
            string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            this.Name = input[0];
            this.ID = input[1];
            this.Age = int.Parse(input[2]);
        }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }


    }
}

