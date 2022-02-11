using System;
using System.Text;

namespace PracticeApp
{
    abstract class MenuItem
    {
        public string Choice { get; set; }
        public abstract bool ExecuteChoice();
    }
}
