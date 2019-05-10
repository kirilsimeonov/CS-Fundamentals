using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {


            string finalResult = string.Empty;
            string input = Console.ReadLine().TrimStart('0');
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("0");
                return;
            }
            // 9959   //9999
            // 9         9
            //89631       89991
            int remainder = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {

                int digit = int.Parse(input[i].ToString());
               // Console.WriteLine($"Digit: {digit}");
                int result = digit * n;
                //Console.WriteLine($"Result: {result}");
                //26*3
                if (remainder > 0)
                {
                    result += remainder;
                    remainder = 0;
                }
                if (result > 9)
                {
                    finalResult += result % 10;  //19998
                    remainder = result / 10;
                }
                else
                {
                    finalResult += result;
                }
                if (i==0 && remainder>0)
                {
                    finalResult += remainder;
                }

            }
            

            char[] reverseArray = finalResult.ToCharArray();
            Array.Reverse(reverseArray);
            Console.WriteLine(string.Join("",reverseArray));
             

        }
    }
}
