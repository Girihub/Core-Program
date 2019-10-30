//----------------------------------------------------
// <copyright file="CalenderByQueue.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using DataStructure.Utility;

    /// <summary>
    /// CalenderByQueue as a class
    /// </summary>
    public class CalenderByQueue
    {
        /// <summary>
        /// DisplayCalender as a function
        /// </summary>
        public static void DisplayCalender()
        {
            UtilityFunctions utility = new UtilityFunctions();
            Queue queue = new Queue();
            Console.WriteLine("Enter month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int start = utility.DayOfweek(1, month, year);
            int endDate = utility.EndDate(month, year);
            while (start > 1)
            {
                queue.Enqueue("   ");
                start--;
            }

            int count = 1;
            while (count <= endDate)
            {
                if (count < 9)
                {
                    queue.Enqueue(count + "  ");
                }
                else
                {
                    queue.Enqueue(count + " ");
                }
                count++;
            }
            Console.WriteLine(months[month - 1] + " " + year);
            Console.WriteLine("S |M |T |W |T |F |S");
            count = 0;
            while (!queue.IsEmpty())
            {
                Console.Write(queue.Get());
                queue.Dequeue();
                count++;
                if (count % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}
