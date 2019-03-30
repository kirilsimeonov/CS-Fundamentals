using System;
using System.Linq;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] output = new int[array.Length];
           
            int maxIndex = 0;
            string sequence = string.Empty;
            
            string maxSequence = string.Empty;

            // 2 1 1 2 3 3 2 2 2 1   seq 1

            for (int i = 1; i < array.Length; i++)
            {
                
                if (array[i]==array[i-1])
                {
                    sequence += array[i]+" ";
                    if (sequence.Length > maxSequence.Length )
                    {
                        maxSequence = sequence;
                        maxIndex = array[i];
                    }
                }
                else
                {
                    sequence = string.Empty;
                }
            }
            Console.WriteLine(maxSequence + maxIndex);

        }
    }
}
