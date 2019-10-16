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
            int num = Convert.ToInt32(Console.ReadLine());
            Utility utility = new Utility();
            utility.PrimeFactors(num);
        }
    }
}
