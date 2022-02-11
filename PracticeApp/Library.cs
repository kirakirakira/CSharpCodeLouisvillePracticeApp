using System;
using System.Text;
using StringExtensions;

namespace PracticeApp
{
    internal class Library
    {
        public static int? GetNumber()
        {
            while (true)
            {
                Console.WriteLine("Enter a number:");
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
