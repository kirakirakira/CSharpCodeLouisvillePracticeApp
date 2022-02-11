using System;
using System.Text;

namespace PracticeApp
{
    internal class SubtractTwoNumbers : MenuItem
    {
        public SubtractTwoNumbers()
        {
            this.Choice = "Subtract two numbers";
        }

        public override bool ExecuteChoice()
        {
            Console.WriteLine("You're adding two numbers");
            Console.WriteLine("Enter the first number");
            int? first = Library.GetNumber();
            Console.WriteLine("Enter the second number");
            int? second = Library.GetNumber();

            Console.WriteLine($"The sum of {first} and {second} is {first - second}");
            return true;
        }
    }
}
