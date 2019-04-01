using System;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool isDivisible = DivisibleByEight(i);

                bool hasOddDigit = HasOddDigit(i);
                if (isDivisible==true && hasOddDigit==true)
                {
                    Console.WriteLine(i);
                }

            }
        }

        private static bool DivisibleByEight(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private static bool HasOddDigit(int i)
        {
            int counter = 0;
            while (i > 0)
            {
                int lastDigit = i % 10;
                if (lastDigit % 2 != 0)
                {
                    counter++;
                }
                i /= 10;
            }
            if (counter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            {

            }
        }
    }
}
