//----------------------------------------------------
// <copyright file="WindChill.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// WindChill as a class
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// WindChillFunction as a function
        /// </summary>
        public static void WindChillFunction()
        {
            Console.WriteLine("Enter the value temperature. Should not be greater than 50");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of wind speed. Should be between 3 to 120");
            double speed = Convert.ToDouble(Console.ReadLine());
            Utility utility = new Utility();
            Console.WriteLine("National Weather Service defines the effective temperature (the wind chill) to be: " + utility.WindChillValue(temperature, speed));
        }
    }
}
