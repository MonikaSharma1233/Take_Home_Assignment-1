using System;
namespace Take_Home_Assignment_1
{
    class Program
    {
        public static void Main(String[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            //start lap lap stop  restart lap stop reset
            stopwatch.PressSecondButton();//Print stopwatch is not started
            stopwatch.PressFirstButton();//started
            stopwatch.PressSecondButton();//lap
            stopwatch.PressSecondButton();//lap
            stopwatch.PressFirstButton();//stop
            stopwatch.PressFirstButton();//restart
            stopwatch.PressSecondButton();//lap
            stopwatch.PressFirstButton();//stop
            stopwatch.PressSecondButton();//reset


        }
    }
}

