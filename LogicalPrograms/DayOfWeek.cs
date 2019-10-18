using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class DayOfWeek
    {
        public static void DayOfWeekFunction()
        {
            Console.WriteLine("Enter month");
            string month = Console.ReadLine();
            Console.WriteLine("Enter day");
            string day = Console.ReadLine();
            Console.WriteLine("Enter Year");
            int y = Convert.ToInt32(Console.ReadLine());
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            int d = Convert.ToInt32(day);
            int m = Array.IndexOf(months, month);
            double y0 = y - Math.Floor((double)(14 - m) / 12);
            double x = y0 + Math.Floor(y0 / 4) - Math.Floor(y0 / 100) + Math.Floor(y0 / 400);
            double m0 = m + 12 * Math.Floor((double)((14 - m) / 12)) - 2;
            double d0 = Math.Ceiling((d + x + 31 * m0 / 12) % 7);         
            Console.WriteLine(d0);
        }
    }
}
