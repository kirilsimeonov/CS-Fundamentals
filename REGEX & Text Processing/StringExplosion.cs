using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();
            List<char> final = new List<char>();
            //final.AddRange(input);
            int explosionCount = 0;

            //>1>>>2>>>2abvd
            //>>>>>>>>>bvd

            for (int i = 0; i < input.Count; i++)
            {

                if (input[i] == '>')
                {
                    final.Add(input[i]);
                    if (i!=input.Count-1 && Char.IsDigit(input[i + 1]))
                    {
                        explosionCount += int.Parse(input[i + 1].ToString());
                        
                    }

                }
                else if (/*Char.IsLetterOrDigit(input[i]) &&*/ explosionCount==0)
                {
                    final.Add(input[i]);

                }
                
                else if (explosionCount>0)
                {
                    explosionCount--;
                }

                //Console.WriteLine($"Explosion count: {explosionCount}");


            }
            
            
            Console.WriteLine(string.Join("",final));
        }
    }
}
