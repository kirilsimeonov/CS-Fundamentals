using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace MeTubeStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> views = new Dictionary<string, int>();
            Dictionary<string, int> likes = new Dictionary<string, int>();

            while (input != "stats time")
            {
                if (input.Contains('-'))
                {
                    List<string> command = input.Split("-").ToList();
                    string name = command[0];
                    int view = int.Parse(command[1]);
                    if (!views.ContainsKey(name))
                    {
                        views[name] = 0;
                    }
                    views[name] += view;
                    //foreach (var item in views)
                    //{
                    //    Console.WriteLine($"{item.Key} - {item.Value}");
                    //}

                }
                else if (input.Contains(':'))
                {
                    List<string> command = input.Split(":").ToList();
                    string task = command[0];
                    string name = command[1];


                    if (task == "like")
                    {
                        if (views.ContainsKey(name))
                        {
                            if (!likes.ContainsKey(name))
                            {
                                likes[name] = 0;
                            }
                            likes[name]++;
                        }
                    }
                    else if (task == "dislike")
                    {
                        if (views.ContainsKey(name))
                        {
                            if (!likes.ContainsKey(name))
                            {
                                likes[name]=0;
                            }
                            likes[name]--;
                        }
                    }
                    //foreach (var item in likes)
                    //{
                    //    Console.WriteLine($"{item.Key} -> {item.Value}");
                    //}
                }


                input = Console.ReadLine();
            }
            foreach (var item in views)
            {
                if (!likes.ContainsKey(item.Key))
                {
                    likes[item.Key] = 0;
                }
            }
            string finalTask = Console.ReadLine();
            if (finalTask == "by views")
            {
                var orderedViews = views.OrderByDescending(x => x.Value);
                foreach (var item in orderedViews)
                {
                    Console.WriteLine($"{item.Key} - {item.Value} views - {likes[item.Key]} likes");
                }
            }
            if (finalTask == "by likes")
            {
                var orderedLikes = likes.OrderByDescending(x => x.Value);
                foreach (var item in orderedLikes)
                {
                    Console.WriteLine($"{item.Key} - {views[item.Key]} views - {item.Value} likes");
                }
            }
        }
    }
}

