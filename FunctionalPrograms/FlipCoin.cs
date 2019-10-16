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
            int input = Convert.ToInt32(Console.ReadLine());
            while (input < 1)
            {
                Console.WriteLine("Enter valid input. Should be +ve");
                input = Convert.ToInt32(Console.ReadLine());
            }

            Utility utility = new Utility();
            utility.Flipcoin(input);
        }
    }
}
