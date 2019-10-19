using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
   public class Binary
    {
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
