using System;

namespace _09_Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceSabre = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());

            double costSabre = Math.Ceiling(students*1.1) * priceSabre;
            double costRobe = students * priceRobe;
            int discountBelt = students / 6;
            
            double costBelt = (students-discountBelt ) * priceBelt;

            double totalCost = costBelt + costRobe + costSabre;

            if (budget>=totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalCost-budget:f2}lv more.");
            }
        }
    }
}
