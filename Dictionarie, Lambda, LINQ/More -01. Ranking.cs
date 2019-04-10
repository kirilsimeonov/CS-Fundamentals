using System;
using System.Collections.Generic;
using System.Linq;


namespace More_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();
            while (command!="end of contests")
            {
                List<string> input = command.Split(':').ToList();
                string contest = input[0];
                string password = input[1];

                contests[contest] = password;
                
                command = Console.ReadLine();
            }
            //foreach (var item in contests)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value}");
            //}
            command = Console.ReadLine();
            while (command!="end of submissions")
            {
                List<string> input = command.Split("=>").ToList();
                string contest = input[0];
                string password = input[1];
                string username = input[2];
                int score = int.Parse(input[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest]==password)
                    {
                        if (!submissions.ContainsKey(username))
                        {
                            submissions[username] = new Dictionary<string, int>();
                            submissions[username].Add(contest, score);
                        }
                        else if (!submissions[username].ContainsKey(contest))
                        {
                            submissions[username][contest] = score;
                        }

                        if (submissions[username][contest]<score)
                        {
                            submissions[username][contest] = score;
                        }
                        

                    }
                }
                //foreach (var item in submissions)
                //{
                //    Console.WriteLine($"{item.Key}");
                //    foreach (var student in item.Value)
                //    {
                //        Console.WriteLine($"{student.Value} -> {student.Key}");
                //    }
                //}

                command = Console.ReadLine();
            }
            //USERNAME -> EXAM -> SCORE
            //foreach (var item in submissions)
            //{
            //    Console.WriteLine($"{item.Key}");

            //    foreach (var exam in item.Value)
            //    {
            //        Console.WriteLine($"{exam}");
            //    }
            //}
            int bestSum = 0;
            string bestStudent = string.Empty;
            foreach (var item in submissions)
            {
                var sum = item.Value.Values.Sum();
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestStudent = item.Key;
                }
                
            }
            Console.WriteLine($"Best candidate is {bestStudent} with total {bestSum} points.");

            Console.WriteLine("Ranking: ");
            var orderedNames = submissions.OrderBy(x=>x.Key);
            foreach (var item in orderedNames)
            {
                Console.WriteLine($"{item.Key}");
                var orderedScores = item.Value.OrderByDescending(x=>x.Value);
                foreach (var student in orderedScores)
                {
                    Console.WriteLine($"#  {student.Key} -> {student.Value}");
                }
            }
        }
    }
}
