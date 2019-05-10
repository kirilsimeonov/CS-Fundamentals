using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine().Split(", ").ToList();

            List<string> validNames = usernames.Where(x => x.Length >= 3 && x.Length <= 16).ToList();

            

            List<string> finalNames = new List<string>();

            for (int i = 0; i < validNames.Count; i++)
            {
                bool isLegit = true;
                char[] current = validNames[i].ToCharArray();
                for (int d = 0; d < current.Length; d++)
                {
                    if (!(Char.IsLetterOrDigit(current[d]) || current[d]=='-' || current[d]=='_'))
                    {
                        isLegit = false;
                        break;
                    }
                    
                }
                if (isLegit == true)
                {
                    finalNames.Add(validNames[i]);
                }

            }

            foreach (var item in finalNames)
            {
                Console.WriteLine(item);
            }


        }
    }
}
