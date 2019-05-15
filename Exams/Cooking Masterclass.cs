using System;

namespace Demo_Exam_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceEgg = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());

            int freePackage = students / 5;
            
            double moneyNeeded = (students-freePackage) * priceFlour + students *10* priceEgg + Math.Ceiling(students*1.2) * priceApron;

            if (budget>=moneyNeeded)
            {
                Console.WriteLine($"Items purchased for {moneyNeeded:f2}$.");
            }
            else
            {
                Console.WriteLine($"{moneyNeeded-budget:f2}$ more needed.");
            }
            






        }
    }
}
