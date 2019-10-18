using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class StopWatch
    {
        public static void StopWatchFunction()
        {
            try
            {
                long start = 0, stop = 0;
                Utility utility = new Utility();
                start = utility.Time();
                Console.WriteLine("StopWatch is running. Press 1 to stop the watch calculate elapsed time");
                int input = Convert.ToInt32(Console.ReadLine());
                while (input != 1)
                {
                    Console.WriteLine("Press 1 to measure elapsed time");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                stop = utility.Time();
                Console.WriteLine("Elapsed time is " + utility.ElapsedTime(start, stop) + " milliseconds");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
