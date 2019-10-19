//----------------------------------------------------
// <copyright file="ToBinary.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ToBinary as a class
    /// </summary>
    public class ToBinary
    {
        /// <summary>
        /// ToBinaryFunction as a function
        /// </summary>
        public static void ToBinaryFunction()
        {
            try
            {
                Console.WriteLine("Enter decimal number to find it binary representation");
                int number = Convert.ToInt32(Console.ReadLine());
                Utility utility = new Utility();
                utility.BinaryOf(number);                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
