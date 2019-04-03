using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article1 = new Article();
            int n = int.Parse(Console.ReadLine());
            
             

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(": ").ToList();
                string command = input[0];
                string newContent = input[1];

                if (command == "Edit")
                {
                    article1.Content = article1.Edit(article1.Content, newContent);
                }
                if (command == "ChangeAuthor")
                {
                    article1.Author = article1.ChangeAuthor(article1.Author, newContent);
                }
                if (command == "Rename")
                {
                    article1.Title = article1.Rename(article1.Title, newContent);
                }

            }
            
            Console.WriteLine(article1);

        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article()
        {
            List<string> command = Console.ReadLine().Split(", ").ToList();
            this.Title = command[0];
            this.Content = command[1];
            this.Author = command[2];
        }
        public override string ToString()
        {
            string one = $"{Title} - {Content}: {Author} ";
            return one;
        }

        public  string Edit(string Content, string better)
        {
            Content = better;
            return better;
            
        }
        public string ChangeAuthor(string Content, string better)
        {
            Content = better;
            return better;
        }

        internal  string Rename(string title, string newContent)
        {
            title = newContent;
            return newContent;
        }
    }
}

