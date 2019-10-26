using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class PrimeNumbers
    {
        public static void TwoDimensionArray()
        {
            UtilityFunctions utility = new UtilityFunctions();
            for(int i = 1; i <= 1000; i++)
            {
                if (utility.IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
