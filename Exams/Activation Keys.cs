using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace DemoFinalExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("&").ToList();

            string regex = @"^[\d\w]{16}$|^[\d\w]{25}$";
            StringBuilder sb = new StringBuilder();
            List<string> final = new List<string>();


            foreach (var item in input)
            {
                if (Regex.IsMatch(item, regex))
                {
                    char[] process = item.ToCharArray();
                   // Console.WriteLine(string.Join("", process));

                    if (process.Length==25)
                    {
                        string append = string.Empty;
                        for (int i = 0; i < process.Length; i++)
                        {

                            if (i>0 && i%5==0)
                            {
                                append+="-";
                            }
                            if (!char.IsDigit(process[i]))
                            {
                                append+=process[i].ToString().ToUpper();
                            }

                            if (Char.IsDigit(process[i]))
                            {
                                int b = int.Parse(process[i].ToString());
                                int a = 9 - b;
                                append+=a;
                            }

                           
                        }
                        //Console.WriteLine(append);
                        final.Add(append);


                    }
                    else if (process.Length==16)
                        {
                        string append = string.Empty;
                        for (int i = 0; i < process.Length; i++)
                        {

                           
                            if (i > 0 && i % 4 == 0)
                            {
                                append += "-";
                            }
                            if (!char.IsDigit(process[i]))
                            {
                                append += process[i].ToString().ToUpper();
                            }

                            if (Char.IsDigit(process[i]))
                            {
                                int b = int.Parse(process[i].ToString());
                                int a = 9 - b;
                                append += a;
                            }


                        }
                        final.Add(append);

                    }

                    
                }
            }
            Console.WriteLine(string.Join(", ",final));
        } 
    }
}
