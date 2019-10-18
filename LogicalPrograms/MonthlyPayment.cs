using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
   public class MonthlyPayment
    {
        public static void MonthlyPaymentFunction()
        {
            try
            {
                Console.WriteLine("Enter the principle loan amount");
                int P = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter percent of interest");
                int R = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter no. of years to pay loan");
                int Y = Convert.ToInt32(Console.ReadLine());
                Utility utility = new Utility();
                Console.WriteLine("You would have to make " + utility.MonthlyPayments(P, R, Y) + " monthly to pay of a " + P + " principle loan at " + R + " percent interest compounded monthly");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
