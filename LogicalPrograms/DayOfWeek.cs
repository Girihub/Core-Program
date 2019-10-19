//----------------------------------------------------
// <copyright file="DayOfWeek.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DayOfWeek as a class
    /// </summary>
    public class DayOfWeek
    {
        /// <summary>
        /// DayOfWeekFunction as a function
        /// </summary>
        public static void DayOfWeekFunction()
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Enter valid integers for date");
            }
        }
    }
}
