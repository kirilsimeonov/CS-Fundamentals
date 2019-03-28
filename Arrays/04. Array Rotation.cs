using System;
using System.Linq;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = new int[arr.Length];

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr[i];
            }

            int rotations = int.Parse(Console.ReadLine());


            //for (int d = 0; d < rotations; d++)
            //{


            //2 4 15 31
            for (int d = 0; d < rotations; d++)
            {
                var oldElement = arr[0];//2
                for (int i = 0; i < arr.Length; i++)
                {


                    if (i == arr.Length - 1)
                    {
                        arr[i] = oldElement;
                    }
                    else
                    {
                        arr[i] = arr[i + 1];//4
                    }
                }
            }
            

               // for (int i = 0; i < arr.Length; i++)
               // {
               //
               //     if (i == arr.Length - 1)
               //     {
               //         arr[i] = arr2[0];
               //     }
               //     else
               //     {
               //         arr[i] = arr2[i + 1];
               //     }
               //
               // }
            
            
            Console.WriteLine(String.Join(" ", arr));
           

        }
    }
}
