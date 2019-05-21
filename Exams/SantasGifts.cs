using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace One
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<int> houseNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int currentIndex = 0;

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "Forward")
                {
                    int steps = int.Parse(command[1]);
                    if (currentIndex+steps>=0 && currentIndex + steps < houseNumbers.Count)
                    {
                        currentIndex += steps;
                        houseNumbers.RemoveAt(currentIndex);
                    }
                }
                else if (command[0] == "Back")
                {
                    int steps = int.Parse(command[1]);
                    if (currentIndex - steps >= 0)
                    {
                        currentIndex -= steps;
                        houseNumbers.RemoveAt(currentIndex);
                    }
                }
                else if (command[0] == "Gift")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < houseNumbers.Count)
                    {
                        houseNumbers.Insert(index, int.Parse(command[2]));
                        currentIndex = index;
                    }


                }
                else if (command[0] == "Swap")
                {
                    int firstNum = int.Parse(command[1]);
                    int secondNum = int.Parse(command[2]);

                    if (houseNumbers.Contains(firstNum) && houseNumbers.Contains(secondNum))
                    {
                        int firstIndex = houseNumbers.IndexOf(firstNum);
                        int secondIndex = houseNumbers.IndexOf(secondNum);

                        int changedNumber = houseNumbers[firstIndex];
                        houseNumbers[firstIndex] = houseNumbers[secondIndex];
                        houseNumbers[secondIndex] = changedNumber;
                    }

                }
            }
            Console.WriteLine($"Position: {currentIndex}");
            Console.WriteLine(string.Join(", ", houseNumbers));
        }
    }
}
