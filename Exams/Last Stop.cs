using System;
using System.Linq;
using System.Collections.Generic;
namespace Exam_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> paintings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command!="END")
            {
                string[] inputCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string task = inputCommand[0];


                    
                

                if (task=="Change")
                {
                    if (paintings.Contains(inputCommand[1]))
                    {
                        //Console.WriteLine("Yes");
                        int index = paintings.IndexOf(inputCommand[1]);
                        //Console.WriteLine(index);
                        
                        paintings[index] = inputCommand[2];
                        //Console.WriteLine(paintings[index]);
                    }

                }
                if (task=="Hide")
                {
                    if (paintings.Contains(inputCommand[1]))
                    {
                        int index = paintings.IndexOf(inputCommand[1]);
                        paintings.RemoveAt(index);
                    }

                }
                if (task=="Switch" )
                {
                    if (paintings.Contains(inputCommand[1]) && paintings.Contains(inputCommand[2]))
                    {
                        int index1 = paintings.IndexOf(inputCommand[1]);
                        int index2 = paintings.IndexOf(inputCommand[2]);
                        string temp = paintings[index1];
                        paintings[index1] = paintings[index2];
                        paintings[index2] = temp;
                    }


                }
                if (task=="Insert")//insert 5 114
                {

                    int insertCommand = int.Parse(inputCommand[1]);
                    if (insertCommand + 1 <= paintings.Count)
                    {
                        paintings.Insert(insertCommand+1, inputCommand[2]);
                    }

                }
                if (task=="Reverse")
                {
                    paintings.Reverse();
                }

                //Console.WriteLine(string.Join(" ", paintings));

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",paintings));
        }
    }
}
