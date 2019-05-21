using System;

namespace _1._Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
            double flour=0;
            double sugar=0;
            double cocoa=0;
            double singleCookieGrams = 25;
            double cup = 140;
            double smallSpoon = 10;
            double bigSpoon = 20;
            double cookiesPerBox = 5;
            int totalBoxes = 0;
           
            for (int i = 0; i < batches; i++)
            {
                flour = double.Parse(Console.ReadLine());
                sugar = double.Parse(Console.ReadLine());
                cocoa = double.Parse(Console.ReadLine());

                int flourCups = ((int)flour / (int)cup);
                int sugarSpoons = (int)(sugar / bigSpoon);
                int cocoaSpoons = (int)(cocoa / smallSpoon);

                double cookiesPerBake = ((cup + smallSpoon + bigSpoon) * Math.Min(Math.Min(flourCups, sugarSpoons), cocoaSpoons)) / singleCookieGrams;
                double boxesPerBatch = Math.Floor(cookiesPerBake / cookiesPerBox);

                if (boxesPerBatch>0)
                {
                    Console.WriteLine($"Boxes of cookies: {boxesPerBatch}");
                    totalBoxes += (int)boxesPerBatch;
                }
                else
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
                
            }
            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
