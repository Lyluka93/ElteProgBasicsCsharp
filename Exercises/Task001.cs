using System;

namespace Exercises
{
    static class Task001
    {
        static public void Run(string[] args)
        {
            string userInput;
            Console.WriteLine("Enter a positive whole number!");
            userInput = Console.ReadLine();
            int number;
            bool CanBeInt = Int32.TryParse(userInput, out number);
            if (CanBeInt)
            {
                if (number > 0)
                {
                    Console.WriteLine("You have entered: {0}", number);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You haven't entered a positive whole number! The program will close.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("You haven't entered a whole number! The program will close.");
                Console.ReadKey();
            }
        }
    }
}
