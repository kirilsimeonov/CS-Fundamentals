using System;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            int correct = 0;
            bool isCorrect = false;

            for (int i = 0; i < array.Length; i++)
            {
                // if (i == 0) leftSum = 0;
                // if (i == array.Length - 1) rightSum = 0; 
                for (int d = i+1; d < array.Length; d++)
                {
                    rightSum += array[d];
                    
                }
                
                
                for (int j = i-1; j >= 0; j--)
                {
                    leftSum += array[j];

                }
                
                
                if (leftSum==rightSum)
                {
                    correct = i;
                    isCorrect = true;
                    break;
                }
                rightSum = 0;
                leftSum = 0;

            }
            if (isCorrect)
            {
                Console.WriteLine(correct);
            }
            else
            {
                Console.WriteLine("no");
            }
            

        }
    }
}
