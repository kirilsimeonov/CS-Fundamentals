using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string peak = @"^^[A-Za-z0-9!@#$?]+(?=\=)";
            string lengthRegex = @"(?<=\=)[\d]+(?=<<)";
            string lastRegex = @"(?<=<<).+";
            string peakdecypher = string.Empty;

            while (input!="Last note")
            {
                if (Regex.IsMatch(input, peak) && Regex.IsMatch(input, lengthRegex) && Regex.IsMatch(input, lastRegex))
                {
                    char[] chararr = Regex.Match(input, peak).ToString().ToCharArray();
                    //Console.WriteLine(string.Join("", chararr));
                    for (int i = 0; i < chararr.Length; i++)
                    {
                        if (Char.IsLetterOrDigit(chararr[i]))
                        {
                            peakdecypher += chararr[i];
                        }

                    }
                    int length = int.Parse(Regex.Match(input, lengthRegex).ToString());
                    string coordinates = Regex.Match(input, lastRegex).ToString();


                    if (coordinates.Length==length)
                    {
                        Console.WriteLine($"Coordinates found! {peakdecypher} -> {coordinates}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }

                peakdecypher = string.Empty;

                input = Console.ReadLine();
            }
        }
    }
}

