using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Home_Assignment_1
{

    public class Stopwatch : IState
    {
        string CurrentState = "InitialScreenState";

        string InitialScreenState = "InitialScreenState";
        string Button1 = "Start"; string Button2 = "Lap";
        string RunningState = "RunningState";
        
        public string TextOnFirstButton=> throw new NotImplementedException();

        public string TextOnSecondButton => throw new NotImplementedException();

        public Stopwatch PressFirstButton()
        {
            if (CurrentState == "InitialScreenState" && Button1 == "Start" && Button2 == "Lap")
            {
                Console.WriteLine("Current State[InitialScreenState], Button1[Start], Button2[Lap]");
                Console.WriteLine("StopWatchStarted.");
                CurrentState = "RunningState";Button1 = "Stop"; Button2 = "Lap";
                throw new NotImplementedException();

            }
            else if (CurrentState == "DisplayingResultState" && Button1 == "Start" && Button2 == "Reset")
            {
                Console.WriteLine("Current State [DisplayingResultState], Button1[Start], Button2[Reset]");
                Console.WriteLine("StopWatchRestarted.");
                CurrentState = "InitalScreenState"; Button1 = "Start";Button2 = "Lap";
                throw new NotImplementedException();
            }
            else if (CurrentState == "LappingState" && Button1 == "Stop" && Button2 == "Lap")
            {
                Console.WriteLine("Current State [LappingState], Button1[Stop], Button2[Lap]");
                Console.WriteLine("StopWatchStoped.");
                CurrentState = "DisplayResultState";Button1 = "Start";Button2 = "Reset";
                throw new NotImplementedException();
            }
            else
            {
                Console.WriteLine("Invalid State");
                throw new NotImplementedException();

            }
        }

        public Stopwatch PressSecondButton()
        {
            if(CurrentState == "RunningState" && Button1 == "Stop" && Button2 == "Lap")
            {
                Console.WriteLine("Current State[RunningState], Button1[Stop], Button2[Lap]");
                Console.WriteLine("StopwatchLap");
                CurrentState = "DisplayResultState";Button1 = "Start";Button2 = "Reset";
                throw new NotImplementedException();
               
            }
            else if (CurrentState == "LappingState" && Button1 == "Stop" && Button2 == "Lap")
            {
                Console.WriteLine("Current State[LappingState], Button1[Stop], Button2[Lap]");
                Console.WriteLine("StopwatchLap");
                CurrentState = "DisplayResultState"; Button1 = "Start"; Button2 = "Reset";
                throw new NotImplementedException();

            }
            else if (CurrentState == "DisplayingResultState" && Button1 == "Start" && Button2 == "Reset")
            {
                Console.WriteLine("Current State[DisplayingResultState], Button1[Start], Button2[Reset]");
                Console.WriteLine("StopwatchReset");
                CurrentState = "RunningState";Button1 = "Start";Button2 = "Reset";
                throw new NotImplementedException();

            }
            else
            {
                Console.WriteLine("Stopwatch is not Started");
                throw new NotImplementedException();

            }

        }


    }
}
