using System;

namespace _10_Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            byte exhaust = byte.Parse(Console.ReadLine());
            int original = power;
            int counter = 0;

            while (power>=distance)
            {
                power -= distance;
                if (power==0.5*original)
                {
                    if (exhaust>0)
                    {
                        power /= exhaust;
                    }
                    
                }
                counter++;
            }
            Console.WriteLine(power);
            Console.WriteLine(counter);

        }
    }
}
