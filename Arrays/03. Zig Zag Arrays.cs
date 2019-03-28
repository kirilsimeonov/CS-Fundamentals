using System;
using System.Linq;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string first = string.Empty;
            string second = string.Empty;

            for (int i = 0; i < n; i++)
            {

                if (i%2==0)
                {

                    int[] one = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    first += one[0] + " ";
                    second += one[1]+ " ";


                    

                }
                else if (i%2!=0)
                {
                    int[] one = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    first += one[1] + " ";
                    second += one[0] + " ";

                }
               
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
