using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "course start")
            {
                List<string> input = command.Split(':').ToList();
                string task = input[0];
                string lesson = input[1];
                string Exercise = $"{lesson}-Exercise";

                if (task == "Add" && !courses.Contains(lesson))
                {
                    courses.Add(lesson);
                }
                if (task == "Insert" && !courses.Contains(lesson))
                {
                    int index = int.Parse(input[2]);
                    if (index >= 0 && index < courses.Count)
                    {
                        courses.Insert(index, lesson);
                    }
                }
                if (task == "Remove" && courses.Contains(lesson))
                {
                    courses.Remove(lesson);
                    if (courses.Contains(Exercise))
                    {
                        courses.Remove(Exercise);
                    }
                }
                if (task == "Swap" && courses.Contains(lesson) && courses.Contains(input[2]))
                {
                    string exercise2 = $"{input[2]}-Exercise";

                    if (courses.Contains(Exercise) && courses.Contains(exercise2))
                    {
                        string temp = lesson;
                        int index1 = courses.IndexOf(lesson);
                        int index2 = courses.IndexOf(input[2]);

                        courses[index1] = courses[index2];
                        courses[index2] = temp;

                        string exTemp = Exercise;
                        courses[index1 + 1] = courses[index2 + 1];
                        courses[index2 + 1] = exTemp;


                    }
                    else if (courses.Contains(Exercise))
                    {
                        string temp = lesson;
                        int index1 = courses.IndexOf(lesson);
                        int index2 = courses.IndexOf(input[2]);  //1 2 ex 3 4 ex
                        courses[index1] = courses[index2];

                        courses[index2] = temp;
                        courses.Insert(index2 + 1, Exercise);
                        courses.RemoveAt(index1 + 1);

                    }
                    else if (courses.Contains($"{input[2]}-Exercise"))
                    {
                        string temp = lesson;


                        int index1 = courses.IndexOf(lesson);      //       1           3
                        int index2 = courses.IndexOf(input[2]);  //methods list arrays  data data-exercise //swap lists:data
                        courses[index1] = courses[index2];           //     data        list

                        courses[index2] = temp;
                        courses.RemoveAt(index2 + 1);
                        courses.Insert(index1 + 1, exercise2);

                    }
                    else
                    {
                        string temp = lesson;
                        int index1 = courses.IndexOf(lesson);
                        int index2 = courses.IndexOf(input[2]);
                        courses[index1] = courses[index2];
                        courses[index2] = temp;
                    }
                }
                if (task == "Exercise")
                {
                    string exercise = lesson + "-Exercise";
                    if (courses.Contains(lesson) && courses.Contains(exercise) == false)
                    {

                        int index = courses.IndexOf(lesson);
                        courses.Insert(index + 1, exercise);
                    }
                    else if (courses.Contains(lesson) == false)
                    {
                        courses.Add(lesson);
                        courses.Add(exercise);
                    }



                }

                //for (int i = 0; i < courses.Count; i++)
                //{
                //   Console.WriteLine($"{i+1}.{courses[i]}");
                //}  
                command = Console.ReadLine();
            }
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }

        }
    }
}

