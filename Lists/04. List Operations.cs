using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercuse_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command!="End")
            {
                var commandArray = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commandArray[0]=="Add")
                {
                    int add = int.Parse(commandArray[1]);
                    integers.Add(add);
                   
                }
                if (commandArray[0]=="Remove")
                {
                    int remove = int.Parse(commandArray[1]);
                    if (remove < 0 || remove > integers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        integers.RemoveAt(remove);
                        
                    }
                }
                if (commandArray[0]=="Insert")
                {
                    int add = int.Parse(commandArray[1]);
                    int addIndex = int.Parse(commandArray[2]);
                    if (addIndex < 0 || addIndex > integers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        integers.Insert(addIndex, add);
                        
                    }
                }
                if (commandArray[0]=="Shift")
                {
                    if (commandArray[1]=="left")
                    {
                        int left = int.Parse(commandArray[2]);
                        integers = ShiftLeft(left,integers);
                        
                    }
                    if (commandArray[1]=="right")
                    {
                        int right = int.Parse(commandArray[2]);
                        integers = ShiftRight(right, integers);
                        
                    }
                }



                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", integers));
        }

        private static List<int> ShiftLeft(int left, List<int> integers)
        {
            List<int> numbers = integers;
      

            for (int d = 0; d < left; d++)
            {
                int original = numbers[0];
                for (int i = 0; i < numbers.Count - 1; i++)
                {

                    numbers[i] = numbers[i + 1];


                }
                numbers[numbers.Count - 1] = original;
                
            }
            return numbers;
        }

        private static List<int> ShiftRight(int right, List<int> integers)
        {
            List<int> numbers = integers;


            for (int d = 0; d < right; d++)
            {
                int original = numbers[numbers.Count-1];
                for (int i = numbers.Count - 1; i > 0 ; i--)
                {

                    numbers[i] = numbers[i -1];


                }
                numbers[0] = original;
                
            }
            return numbers;
        }
    }
}

