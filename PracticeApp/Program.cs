using System;

namespace PracticeApp
{
    internal class Program
    {
        private static void ShowMenu()
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

            Console.WriteLine("\n");
            Console.WriteLine($"Your choice was {userChoice}");

            switch (userChoice)
            {
                case 1:
                    AddTwoNumbers();
                    ShowMenu();
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                    Console.WriteLine("Program exited");
                    break;

                default:
                    Console.WriteLine("You failed to make a valid choice, too bad!");
                    Console.WriteLine("Just kidding, try again");
                    ShowMenu();
                    break;
            }
        }
        private static void AddTwoNumbers()
        {
            Console.WriteLine("You're adding two numbers");
            Console.WriteLine("Enter the first number");
            int first = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
            Console.WriteLine("\n");

            Console.WriteLine("Enter the second number");
            int second = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
            Console.WriteLine("\n");

            Console.WriteLine($"The sum of {first} and {second} is {first + second}");

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
            ShowMenu();
        }
    }
}
