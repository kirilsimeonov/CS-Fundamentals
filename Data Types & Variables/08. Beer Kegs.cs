using System;

namespace _8_Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string model = string.Empty;
            float radius = 0;
            int height = 0;
            double volume = 0;
            double maxVol = double.MinValue;
            string maxModel = string.Empty;

            for (int i = 0; i < n; i++)
            {
                model = Console.ReadLine();
                radius = float.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                volume = Math.PI * radius * radius * height;

                if (volume>maxVol)
                {
                    maxVol = volume;
                    maxModel = model;
                }
            }
            Console.WriteLine(maxModel);
        }
    }
}
