using System;

namespace _7_Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int q = 0;
            int capacity = 255;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                q = int.Parse(Console.ReadLine());

                if (q<=capacity)
                {
                    capacity -= q;
                    sum += q;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                

            }
            Console.WriteLine(sum);
        }
    }
}
