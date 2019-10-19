//----------------------------------------------------
// <copyright file="SquareRoot.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// SquareRoot as a class
    /// </summary>
    public class SquareRoot
    {
        /// <summary>
        /// SquareRootFunction as a function
        /// </summary>
        public static void SquareRootFunction()
        {
            try
            {
                double number = 0;
                while (number < 1)
                {
                    Console.WriteLine("Enter +ve integer to find its square root");
                    number = Convert.ToDouble(Console.ReadLine());
                }

                Utility utility = new Utility();
                Console.WriteLine("By Newton's methode, square root of " + number + " is " + utility.Squareroot(number));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
