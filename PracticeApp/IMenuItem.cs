using System;
using System.Text;

namespace PracticeApp
{
    public interface IMenuItem
    {
        string Choice { get; set; }
        bool ExecuteChoice();
    }
}
