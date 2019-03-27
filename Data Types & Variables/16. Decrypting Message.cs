using System;

namespace More_Ex_6___Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char input = ' ';
            string decryptedMessage = string.Empty;
            
            

            for (int i = 0; i < n; i++)
            {
                input = char.Parse(Console.ReadLine());
                int convertedInput = (int)input;
               
                int sum = convertedInput + key;
                char decrypted = (char)sum;
                
                decryptedMessage += decrypted;
            }
            Console.WriteLine(decryptedMessage);

        }
    }
}
