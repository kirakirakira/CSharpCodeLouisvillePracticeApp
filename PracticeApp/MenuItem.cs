using System;
using System.Text;
using StringExtensions;

namespace PracticeApp
{
    abstract class MenuItem
    {
        public string Choice { get; set; }
        public abstract bool ExecuteChoice();
    }
}
