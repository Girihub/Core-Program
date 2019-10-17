//----------------------------------------------------
// <copyright file="TwoDimensionArray.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// TwoDimensionArray as a class
    /// </summary>
    public class TwoDimensionArray
    {
        /// <summary>
        /// TwoDimensionArrayFunction as a function
        /// </summary>
        public static void TwoDimensionArrayFunction()
        {
            try
            {
                Console.WriteLine("Enter no. of rows of matrix");
                int rows = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter no. of columns of matrix");
                int columns = Convert.ToInt32(Console.ReadLine());
                Utility utility = new Utility();
                utility.TwoDimensionArray(rows, columns);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Enter integer values");
            }
        }
    }
}
