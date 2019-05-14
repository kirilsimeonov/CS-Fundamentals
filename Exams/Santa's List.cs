using System;
using System.Collections.Generic;
using System.Linq;

namespace DEMO_MID_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> noisyKids = Console.ReadLine().Split('&').ToList();
            string command = Console.ReadLine();

            while (command!="Finished!")
            {
                List<string> input = command.Split(' ').ToList();

                if (input[0]=="Bad" && !noisyKids.Contains(input[1]))
                {
                    noisyKids.Insert(0,input[1]);
                }
                else if (input[0]=="Good" && noisyKids.Contains(input[1]))
                {
                    noisyKids.Remove(input[1]);
                }
                else if (input[0] == "Rename" && noisyKids.Contains(input[1]))
                {
                    int index = noisyKids.IndexOf(input[1]);
                    noisyKids.RemoveAt(index);
                    noisyKids.Insert(index, input[2]);
                }
                else if (input[0] == "Rearrange" && noisyKids.Contains(input[1]))
                {
                    int index = noisyKids.IndexOf(input[1]);
                    noisyKids.RemoveAt(index);
                    noisyKids.Insert(noisyKids.Count , input[1]);
                }
                

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",noisyKids));
        }
    }
}

