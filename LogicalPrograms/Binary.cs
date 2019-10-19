//----------------------------------------------------
// <copyright file="Binary.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Binary as class
    /// </summary>
    public class Binary
    {
        /// <summary>
        /// BinaryFunction as a function
        /// </summary>
        public static void BinaryFunction()
        {
            try
            {
                Console.WriteLine("Enter integer value");
                int input = Convert.ToInt32(Console.ReadLine());
                Utility utility = new Utility();
                utility.SwapNibbles(input);               
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Enter valid Integer");
            }
        }
    }
}
