using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;


namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char,int> dic = new Dictionary<char,int>();

            char[] sequence = Console.ReadLine().Where(x => x != ' ').ToArray();


            foreach (var item in sequence)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic[item] = 1;
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
