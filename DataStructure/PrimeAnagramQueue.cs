using System;
using System.Collections.Generic;
using System.Text;
using DataStructure.Utility;

namespace DataStructure
{
    public class PrimeAnagramQueue
    {
        public static void PrimeAndAnagram()
        {
            UtilityFunctions utility = new UtilityFunctions();
            QueueUsingLinkedList queue = new QueueUsingLinkedList();

            for(int i = 1; i <= 1000-1; i++)
            {
                for(int j = i + 1; j <= 1000; j++)
                {
                    if(utility.IsAnagram(i + "", j + "") && utility.IsPrime(i) && utility.IsPrime(j))
                    {
                        queue.enqueue(j);
                    }
                }
            }

            queue.show();
            Console.WriteLine();
        }
    }
}
