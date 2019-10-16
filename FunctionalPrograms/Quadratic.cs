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
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            int c = Convert.ToInt32(Console.ReadLine());
            Utility utility = new Utility();
            utility.QuadraticRoots(a, b, c);
        }
    }
}
