using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    public class MergeSortString
    {
        public static void MergeSortStringFunction()
        {
            string[] str = { "Merge", "Bubble", "Insertion", "Selection", "Quick" };
            Console.WriteLine("Before merge sort");
            foreach (string s in str)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine("After merge sort");
            Utility utility = new Utility();
            utility.MergeSort(str);
            foreach(string s in str)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
}
