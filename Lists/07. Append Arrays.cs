using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {

            //string input = Console.ReadLine().Replace(" ", string.Empty);

            List<string> input2 = Console.ReadLine().Split('|').ToList();
            List<string> newList = new List<string>();
            for (int i = input2.Count - 1; i >= 0; i--)
            {
                string temp = input2[i];
                List<string> list2 = temp.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                newList.AddRange(list2);
            }

            Console.WriteLine(string.Join(" ", newList));
            //List<int> indexes = new List<int>();

            //int start = 0;
            //int at = 0;
            //while (start < input.Length)
            //{
            //    at = input.IndexOf('|', start);
            //    if (at == -1)
            //    {
            //        break;
            //    }
            //    indexes.Add(at);
            //    Console.WriteLine(at);
            //    start = at + 1;
            //}
            //Console.WriteLine(string.Join(" ", indexes));


        }
    }
}

