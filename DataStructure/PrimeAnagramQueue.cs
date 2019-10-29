//----------------------------------------------------
// <copyright file="PrimeAnagramQueue.cs" company="Bridgelabz">
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
    /// PrimeAnagramQueue as a class
    /// </summary>
    public class PrimeAnagramQueue
    {
        /// <summary>
        /// PrimeAndAnagram as a function
        /// </summary>
        public static void PrimeAndAnagram()
        {
            try
            {
                UtilityFunctions utility = new UtilityFunctions();
                QueueUsingLinkedList queue = new QueueUsingLinkedList();

                for (int i = 1; i <= 1000 - 1; i++)
                {
                    for (int j = i + 1; j <= 1000; j++)
                    {
                        if (utility.IsAnagram(i + "", j + "") && utility.IsPrime(i) && utility.IsPrime(j))
                        {
                            queue.enqueue(j);
                        }
                    }
                }

                queue.show();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
