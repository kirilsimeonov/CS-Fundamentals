using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string regexValid = @"[^d-z{}|#]";
            string input = Console.ReadLine();
            string[] twoLetters = Console.ReadLine().Split(" ");
            string decyphered = string.Empty;
            StringBuilder sb = new StringBuilder();

            if (Regex.IsMatch(input,regexValid))
            {
                Console.WriteLine("This is not the book you are looking for.");




            }
            else
            {
                char[] chararr = input.ToCharArray();
                foreach (var item in chararr)
                {
                    decyphered += (char)(item - 3);
                }
                //Console.WriteLine(decyphered);
                sb.Append(decyphered);

                string firstWord = twoLetters[0];
                string secondWord = twoLetters[1];


                sb.Replace(firstWord, secondWord);
                Console.WriteLine(sb);

            }
        }
    }
}


