//----------------------------------------------------
// <copyright file="PalindromeChecker.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using DataStructure.Utility;

    /// <summary>
    /// PalindromeChecker as a class
    /// </summary>
    public class PalindromeChecker
    {
        /// <summary>
        /// PalindromeCheckerFunction as a function
        /// </summary>
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
