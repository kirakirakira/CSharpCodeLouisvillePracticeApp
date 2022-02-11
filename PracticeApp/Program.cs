﻿using System;
using System.Text;

namespace PracticeApp
{
    internal class Program
    {
        private static bool ShowMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Main Menu:");

            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].Choice}");
            }

            int userChoice = Library.GetNumber("Enter your choice: ");

            Console.WriteLine("\n");
            Console.WriteLine($"Your choice was {userChoice}");

            if (userChoice > items.Count)
            {
                Console.WriteLine("You failed to make a valid choice, too bad!");
                Console.WriteLine("Just kidding, try again");
                return false;
            }
            else
            {
                return items[userChoice - 1].ExecuteChoice();
            }
        }
        static List<MenuItem> items = new List<MenuItem>();

        public static void Main(string[] args)
        {
            items.Add(new AddTwoNumbers());
            items.Add(new SubtractTwoNumbers());
            items.Add(new RemoveWhitespace());
            items.Add(new ReverseAString());
            items.Add(new Exit());

            while (ShowMenu())
            {
                ShowMenu();
            }
        }
    }
}
