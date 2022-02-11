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
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Console.WriteLine("Program exited");
            return false;
        }
    }
}
