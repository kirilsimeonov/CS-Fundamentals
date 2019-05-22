using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(?<letterbefore>[A-Za-z]){1}(?<number>\d+)(?<letterafter>[A-Za-z])";
            string input = Console.ReadLine();
            double Sum = 0;

            MatchCollection matches = Regex.Matches(input,regex);

            foreach (Match item in matches)
            {
                char firstLetter = char.Parse(item.Groups["letterbefore"].Value);

                double number = double.Parse(item.Groups["number"].Value);

                char secondLetter = char.Parse(item.Groups["letterafter"].Value);

                int firstLetterPosition = 0;
                int secondLetterPosition = 0;

                if (char.IsUpper(firstLetter))
                {
                    firstLetterPosition = firstLetter - 64;
                    //Console.WriteLine(firstLetterPosition);
                }
                else if (char.IsLower(firstLetter))
                {
                    firstLetterPosition = firstLetter - 96;
                    //Console.WriteLine(firstLetterPosition);
                }

                if (char.IsLower(secondLetter))
                {
                    secondLetterPosition = secondLetter - 96;
                   // Console.WriteLine(secondLetterPosition);
                }
                else if (char.IsUpper(secondLetter))
                {
                    secondLetterPosition = secondLetter - 64;
                    //Console.WriteLine(secondLetterPosition);
                }


                if (char.IsUpper(firstLetter))
                {
                    Sum += number / firstLetterPosition; //12/2=1
                   // Console.WriteLine(Sum);
                }
                else if (char.IsLower(firstLetter))
                {
                   Sum += number * firstLetterPosition;
                    //Console.WriteLine(Sum);
                }

                if (char.IsUpper(secondLetter))
                {
                    Sum -= secondLetterPosition;
                    //Console.WriteLine(Sum);
                }
                else if (char.IsLower(secondLetter))
                {
                    Sum += secondLetterPosition;
                    //Console.WriteLine(Sum);
                }
            }
            Console.WriteLine($"{Sum:f2}");
        }
    }
}
