using System;
using System.Collections.Generic;
using System.Text;
using DataStructure.Utility;

namespace DataStructure
{
    public class PalindromeChecker
    {
        public static void PalindromeCheckerFunction()
        {
            try
            {
                UtilityFunctions utility = new UtilityFunctions();
                Console.WriteLine("Enter string to check if it is palindrome");
                string input = Console.ReadLine();                
                if (utility.PalindromCheck(input))
                {
                    Console.WriteLine("String is palindrome");
                }
                else
                {
                    Console.WriteLine("String is not palindrome");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
