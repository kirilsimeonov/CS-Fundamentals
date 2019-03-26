using System;

namespace _07_Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            string productCommand = string.Empty;
            double sumCoins = 0;
            while (true)
            {
                command = Console.ReadLine();
                if (command=="Start")
                {
                    break;
                }
                double coins = double.Parse(command);
                
                if (coins!=0.1 && coins!=0.2 && coins!=0.5 && coins!=1 && coins!=2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                else
                {
                    sumCoins += coins;
                }
                
            }

            while (true)
            {
                productCommand = Console.ReadLine();
                
                if (productCommand == "End")
                {
                    Console.WriteLine($"Change: {sumCoins:f2}");
                    return;
                }
                else if (productCommand=="Nuts")
                {
                    
                    sumCoins -= 2;
                    if (sumCoins < 0)
                    {
                        Console.WriteLine("Sorry,not enough money");
                        sumCoins += 2;
                    }
                    else
                    {
                        Console.WriteLine($"Purchased nuts");
                    }
                }
                else if (productCommand=="Water")
                {
                   
                    sumCoins -= 0.7;
                    if (sumCoins < 0)
                    {
                        Console.WriteLine("Sorry,not enough money");
                        sumCoins += 0.7;
                    }
                    else
                    {
                        Console.WriteLine($"Purchased water");
                    }
                }
                else if (productCommand == "Crisps")
                {
                    
                    sumCoins -= 1.5;
                    if (sumCoins < 0)
                    {
                        Console.WriteLine("Sorry,not enough money");
                        sumCoins += 1.5;
                    }
                    else
                    {
                        Console.WriteLine($"Purchased crisps");
                    }
                }
                else if (productCommand == "Soda")
                {
                   
                    sumCoins -= 0.8;
                    if (sumCoins < 0)
                    {
                        Console.WriteLine("Sorry,not enough money");
                        sumCoins += 0.8;
                    }
                    else
                    {
                        Console.WriteLine($"Purchased soda");
                    }
                }
                else if (productCommand == "Coke")
                {
                    
                    sumCoins -= 1;
                    if (sumCoins<0)
                    {
                        Console.WriteLine("Sorry,not enough money");
                        sumCoins += 1;
                    }
                    else
                    {
                        Console.WriteLine($"Purchased coke");
                    }
                }
                
                else
                {
                    Console.WriteLine("Invalid product");
                }


                
            }


            
        }
    }
}
