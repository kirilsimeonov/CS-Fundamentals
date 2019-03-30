using System;
using System.Linq;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] maxArray = new int[n];

            string command = string.Empty;
            int maxSequence = 0;
            int sequence = 0;
            int counter = 0;
            int maxDnaSample =1;
            int maxSum = 0;
            int sum = 0;
            int lastInitial = 0;
            

            while (true)
            {
                command = Console.ReadLine();
                if (command == "Clone them!")
                {
                    break;
                }

                int[] commandArray = command.Split("!",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                //Array.Resize(ref commandArray, newSize: n);

                sum = commandArray.Sum();
                counter++;

                for (int i = 1; i < commandArray.Length; i++)
                {

                    if (commandArray[i] == 1 && commandArray[i] == commandArray[i - 1])
                    {

                        sequence++;

                        if (sequence > maxSequence)
                        {

                            maxDnaSample = counter;
                            maxArray = commandArray;
                            maxSequence = sequence;
                            lastInitial = i - sequence;
                            maxSum = sum;


                        }
                        else if (sequence == maxSequence && i - sequence < lastInitial)
                        {

                            maxDnaSample = counter;
                            maxArray = commandArray;
                            maxSequence = sequence;
                            lastInitial = i - sequence;
                            maxSum = sum;
                        }
                        else if (sequence == maxSequence && i - sequence == lastInitial && sum > maxSum)
                        {
                            maxDnaSample = counter;
                            maxArray = commandArray;
                            maxSequence = sequence;
                            lastInitial = i - sequence;
                            maxSum = sum;
                        }
                       // else if (commandArray.Contains(1) == false && maxSum == 0)
                       // {
                        //    maxDnaSample = counter;
                        //    maxArray = commandArray;
                       // }

                    }
                    
                    else
                    {
                        sequence = 0;
                    }
                   
                }
                if (sequence==0 && sum>maxSum)
                {
                    maxArray = commandArray;
                    maxSum = sum;
                    maxDnaSample = counter;
                }
                sequence = 0;

            }

            Console.WriteLine($"Best DNA sample {maxDnaSample} with sum: {maxSum}.");
            Console.WriteLine(String.Join(" ",maxArray));




        }
    }
}
