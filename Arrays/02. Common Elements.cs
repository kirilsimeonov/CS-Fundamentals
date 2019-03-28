using System;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split().ToArray();
       
            string[] second = Console.ReadLine().Split().ToArray();
            string common = string.Empty;

           

            for (int i = 0; i < second.Length; i++)
            {
                for (int d = 0; d < first.Length; d++)
                {
                    if (second[i] == first[d])
                    {
                        common += second[i] + " ";
                       
                    }
                }
            }
            Console.WriteLine(common);
        }
    }
}
