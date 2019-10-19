//----------------------------------------------------
// <copyright file="VendingMechine.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Defined a class
    /// </summary>
    public class VendingMechine
    {
        /// <summary>
        /// Defined a function
        /// </summary>
        public static void VendingMechineFunction()
        {
            try
            {
                Console.WriteLine("Enter the amount in RS to be returned");
                int amount = Convert.ToInt32(Console.ReadLine());
                Utility utility = new Utility();
                utility.FewestNotes(amount);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Enter integer value");
            }
        }
    }
}
