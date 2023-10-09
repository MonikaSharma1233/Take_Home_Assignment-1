using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Home_Assignment_1
{
    public interface IState
    {
        string TextOnFirstButton { get; }
        string TextOnSecondButton { get; }
        Stopwatch PressFirstButton();
        Stopwatch PressSecondButton();
    }
}
