using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
            
                articles.Add(new Article());


            }
            string criteria = Console.ReadLine();
            List<Article> sortedArticles = new List<Article>();

            if (criteria=="title")
            {
                sortedArticles = articles.OrderBy(x => x.Title).ToList();
            }
            if (criteria == "author")
            {
                sortedArticles = articles.OrderBy(x => x.Author).ToList();
            }
            if (criteria == "content")
            {
                sortedArticles = articles.OrderBy(x => x.Content).ToList();
            }

            Print(sortedArticles);

        }

        private static void Print(List<Article> articles)
        {
            for (int i = 0; i < articles.Count; i++)
            {
                Console.WriteLine(articles[i]);
            }
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

      
    }
}

