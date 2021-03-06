using System;
using System.Text;

namespace PracticeApp
{
    internal class ReverseAString : IMenuItem
    {
        public string Choice { get; set; } = "Reverse a string";
        public ReverseAString()
        {
        }

        public bool ExecuteChoice()
        {
            Console.WriteLine("Enter string to reverse");
            string phrase = Console.ReadLine();
            StringBuilder sb = new StringBuilder("", phrase.Length);

            for (int i = phrase.Length - 1; i > 0; i--)
            {
                sb.Append(phrase[i]);
            }
            sb.Append(phrase[0]);

            Console.WriteLine(sb);

            return true;
        }
    }
}
