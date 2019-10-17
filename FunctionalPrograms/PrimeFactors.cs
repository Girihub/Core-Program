//----------------------------------------------------
// <copyright file="PrimeFactors.cs" company="Bridgelabz">
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
    /// PrimeFactors as a class
    /// </summary>
    public class PrimeFactors
    {
        /// <summary>
        /// PrimeFactorFunction as a function
        /// </summary>
        public static void PrimeFactorFunction()
        {
            Console.WriteLine("Enter number to find it's prime factors");
            string input = Console.ReadLine();
            while (!Regex.IsMatch(input, @"^[0-9]+$"))
            {
                Console.WriteLine("Enter valid integer value");
                input = Console.ReadLine();
            }

            Utility utility = new Utility();
            int num = Convert.ToInt32(input);
            utility.PrimeFactors(num);
        }
    }
}
