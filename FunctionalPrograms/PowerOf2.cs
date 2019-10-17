//----------------------------------------------------
// <copyright file="PowerOf2.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// PowerOf2 as a class
    /// </summary>
    public class PowerOf2
    {
        /// <summary>
        /// PowerOf2Function as a function
        /// </summary>
        public static void PowerOf2Function()
        {
            try
            {
                Console.WriteLine("Enter a number to print a table of power of 2");
                int input = Convert.ToInt32(Console.ReadLine());
                while (input > 30)
                {
                    Console.WriteLine("Input should be less than 31 since it overflows an int");
                    input = Convert.ToInt32(Console.ReadLine());
                }

                Utility utility = new Utility();
                utility.PowerOf2(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Should be integer");
            }
        }
    }
}
