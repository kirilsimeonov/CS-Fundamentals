using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|").ToList();
            string first = input[0];
            string second = input[1];
            string third = input[2];

            Regex part1 = new Regex(@"([#|$|%|&|*])([A-Z]+)(\1)");
            Regex part2 = new Regex(@"[0-9]{2}:[0-2]{1}[0-9]{1}");
            Regex part3 = new Regex(@"\b([A-Z])(\S)+");
           
            //@"(?<=\s|^)[A-Z][^\s]+(?=\s|$)"

            string firstMatch = string.Empty;
            List<char> charlist = new List<char>();

            firstMatch += part1.Match(first);

            for (int i = 1; i < firstMatch.Length-1; i++)
            {
                charlist.Add(firstMatch[i]);
            }

            //foreach (var item in charlist)
            //{
            //    Console.WriteLine(item);
            //}

            Dictionary<char, int> charint = new Dictionary<char, int>();

            MatchCollection matches = part2.Matches(second);
            foreach (Match item in matches)
            {
                //Console.WriteLine(item);
                string current = string.Empty;
                current += item;
                List<string> curr = current.Split(":").ToList();

                char letter = (char)(int.Parse(curr[0]));
                int length = int.Parse(curr[1]);

                if (charlist.Contains(letter) &&length+1>1 && length+1<=20 )
                {
                    charint[letter] = length;
                }

            }

            //Console.WriteLine(string.Join(" ",charint));

            MatchCollection finalMatches = part3.Matches(third);
            List<string> finalList = new List<string>();

            foreach (Match item in finalMatches)
            {
                //Console.WriteLine(item);
                string current = string.Empty;
                current += item;
                foreach (var let in charint)
                {
                    if (let.Key==current[0] && let.Value==current.Length-1)
                    {
                        finalList.Add(current);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,finalList));

            //string[] thirdPart = third.Split();

            //foreach (var kvp in charint)
            //{
            //    foreach (var word in thirdPart)
            //    {
            //        if (word[0] == kvp.Key && word.Length == kvp.Value+1)
            //        {
            //            Console.WriteLine(word);
            //            break;
            //        }
            //    }
            //}

        }
    }

}
