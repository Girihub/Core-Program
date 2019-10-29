using System;
using System.Collections.Generic;
using System.Text;
using DataStructure.Utility;

namespace DataStructure
{
    public class PrimeAnagramStack
    {
        public static void PrimeAndAnagram()
        {
            StackUsingLinkedList stack = new StackUsingLinkedList();            
            UtilityFunctions utility = new UtilityFunctions();
            for(int i = 1; i <= 1000; i++)
            {
                if (utility.IsPrime(i))
                {
                    for(int j = i + 1; j <= 1000-1; j++)
                    {
                        if (utility.IsAnagram(i + "", j + "") && utility.IsPrime(j))
                        {
                            stack.push(j);
                            Console.WriteLine(i + " " + j);
                        }
                    }
                }
            }
            
            Console.WriteLine();
        }
    }
}
