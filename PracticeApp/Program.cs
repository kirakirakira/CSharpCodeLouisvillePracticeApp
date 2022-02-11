using System;
using System.Text;
using StringExtensions;

namespace PracticeApp
{
    internal class Program
    {
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
            Console.WriteLine("Enter a string to have its whitespace removed");
            string phrase = Console.ReadLine();
            StringBuilder sb = new StringBuilder("", phrase.Length);

            for (int i = 0; i < phrase.Length; i++)
            {
                if (!Char.IsWhiteSpace(phrase[i]))
                {
                    sb.Append(phrase[i]);
                }
            }

            Console.WriteLine(sb);
        }

        private static void ReverseAString()
        {
            Console.WriteLine("Enter string to reverse");
            string phrase = Console.ReadLine();
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
                    return new AddTwoNumbers().ExecuteChoice();

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
            string toot = "Kira is awesome";
            string strippedToot = toot.RemoveWhitespace();

            Console.WriteLine(strippedToot);

            while (ShowMenu())
            {
                ShowMenu();
            }
        }
    }
}

namespace StringExtensions
{
    public static class StringExtensionsClass
    {

        public static string RemoveWhitespace(this string str, params object[] args)
        {
            string formattedString = str;

            StringBuilder sb = new StringBuilder("", formattedString.Length);

            for (int i = 0; i < formattedString.Length; i++)
            {
                if (!Char.IsWhiteSpace(formattedString[i]))
                {
                    sb.Append(formattedString[i]);
                }
            }

            return sb.ToString();
        }
    }
}
