using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command!="end")
            {
                int add = 0;
                int addPosition = 0;
                int remove = 0;
                if (command.Contains("Insert"))
                {
                    add = Insert(command);
                    addPosition = InsertPosition(command);
                    integers.Insert(addPosition,add);
                }
                else if (command.Contains("Delete"))
                {
                    remove = Insert(command);
                    integers.RemoveAll(x => x==remove);
                }

                
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", integers));

        }

        private static int Remove(string command)
        {
            return 1;
        }

        private static int Insert(string command)
        {

            string[] Add = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            int insert = int.Parse(Add[1]);

            return insert;

        }
        private static int InsertPosition(string command)
        {

            string[] Add= command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            int insert = int.Parse(Add[2]);

            return insert;

        }
    }
}

