using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DemoExam24March
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(?<=[\s]):(?<emoji>[a-z]{4,}):[\s,.!?]";
            string input = Console.ReadLine();
            List<int> nums = Console.ReadLine().Split(":").Select(int.Parse).ToList();
            string decryptedNums = string.Empty;
            int emojiPower = 0;
            bool matchEmoji = false;

            foreach (var item in nums)
            {
                decryptedNums += (char)item;
            }

            //Console.WriteLine(string.Join("",decryptedNums));
            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match item in matches)
            {
                char[] text = item.Groups["emoji"].Value.ToCharArray();
                foreach (var charr in text)
                {
                    emojiPower += (int)charr;
                }
                string tex = item.Groups["emoji"].Value;
                if (tex==decryptedNums)
                {
                    matchEmoji = true;
                }
            }

            if (matchEmoji)
            {
                emojiPower *= 2;
            }
            List<string> final = new List<string>();
               foreach (Match item in matches)
                {
                    string text = ":"+item.Groups["emoji"].Value+":";
                    final.Add(text);
                }

            if (matches.Count>0)
            {
                Console.WriteLine($"Emojis found: {string.Join(", ", final)}");
            }

            Console.WriteLine($"Total Emoji Power: {emojiPower}");
            
        }
    }
}
