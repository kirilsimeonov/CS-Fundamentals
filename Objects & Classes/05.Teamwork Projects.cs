using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());


            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {

                List<string> inputTeams = Console.ReadLine().Split('-',StringSplitOptions.RemoveEmptyEntries).ToList();
                string Author = inputTeams[0];
                string Names = inputTeams[1];

                if (teams.Exists(x => x.Name == Names))
                {
                    Console.WriteLine($"Team {Names} was already created!");
                }
                else if (teams.Exists(x => x.Creator == Author))
                {
                    Console.WriteLine($"{Author} cannot create another team!");
                }
                else
                {
                    teams.Add(new Team
                    {
                        Creator = Author,
                        Name = Names
                    }
                    );

                    Console.WriteLine($"Team {teams[teams.Count-1].Name} has been created by {teams[teams.Count-1].Creator}!");
                }
            }

            //end of For Cycle

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                List<string> inputCommand = command.Split("->",StringSplitOptions.RemoveEmptyEntries).ToList();
                string Name = inputCommand[0];
                string TeamName = inputCommand[1];

                if (!teams.Exists(x => x.Name == TeamName))
                {
                    Console.WriteLine($"Team {TeamName} does not exist!");
                }
                else if (teams.Exists(x=>x.Members.Contains(Name) || x.Creator==Name))
                {
                    Console.WriteLine($"Member {Name} cannot join team {TeamName}!");
                }

                else if (teams.Exists(x => x.Name == TeamName))
                {
                    var index =teams.FindIndex(x=>x.Name==TeamName);
                    
                    teams[index].Members.Add(Name);

                }



                command = Console.ReadLine();
            }

            List<Team> sortedTeams = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).Where(x=>x.Members.Count>0).ToList();
            for (int i = 0; i < sortedTeams.Count; i++)
            {
                Console.WriteLine(sortedTeams[i].Name);
                Console.WriteLine($"- {sortedTeams[i].Creator}");
                sortedTeams[i].Members.Sort();
                
                
                for (int d = 0; d < sortedTeams[i].Members.Count; d++)
                {
                    Console.WriteLine($"-- {sortedTeams[i].Members[d]}");
                }
            }
            List<Team> teamsToDisband = teams.Where(x => x.Members.Count == 0).OrderBy(x=>x.Name).ToList();

            
                Console.WriteLine("Teams to disband:");
                for (int i = 0; i < teamsToDisband.Count; i++)
                {
                    Console.WriteLine(teamsToDisband[i].Name);
                }
            
            




        }
        public static void Print(List<Team> teams)

        {
            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(teams[i]);
            }
        }
    }

    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Team()
        {
            // List<string> command = Console.ReadLine().Split('-').ToList();
            //this.Creator = command[0];
            //this.Name = command[1];
            this.Members = new List<string>();
        }
        public override string ToString()
        {
            
            string print = $"{Creator} {Name} {string.Join(" ",Members)}";
            return print;
        }
        


    }

}
