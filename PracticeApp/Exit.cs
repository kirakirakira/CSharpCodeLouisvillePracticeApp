using System;
using System.Text;

namespace PracticeApp
{
    internal class Exit : MenuItem
    {
        public Exit()
        {
            this.Choice = "Exit";
        }

        public override bool ExecuteChoice()
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
