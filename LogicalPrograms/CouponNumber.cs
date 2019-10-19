//----------------------------------------------------
// <copyright file="CouponNumber.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// CouponNumber as a class
    /// </summary>
    public class CouponNumber
    {
        /// <summary>
        /// CouponNumberFunction as a function
        /// </summary>
        public static void CouponNumberFunction()
        {
            try
            {
                Console.WriteLine("How many random numbers you want to generate");
                int input = Convert.ToInt32(Console.ReadLine());
                Utility utility = new Utility();
                utility.Coupon(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
