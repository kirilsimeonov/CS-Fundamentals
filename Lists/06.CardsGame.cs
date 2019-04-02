using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


            while (player1.Count > 0 && player2.Count > 0)
            {
                if (player1[0] > player2[0])
                {
                    player1.Add(player1[0]);
                    player1.Add(player2[0]);
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);

                }
                else if (player2[0] > player1[0])
                {

                    player2.Add(player2[0]);
                    player2.Add(player1[0]);
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
                else if (player1[0] == player2[0])
                {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);

                }

            }
            int sum = 0;
            if (player1.Count > 0)
            {
                for (int i = 0; i < player1.Count; i++)
                {
                    sum += player1[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (player2.Count > 0)
            {
                for (int i = 0; i < player2.Count; i++)
                {
                    sum += player2[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }


        }
    }
}

