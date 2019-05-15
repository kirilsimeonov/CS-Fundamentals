using System;
using System.Linq;
using System.Collections.Generic;

namespace Exam_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double fuelPerKM = double.Parse(Console.ReadLine());
            double foodExpensesPerPerson = double.Parse(Console.ReadLine());
            double priceRoomPerPerson = double.Parse(Console.ReadLine());
            double totalExpenses = 0;
            double foodExpenses = people * foodExpensesPerPerson * days;
            double hotelExpenses = people * priceRoomPerPerson * days;
            double distance = 0;
            double totalCost = 0;
            double currentExpense = 0;
            
            if (people>10)
            {
                hotelExpenses *= 0.75;
            }
            totalCost += foodExpenses + hotelExpenses;

            for (int i = 1; i <= days; i++)
            {
                distance = int.Parse(Console.ReadLine());
                currentExpense = distance * fuelPerKM;
                totalCost += currentExpense;

                if (i%15==0)
                {
                    double addition = totalCost * 0.4;
                    totalCost += addition;
                }
               else if (i%3==0)
                {
                    double addition = totalCost * 0.4;
                    totalCost += addition;
                }
               else if (i%5==0)
                {
                    double addition = totalCost * 0.4;
                    totalCost += addition;
                }
               else  if (i%7==0)
                {
                    double reduction = totalCost / people;
                    totalCost -= reduction;
                }
                if (totalCost>budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {totalCost-budget:f2}$ more.");
                    return;
                }

            }
            Console.WriteLine($"You have reached the destination. You have {budget-totalCost:f2}$ budget left.");



        }
    }
}
