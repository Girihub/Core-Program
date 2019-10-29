using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class PrimeNumbers
    {
        public static void TwoDimensionArray()
        {
            UtilityFunctions utility = new UtilityFunctions();
            int[] primeNumbers = new int[1000];
            int count = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if (utility.IsPrime(i))
                {
                    primeNumbers[count] = i;
                    count++;
                }
            }
            int[,] array = new int[10, 100];
            int min = 0, max = 100, k = 0;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    if(primeNumbers[k] < max && primeNumbers[k] > min)
                    {
                        array[i, j] = primeNumbers[k];
                        k++;
                    }
                    else
                    {
                        min = max;
                        max = max + 100;
                        break;
                    }
                }
            }
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    if (array[i, j] != 0)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
