using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class Gambler
    {
        public static void GamblerFunction()
        {
            try
            {
                int stakes = 0, goals = 0, times = 0;
                Console.WriteLine("Enter the stake value");
                stakes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the goal value. Goal should be greater than stake");
                goals = Convert.ToInt32(Console.ReadLine());
                while (goals <= stakes)
                {
                    Console.WriteLine("Goal should be greater than stake. Enter the goal value.");
                    goals = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Enter no. of times you want to play");
                times = Convert.ToInt32(Console.ReadLine());
                Utility utility = new Utility();
                utility.Gambling(stakes, goals, times);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Require integer values only");
            }
        }
    }
}
