//----------------------------------------------------
// <copyright file="SumOfThreeInteger.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// SumOfThreeInteger as a class
    /// </summary>
    public class SumOfThreeInteger
    {
        /// <summary>
        /// SumOfThreeFunction as a function
        /// </summary>
        public static void SumOfThreeFunction()
        {
            try
            {
                Console.WriteLine("Enter size of array");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter " + size + " integer elements of array");
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Utility utility = new Utility();
                utility.DistinctTriplets(array);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Array elements should be integers");
            }
        }
    }
}
