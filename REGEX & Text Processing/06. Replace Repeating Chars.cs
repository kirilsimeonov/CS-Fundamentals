using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();
            int sequence = 0;
            List<char> final = new List<char>();
            //final.AddRange(input);

            for (int i = 0; i < input.Count - 1; i++)
            {
                //if (input[i] == input[i + 1])
                //{
                //    continue;
                //}
                if (input[i]!=input[i+1])
                {
                    final.Add(input[i]);
                }
                
                if (i == input.Count - 2)
                {
                    final.Add(input[input.Count - 1]);
                }
            }

            //Console.WriteLine(sequence);
            foreach (var item in final)
            {
                Console.Write(item);
            }

        }
    }
}
