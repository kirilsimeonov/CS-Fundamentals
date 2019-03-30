using System;
using System.Linq;



namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string command = string.Empty;

            int[] field = new int[size];

            int[] initialBugPlaces = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();     //INITIAL BUG PLACES INPUT

            for (int i = 0; i < initialBugPlaces.Length; i++)         //PLACE BUGS INTO ARRAY FIELD  ex 0 1 --> 1 1 0
            {
                if (initialBugPlaces[i] >= 0 && initialBugPlaces[i] < field.Length)
                {
                    field[initialBugPlaces[i]] = 1;
                }
                
            }
           // Console.WriteLine(String.Join(" ", field));
            while (true)
            {

               // Console.WriteLine(String.Join(" ", field));
                command = Console.ReadLine();

                if (command == "end")
                {
                    Console.WriteLine(String.Join(" ", field));
                    return;
                }

                string[] comm = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                int startingIndex = int.Parse(comm[0]);  //STARTING INDEX
                string direction = comm[1];
                int movement = int.Parse(comm[2]);            //MOVEMENT PLACES


                int newIndex = 0;

                if (startingIndex >= 0 && startingIndex < field.Length && field[startingIndex] != 0)
                {
                    if (direction == "right" && movement!=0)
                    {
                        newIndex = startingIndex + movement;
                        if (newIndex <= field.Length - 1 && newIndex >= 0)
                        {
                            while (field[newIndex] != 0 && newIndex + movement <= field.Length - 1 && newIndex + movement >= 0)

                            {
                                newIndex += movement;

                            }

                            field[newIndex] = field[startingIndex];
                            field[startingIndex] = 0;
                        }
                        else if (newIndex == field.Length - 1)
                        {
                            field[newIndex] = field[startingIndex];
                            field[startingIndex] = 0;

                        }
                        else if (newIndex > field.Length - 1)
                        {
                            field[startingIndex] = 0;
                        }
                        else
                        {

                            field[startingIndex] = 0;
                        }
                    }
                    if (direction == "left" && movement!=0)
                    {
                        newIndex = startingIndex - movement; //1
                        if (newIndex > 0 && newIndex <= field.Length - 1)
                        {
                            while (field[newIndex] != 0 && newIndex - movement <= field.Length - 1 && newIndex - movement >= 0)
                            {
                                newIndex -= movement;
                            }

                            field[newIndex] = field[startingIndex];
                            field[startingIndex] = 0;
                        }
                        else if (newIndex == 0)
                        {
                            field[newIndex] = field[startingIndex];
                            field[startingIndex] = 0;

                        }
                        else if (newIndex > field.Length - 1)
                        {
                            field[startingIndex] = 0;
                        }
                        else
                        {
                            field[startingIndex] = 0;
                        }
                    }
                }

            }
        }
    }
}

