using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class DayOfWeek
    {
        public static void DayOfWeekFunction()
        {
            Console.WriteLine("Enter day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());
            Utility utility = new Utility();
            utility.DayOfweek(day, month, year);                         
        }
    }
}
