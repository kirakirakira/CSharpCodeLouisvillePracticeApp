using System;
using System.Text;

namespace PracticeApp
{
    internal class AddTwoNumbers : IMenuItem
    {
        public string Choice { get; set; } = "Add two numbers";

        public AddTwoNumbers()
        {
        }

        public bool ExecuteChoice()
        {
            Console.WriteLine("You're adding two numbers");
            Console.WriteLine("Enter the first number");
            int? first = Library.GetNumber();
            Console.WriteLine("Enter the second number");
            int? second = Library.GetNumber();

            Console.WriteLine($"The sum of {first} and {second} is {first + second}");
            return true;
        }
    }
}
