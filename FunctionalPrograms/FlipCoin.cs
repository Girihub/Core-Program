//----------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
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
    /// FlipCoin as a class
    /// </summary>
    public class FlipCoin
    {
        /// <summary>
        /// FlipCoinFunction as a function
        /// </summary>
        public static void FlipCoinFunction()
        {
            Console.WriteLine("Enter no. of times you want to flip a coin");
            string input = Console.ReadLine();
            while (!Regex.IsMatch(input, @"^[0-9]+$") || Convert.ToInt32(input) < 1)
            {
                Console.WriteLine("Enter valid input. Should be +ve integer");
                input = Console.ReadLine();
            }

            int number = Convert.ToInt32(input);
            Utility utility = new Utility();
            utility.Flipcoin(number);
        }
    }
}
