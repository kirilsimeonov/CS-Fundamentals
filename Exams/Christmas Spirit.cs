using System;

namespace MidExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantity = int.Parse(Console.ReadLine());
            double days = int.Parse(Console.ReadLine());
          
            double cost = 0;
            double spirit = 0;
           
            double ornament = 2;
            double treeSkirt = 5;
            double garlands = 3;
            double lights = 15;

            for (int i = 1; i <= days; i++)
            {
                
                if (i == days && i % 10 == 0)
                {
                    spirit -= 30;
                }
                if (i % 15 == 0)
                {
                    spirit += 30;
                }
                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i % 10 == 0)
                {
                    spirit -= 20;
                    
                    
                        cost = cost + treeSkirt + garlands + lights;
                    
                }
                if (i % 5 == 0)
                {
                    cost = cost+ (lights * quantity);   //12+15=27
                    spirit += 17;
                }
                if (i % 3 == 0)
                {
                    cost = cost + (treeSkirt + garlands)*quantity; //2+8=10 //27+8=35
                    spirit += 13;
                }
                if (i % 2 == 0)
                {
                    //Console.WriteLine(cost);
                    //Console.WriteLine(ornament);
                    //Console.WriteLine(quantity);
                    //Console.WriteLine(cost+(ornament*quantity));
                    cost = cost+ (ornament * quantity); //2  //10+2=12 //35+2=37
                    spirit += 5;
                }

                //Console.WriteLine("Days "+i);
                //Console.WriteLine("Cost "+cost);
                

            }
            Console.WriteLine($"Total cost: {cost}");
            Console.WriteLine($"Total spirit: {spirit}");

        }
    }
}
