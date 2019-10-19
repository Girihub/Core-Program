using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class VendingMechine
    {
        public static void VendingMechineFuncrion()
        {
            try
            {
                Console.WriteLine("Enter the amount in RS to be returned");
                int amount = Convert.ToInt32(Console.ReadLine());
                Utility utility = new Utility();
                utility.FewestNotes(amount);
                Console.WriteLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " Enter integer value");
            }
        }
    }
}
