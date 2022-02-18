using System;
using System.Text;

namespace PracticeApp
{
    internal class Exit : IMenuItem
    {
        public string Choice { get; set; } = "Exit";

        public Exit()
        {
        }

        public bool ExecuteChoice()
        {
            Console.WriteLine("Type quit to quit");
            var quitString = Console.ReadLine();
            if (quitString == "quit")
            {
                Console.WriteLine("Program exited");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
