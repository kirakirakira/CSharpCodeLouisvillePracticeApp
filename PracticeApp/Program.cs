using System;
using System.Text;

namespace PracticeApp
{
    internal class Program
    {
        private static bool ShowMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Add two numbers");
            Console.WriteLine("2. Subtract two numbers");
            Console.WriteLine("3. Remove whitespace from a string");
            Console.WriteLine("4. Reverse a string");
            Console.WriteLine("5. Quit");

            Console.WriteLine("Enter your choice: ");
            char userChoice = Console.ReadKey().KeyChar;
            // while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.WriteLine("\n");
            Console.WriteLine($"Your choice was {userChoice}");

            switch (userChoice)
            {
                case '1':
                    return new AddTwoNumbers().ExecuteChoice();

                case '2':
                    return new SubtractTwoNumbers().ExecuteChoice();

                case '3':
                    return new RemoveWhitespace().ExecuteChoice();

                case '4':
                    return new ReverseAString().ExecuteChoice();

                case '5':
                    return new Exit().ExecuteChoice();

                default:
                    Console.WriteLine("You failed to make a valid choice, too bad!");
                    Console.WriteLine("Just kidding, try again");
                    break;
            }

            return true;
        }
        static void Main(string[] args)
        {
            while (ShowMenu())
            {
                ShowMenu();
            }
        }
    }
}
