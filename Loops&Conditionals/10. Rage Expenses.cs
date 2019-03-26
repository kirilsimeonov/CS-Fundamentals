using System;

namespace _10__Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousetPrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            
            int trashedHeadset = lostGames / 2;
            int trashedMouse = lostGames/3;
            int trashedKeboard = lostGames / 6; ;
            int trashedDisplay = lostGames / 12 ;

            double rageExpense = trashedHeadset * headsetPrice + trashedMouse * mousetPrice + trashedKeboard * keyboardPrice + trashedDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {rageExpense:f2} lv.");


        }
    }
}
