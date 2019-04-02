using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            
         

            string command = Console.ReadLine();
            while (command!="end")
            {
                int Add = 0;
                if (command.Contains("Add"))
                {
                    
                    Add = AddPassengers(command);
                    wagons.Add(Add);

                }
                else
                {
                    int passengersToBeAdd = int.Parse(command);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int spaceLeftinCurrentWagon = capacity - wagons[i];
                        if (spaceLeftinCurrentWagon>=passengersToBeAdd)
                        {
                            wagons[i] += passengersToBeAdd;
                            break;
                        }
                    }
                }

                
                
                
                
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));

        }

        

        private static int AddPassengers(string command)
        {

            string[] Add = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            int passengersToBeAdded = int.Parse(Add[1]);

            return passengersToBeAdded;
            
        }

        private static int Passengers(string command)
        {
            
            return 1;
        }
    }
}

