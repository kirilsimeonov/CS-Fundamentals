using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());

            string[] Phrases = { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] Events = { "Now i feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] Authors = { "Diana", "Petya", "Stella",
                "Elena", "Katya", "Iva","Annie","Eva"  };
            string[] Cities = { "Burgas","Sofia","Plovdiv","Varna","Ruse" };

            

            for (int i = 0; i < n; i++)
            {
                var r1 = rand.Next(0, Phrases.Length);
                var r2 = rand.Next(0, Events.Length);
                var r3 = rand.Next(0, Authors.Length);
                var r4 = rand.Next(0, Cities.Length);

                Console.WriteLine($"{Phrases[r1]} {Events[r2]} {Authors[r3]} - {Cities[r4]}");
            }
            
        }
    }
}

