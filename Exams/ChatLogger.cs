using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<string> ChatHistory = new List<string>();
            while (command!="end")
            {
                List<string> input = command.Split(' ').ToList();
                string task = input[0];

                if (task =="Chat")
                {
                    ChatHistory.Add(input[1]);
                }
                if (task=="Delete")
                {
                    if (ChatHistory.IndexOf(input[1])>=0)
                    {
                        int index = ChatHistory.IndexOf(input[1]);
                        ChatHistory.RemoveAt(index);
                    }
                    
                }
                if (task=="Edit")
                {
                    if (ChatHistory.IndexOf(input[1]) >= 0)
                    {
                        int index = ChatHistory.IndexOf(input[1]);
                        ChatHistory.RemoveAt(index);
                        ChatHistory.Insert(index,input[2]);
                    }
                }
                if (task=="Pin")
                {
                    if (ChatHistory.IndexOf(input[1]) >= 0)
                    {
                        int index = ChatHistory.IndexOf(input[1]);
                        ChatHistory.RemoveAt(index);
                        ChatHistory.Add(input[1]);
                    }
                }
                if (task=="Spam")
                {
                    for (int i = 1; i < input.Count; i++)
                    {
                        ChatHistory.Add(input[i]);
                    }
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(Environment.NewLine,ChatHistory));
        }
    }
}
