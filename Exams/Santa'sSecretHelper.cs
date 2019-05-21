using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _10Jan_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            List<string> names = new List<string>();

            while (input!="end")
            {
                string current = string.Empty;
                for (int i = 0; i < input.Length; i++)
                {
                    current += (char)(input[i] - key);
                }
                string regex = @"@(?<name>[A-Za-z]+)[^@\-!:>]*![G]!";

                if (Regex.IsMatch(current,regex))
                {
                    MatchCollection matches = Regex.Matches(current, regex);
                    foreach (Match item in matches)
                    {
                        string text = item.Groups["name"].Value;
                        names.Add(text);
                    }
                }

                //if (Regex.IsMatch(current,regex))
                //{
                //    string match = Regex.Match(current, regex).ToString();

                //}

                input = Console.ReadLine();
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(names.Count);
        }
    }
}
