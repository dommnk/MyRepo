using System;

namespace Stopwatch
{
    class Program
    {
        
        private static DateTime? Start(string start)
        {
            if (start == "S" || start == "s")
                return DateTime.Now;
            else
                return null;

        }
        private static DateTime? Stop(string stop)
        {
            if (stop == "F" || stop == "f")
                return DateTime.Now;
            else
                return null;
        }
        static void Main(string[] args)
        {
            DateTime StartTime;
            DateTime StopTime;
            TimeSpan TimePassed;
            String StartControl;
            String StopControl;
            String ToContinue;
            bool isFinished = false;

            while(!isFinished)
            {
                try
                {   // get start time 
                    Console.WriteLine("Press S to start stopwatch");
                    StartControl = Console.ReadLine();
                    StartTime = (DateTime)Start(StartControl);
                    Console.WriteLine("Stopwatch started at: " + StartTime);

                    // get stop time
                    Console.WriteLine("Press F to stop stopwatch");
                    StopControl = Console.ReadLine();
                    StopTime = (DateTime)Stop(StopControl);
                    Console.WriteLine("Stopwatch stopped at: " + StopTime);

                    // calculate difference between stop time and start time
                    TimePassed = StopTime.Subtract(StartTime);
                    Console.WriteLine("Time Passed: " + TimePassed);

                }
                catch (Exception InvalidOperationException)
                {
                    Console.WriteLine(InvalidOperationException.Message);
                    Console.WriteLine("Please try again.");
                }

                Console.WriteLine("Continue?(Y/N)");
                ToContinue = Console.ReadLine();

                if (ToContinue == "N" || ToContinue == "n")
                {
                    isFinished = true;
                }
            }
        }
    }
}
