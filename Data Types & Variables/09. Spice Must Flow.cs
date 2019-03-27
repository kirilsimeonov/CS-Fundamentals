using System;

namespace _9_Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint yield = uint.Parse(Console.ReadLine());

            uint spiceSum = 0;
            int counter = 0;

            while (yield >= 100)
            {
                spiceSum += yield;
                spiceSum -= 26;
                yield -= 10;
                counter++;
            }

            if (spiceSum>=26)
            {
                spiceSum -= 26;
            }
            else
            {
                spiceSum = 0;
            }
            
            Console.WriteLine(counter);
            Console.WriteLine(spiceSum);



        }
    }
}
