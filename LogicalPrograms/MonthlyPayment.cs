//----------------------------------------------------
// <copyright file="MonthlyPayment.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// MonthlyPayment as a class
    /// </summary>
    public class MonthlyPayment
    {
        /// <summary>
        /// MonthlyPaymentFunction as a function
        /// </summary>
        public static void MonthlyPaymentFunction()
        {
            try
            {
                Console.WriteLine("Enter the principle loan amount");
                int loan = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter percent of interest");
                int interest = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter no. of years to pay loan");
                int year = Convert.ToInt32(Console.ReadLine());
                Utility utility = new Utility();
                Console.WriteLine("You would have to make " + utility.MonthlyPayments(loan, interest, year) + " monthly to pay of a " + loan + " principle loan at " + interest + " percent interest compounded monthly");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
