using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class ToBinary
    {
        public static void ToBinaryFunction()
        {
            try
            {
                Console.WriteLine("Enter decimal number to find it binary representation");
                int number = Convert.ToInt32(Console.ReadLine());
                Utility utility = new Utility();
                utility.BinaryOf(number);                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
