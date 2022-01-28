using System;

namespace PracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // show user a menu
            // offer options to user
            // ask for their choice
            // do their choice
            // go back to menu
            // go back to beginning
            // unless choice is exit
            // exit application
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Add two numbers");
            Console.WriteLine("2. Subtract two numbers");
            Console.WriteLine("3. Remove whitespace from a string");
            Console.WriteLine("4. Reverse a string");

            Console.WriteLine("Enter your choice: ");
            char userChoice = Console.ReadKey().KeyChar;

            Console.WriteLine("\n");
            Console.WriteLine($"Your choice was {userChoice}");



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Console.WriteLine("Program exited");
        }
    }
}
