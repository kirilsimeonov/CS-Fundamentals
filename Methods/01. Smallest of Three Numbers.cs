using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int smallest = SmallestInteger(n1, n2, n3);
            Console.WriteLine(smallest);
        }

        private static int SmallestInteger(int n1, int n2, int n3)
        {
            int smallestInt = int.MaxValue;
            if (n1<smallestInt)
            {
                smallestInt = n1;
            }
            if (n2 < smallestInt)
            {
                smallestInt = n2;
            }
            if (n3 < smallestInt)
            {
                smallestInt = n3;
            }
            return smallestInt;

        }
    }
}
