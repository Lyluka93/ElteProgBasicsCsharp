using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    static class Task002
    {
        static public void Run(string[] args)
        {
            string userInput;
            Console.WriteLine("Enter the sum!");
            userInput = Console.ReadLine();
            double sum;
            bool CanBeInt = Double.TryParse(userInput, out sum);
            if (CanBeInt)
            {
                if (sum > 0)
                {
                    double average = sum / 30;
                    Console.WriteLine($"The credit average: {average}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You haven't entered a positive sum! The program will close.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("You haven't entered a number! The program will close.");
                Console.ReadKey();
            }
        }
    }

}
