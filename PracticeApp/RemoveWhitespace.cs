using System;
using System.Text;

namespace PracticeApp
{
    internal class RemoveWhitespace : MenuItem
    {
        public RemoveWhitespace()
        {
            this.Choice = "Subtract two numbers";
        }

        public override bool ExecuteChoice()
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
            return true;
        }
    }
}
