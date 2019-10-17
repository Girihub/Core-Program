//----------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// LeapYear as a class
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// LeapYearFunction as a function
        /// </summary>
        public static void LeapYearFunction()
        {
            try
            {
                Console.WriteLine("Enter 4 digit year to check whether it is leap");
                int year = Convert.ToInt32(Console.ReadLine());
                while ((year + string.Empty).Length < 4)
                {
                    Console.WriteLine("Year should be of 4 digits");
                    year = Convert.ToInt32(Console.ReadLine());
                }

                Utility utility = new Utility();
                if (utility.Leap(year))
                {
                    Console.WriteLine(year + " is leap year");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Should be integer");
            }
        }
    }
}
