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
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y");
            int y = Convert.ToInt32(Console.ReadLine());
            Utility utility = new Utility();
            Console.WriteLine("The Euclidean distance from point (" + x + "," + y + ") to origin (0,0) is " + utility.EuclideanDistance(x, y));
        }
    }
}
