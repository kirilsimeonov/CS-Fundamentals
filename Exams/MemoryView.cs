using System;
using System.Collections.Generic;
using System.Linq;

namespace _25April_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string result = string.Empty;
            string input = Console.ReadLine();

            while (input!="Visual Studio crash")
            {
                result += input + " ";
                input = Console.ReadLine();
            }
            string[] selected = result.Split(' ');

            List<string> words = new List<string>();

            for (int i = 0; i < selected.Length-5; i++)
            {
                if (selected[i]=="32656" && selected[i+1] == "19759" && selected[i+2] == "32763" && selected[i+3] == "0" && selected[i+5] == "0") 
                {
                     int wordLength = int.Parse(selected[i + 4]);
                    string word = string.Empty;

                    for (int d = i + 6; d < i + 6 + wordLength; d++)
                    {
                        word += (char)(int.Parse(selected[d]));

                    }
                    words.Add(word);

                }



            }
            Console.WriteLine(string.Join(Environment.NewLine,words));
        }
    }
}
