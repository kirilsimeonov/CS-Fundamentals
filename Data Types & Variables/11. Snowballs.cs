using System;
using System.Numerics;

namespace _11_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger maxValue = int.MinValue;
            double maxTime = 0;
            double maxSnow = 0;
            double maxQuality = 0;
            

            for (int i = 0; i < n; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime) , snowballQuality);
                if (snowballValue>maxValue)
                {
                    maxValue = snowballValue;
                    maxTime = snowballTime;
                    maxSnow = snowballSnow;
                    maxQuality = snowballQuality;

                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
        }
    }
}
