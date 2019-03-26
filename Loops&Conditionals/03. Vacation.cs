using System;

namespace Tech_Module_Lecture_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (type=="Students")
            {
                if (day=="Friday")
                {
                    price = 8.45;
                }
                if (day == "Saturday")
                {
                    price = 9.80;
                }
                if (day == "Sunday")
                {
                    price = 10.46;
                }
                if (num>=30)
                {
                    price *= 0.85;
                }
            }
            if (type=="Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                if (day == "Saturday")
                {
                    price = 15.60;
                }
                if (day == "Sunday")
                {
                    price = 16;
                }
                if (num>=100)
                {
                    num -= 10;
                }
            }
            if (type=="Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                if (day == "Saturday")
                {
                    price = 20;

                }
                if (day == "Sunday")
                {
                    price = 22.50;
                }
                if (num>=10 && num<=20)
                {
                    price *= 0.95;
                }
            }
            double total = num * price;
            Console.WriteLine($"Total price: {total:f2}");



        }
    }
}
