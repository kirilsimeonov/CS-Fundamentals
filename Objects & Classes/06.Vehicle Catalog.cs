using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            List<Car> Cars = new List<Car>();
            double carHorsePowerSum = 0;
            int carCount = 0;
            int truckCount = 0;
            double truckHorsePowerSum = 0;

            while (command!="End")
            {
                List<string> vehicles = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                string type = vehicles[0].ToLower();
                if (type!="truck" && type!="car")
                {
                    continue;
                }
                string brand = vehicles[1];
                string color = vehicles[2];
                double horsePower = double.Parse(vehicles[3]);
                if (type == "truck")
                {
                    type = "Truck";
                    truckHorsePowerSum += horsePower;
                    truckCount++;
                    
                }
                if (type == "car")
                {
                    type = "Car";
                    carHorsePowerSum += horsePower;
                    carCount++;
                }
                

                Cars.Add(new Car {
                    Type = type, Brand=brand,Color=color,HorsePower=horsePower
                      });


                command = Console.ReadLine();
            }///////////////END OF WHILE
            string command2 = Console.ReadLine();
           
            while (command2!="Close the Catalogue")
            {
                var index = Cars.FindIndex(x=>x.Brand==command2);
                Console.WriteLine(Cars[index]);

                command2 = Console.ReadLine();
            }
            double averageCars = 0;
            if (carCount>0)
            {
                averageCars = carHorsePowerSum / carCount;
            }
            double averageTrucks = 0;
            if (truckCount>0)
            {
                averageTrucks = truckHorsePowerSum / truckCount;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:f2}.");


           // Print(Cars);
        }
        private static void Print(List<Car> Cars)
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine(Cars[i]);
            }
        }
    }
    class Car
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public override string ToString()
        {
            string print = $"Type: {Type}{Environment.NewLine}Model: {Brand}{Environment.NewLine}Color: {Color}{Environment.NewLine}Horsepower: {HorsePower}";
            return print;
        }
    }
}

