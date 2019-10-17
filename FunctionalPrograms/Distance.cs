//----------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
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
    /// Distance as a class
    /// </summary>
    public class Distance
    {
        /// <summary>
        /// DistanceFunction as a function
        /// </summary>
        public static void DistanceFunction()
        {
            Console.WriteLine("Enter the value of x");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the value of y");
            string input2 = Console.ReadLine();
            while (!(Regex.IsMatch(input1, @"^[0-9]+$") && Regex.IsMatch(input2, @"^[0-9]+$")))
            {
                Console.WriteLine("Enter valid integer values");
                input1 = Console.ReadLine();
                input2 = Console.ReadLine();
            }

            int x = Convert.ToInt16(input1);
            int y = Convert.ToInt16(input2);
            Utility utility = new Utility();
            Console.WriteLine("The Euclidean distance from point (" + x + "," + y + ") to origin (0,0) is " + utility.EuclideanDistance(x, y));
        }
    }
}
