using System;
using System.Text;

namespace PracticeApp
{
    internal class Library
    {
        public static int GetNumber(string message = "Enter a number: ")
        {
            while (true)
            {
                Console.WriteLine(message);
                int number;
                bool validNumber = int.TryParse(Console.ReadLine(), out number);
                if (validNumber)
                    return number;
                else
                    Console.WriteLine("That was not a number, try again");
            }
        }
    }
}
