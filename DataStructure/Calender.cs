//----------------------------------------------------
// <copyright file="Calender.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Calender as a class
    /// </summary>
    public class Calender
    {
        /// <summary>
        /// CalenderFunction as a function
        /// </summary>
        public static void CalenderFunction()
        {
            try
            {
                UtilityFunctions utility = new UtilityFunctions();
                Console.WriteLine("Enter month");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter year");
                int year = Convert.ToInt32(Console.ReadLine());
                int start = utility.DayOfweek(1, month, year);
                String[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                String[] days = { "S", "M", "T", "W", "T", "F", "S" };
                Console.WriteLine("Calender " + month + " " + year);
                Console.WriteLine(months[month - 1] + "  " + year);
                int endDate = utility.EndDate(month, year);
                for(int i = 0; i < days.Length; i++)
                {
                    Console.Write(days[i] + "  ");
                }
                Console.WriteLine();
                int j = 1;
                int count = 0;
                for(int i = 1; i <= endDate; i++)
                {
                    while (count != start)
                    {
                        Console.Write("  ");
                        count++;
                    }
                    if((j + string.Empty).Length < 2)
                    {
                        Console.Write(j + "  ");
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }                    
                    if((j + count - 1) % 7 == 0)
                    {
                        Console.WriteLine();
                    }
                    j++;
                }

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
