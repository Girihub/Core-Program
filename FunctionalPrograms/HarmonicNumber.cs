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
            int num = Convert.ToInt32(Console.ReadLine());
            while (num == 0)
            {
                Console.WriteLine("Number should not be 0");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Utility utility = new Utility();
            Console.WriteLine("Harmonic value of " + num + " is " + utility.Harmonic(num));
        }
    }
}
