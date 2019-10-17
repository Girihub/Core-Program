//----------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Quadratic as a class
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// QuadraticFunction as a function
        /// </summary>
        public static void QuadraticFunction()
        {
            Console.WriteLine("Enter the values of a,b and c to find the roots of the equation a*x*x+b*x+c");
            Console.WriteLine("Enter the value of a");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the value of b");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter the value of c");
            string input3 = Console.ReadLine();
            string pattern = @"^[0-9]+$";
            while (!Regex.IsMatch(input1, pattern) || !Regex.IsMatch(input2, pattern) || !Regex.IsMatch(input3, pattern))
            {
                Console.WriteLine("Enter valid integer values");
                input1 = Console.ReadLine();
                input2 = Console.ReadLine();
                input3 = Console.ReadLine();
            }

            Utility utility = new Utility();
            int a = Convert.ToInt32(input1);
            int b = Convert.ToInt32(input2);
            int c = Convert.ToInt32(input3);
            utility.QuadraticRoots(a, b, c);
        }
    }
}
