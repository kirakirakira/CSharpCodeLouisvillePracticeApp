using System;
using System.Text;

namespace PracticeApp
{
    internal class Program
    {
        private static void AddTwoNumbers()
        {
            Console.WriteLine("You're adding two numbers");
            Console.WriteLine("Enter the first number");
            int first = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.WriteLine("\n");

            Console.WriteLine("Enter the second number");
            int second = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.WriteLine("\n");

            Console.WriteLine($"The sum of {first} and {second} is {first + second}");
        }

        private static void SubtractTwoNumbers()
        {
            Console.WriteLine("You're subtracting two numbers");
            Console.Write("Enter the first number");
            int? first = int.Parse(Console.ReadLine());
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.WriteLine("\n");

            Console.Write("Enter the second number");
            int? second = int.Parse(Console.ReadLine());
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.WriteLine("\n");

            Console.WriteLine($"The sum of {first} and {second} is {first - second}");
        }

        private static void RemoveWhitespace()
        {

        }

        private static void ReverseAString()
        {
            Console.WriteLine("You're reversing a string");
            string? phrase = Console.ReadLine();
            StringBuilder sb = new StringBuilder("", phrase.Length);

            for (int i = phrase.Length - 1; i > 0; i--)
            {
                sb.Append(phrase[i]);
            }

            Console.WriteLine(sb);
        }
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
            int userChoice = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.WriteLine("\n");
            Console.WriteLine($"Your choice was {userChoice}");

            switch (userChoice)
            {
                case 1:
                    AddTwoNumbers();
                    break;

                case 2:
                    SubtractTwoNumbers();
                    break;

                case 3:
                    RemoveWhitespace();
                    break;

                case 4:
                    ReverseAString();
                    break;

                case 5:
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                    Console.WriteLine("Program exited");
                    return false;

                default:
                    Console.WriteLine("You failed to make a valid choice, too bad!");
                    Console.WriteLine("Just kidding, try again");
                    break;
            }

            return true;
        }
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
            while (ShowMenu())
            {
                ShowMenu();
            }
        }
    }
}
