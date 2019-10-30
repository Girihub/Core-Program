//----------------------------------------------------
// <copyright file="PrimeAnagramStack.cs" company="Bridgelabz">
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
    /// PrimeAnagramStack as a class
    /// </summary>
    public class PrimeAnagramStack
    {
        /// <summary>
        /// PrimeAndAnagram as a function
        /// </summary>
        public static void PrimeAndAnagram()
        {
            try
            {
                StackUsingLinkedList stack = new StackUsingLinkedList();
                UtilityFunctions utility = new UtilityFunctions();
                for (int i = 1; i <= 1000; i++)
                {
                    if (utility.IsPrime(i))
                    {
                        for (int j = i + 1; j <= 1000 - 1; j++)
                        {
                            if (utility.IsAnagram(i + string.Empty, j + string.Empty) && utility.IsPrime(j))
                            {
                                stack.push(j);
                                Console.WriteLine(i + " " + j);
                            }
                        }
                    }
                }

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
