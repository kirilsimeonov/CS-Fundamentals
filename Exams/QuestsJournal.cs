using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "Retire!")
            {
                string[] inputCommand = input.Split(" - ");

                if (inputCommand[0] == "Start" && !command.Contains(inputCommand[1]))
                {
                    command.Add(inputCommand[1]);
                }

                if (inputCommand[0] == "Complete" && command.Contains(inputCommand[1]))
                {
                    command.Remove(inputCommand[1]);
                }

                if (inputCommand[0] == "Renew" && command.Contains(inputCommand[1]))
                {
                    int index = command.IndexOf(inputCommand[1]);
                    command.Remove(inputCommand[1]);
                    command.Add(inputCommand[1]);
                }

                if (inputCommand[0] == "Side Quest")
                {
                    string[] side = inputCommand[1].Split(':');
                    if (command.Contains(side[0]) && !command.Contains(side[1]))
                    {
                        int index = command.IndexOf(side[0]);
                        command.Insert(index+1,side[1]);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",command));
        }



        }

    }



