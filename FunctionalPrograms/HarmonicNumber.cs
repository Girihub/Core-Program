//----------------------------------------------------
// <copyright file="HarmonicNumber.cs" company="Bridgelabz">
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
    /// HarmonicNumber as a class
    /// </summary>
    public class HarmonicNumber
    {
        /// <summary>
        /// HarmonicNumberFunction as a function
        /// </summary>
        public static void HarmonicNumberFunction()
        {
            Console.WriteLine("Enter number to find it's harmonic value");
            string input = Console.ReadLine();
            while (!Regex.IsMatch(input, @"^[0-9]+$") || Convert.ToInt32(input) == 0)
            {
                Console.WriteLine("Enter valid number. Greater than 0");
                input = Console.ReadLine();
            }

            int num = Convert.ToInt32(input);
            Utility utility = new Utility();
            Console.WriteLine("Harmonic value of " + num + " is " + utility.Harmonic(num));
        }
    }
}
