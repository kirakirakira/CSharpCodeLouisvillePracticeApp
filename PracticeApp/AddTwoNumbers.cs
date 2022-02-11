using System;
using System.Text;
using StringExtensions;

namespace PracticeApp
{
    internal class AddTwoNumbers : MenuItem
    {
        public AddTwoNumbers()
        {
            this.Choice = "Add two numbers";
        }

        public override bool ExecuteChoice()
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
