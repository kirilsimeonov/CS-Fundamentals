using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> bombSequence = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int specialNumber = bombSequence[0];
            int power = bombSequence[1];

            while (sequence.Contains(specialNumber))
            {
                int bombIndex = sequence.IndexOf(specialNumber);

                if ((bombIndex + power >= sequence.Count - 1) && (bombIndex - power < 0))
                {
                    sequence.Clear();

                }
                else if (bombIndex + power >= sequence.Count - 1) //if sequence is short on the right
                {
                    int tempIndex = bombIndex - power;
                    sequence.RemoveRange(tempIndex, sequence.Count - tempIndex);
                }

                else if (bombIndex - power < 0) // if sequence is short on the left
                {
                    sequence.RemoveRange(0, power + 1 + (bombIndex - 0));
                }
                else if (bombIndex + power <= sequence.Count - 1 && bombIndex - power >= 0) // if sequence is ok
                {
                    sequence.RemoveRange(bombIndex - power, power * 2 + 1);

                }


               // Console.WriteLine(string.Join(" ", sequence));
            }
            int sum = 0;
            for (int i = 0; i < sequence.Count; i++)
            {
                sum += sequence[i];
            }
            Console.WriteLine(sum);

        }
    }
}

