using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool numOfChar = NumberOfCharacters(password);
            bool onlyLetters = OnlyLettersAndDigits(password);
            bool twoDigits = HaveAtLeast2Digits(password);
            if (numOfChar&&onlyLetters&&twoDigits== true)
            {
                Console.WriteLine("Password is valid");
            }
            if (numOfChar==false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (onlyLetters==false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (twoDigits==false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }


        }

        private static bool OnlyLettersAndDigits(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (!(((int)password[i] >= 48 && (int)password[i] <= 90) || ((int)password[i] >= 97 && (int)password[i] <= 122)))
                {
                    counter++;
                    
                }
               
            }
            if (counter > 0) 
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private static bool HaveAtLeast2Digits(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if ((int)password[i] >= 48 && (int)password[i] <= 57)
                {
                    counter++;
                }
            }
            if (counter < 2)
            {
                return false;
            }
            else
            {
                return true;
            }


        }



        private static bool NumberOfCharacters(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }
            else return true;
        }
    }
}
