//----------------------------------------------------
// <copyright file="ReplaceString.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ReplaceString as class
    /// </summary>
    public class ReplaceString
    {
        /// <summary>
        /// Replace word as a function
        /// </summary>
        public static void Replaceword()
        {
            Console.WriteLine("Enter Your Name");
            string input = Console.ReadLine();      
            Utility utility = new Utility();
            utility.ReplaceString(input);
        }
    }
}
