using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
   public class CouponNumber
    {
        public static void CouponNumberFunction()
        {
            try
            {
                Console.WriteLine("How many random numbers you want to generate");
                int input = Convert.ToInt32(Console.ReadLine());
                Utility utility = new Utility();
                utility.Coupon(input);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
