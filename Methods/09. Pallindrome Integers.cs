using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                // int pallindrome = int.Parse(command);
                bool check = CheckPallindrome(command);
                if (check==true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                

               
                command = Console.ReadLine();
            }

        }

        private static bool CheckPallindrome(string command)
        {
            int counter = 0;

            for (int i = 0; i < command.Length; i++)
            {

                if (command[i] == command[command.Length - 1 - i])  //command[0] == command[5]  // command[1]==command[4]  command[2] ==[command[3]
                {
                    counter++;
                }
            }

            if (counter == command.Length)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
