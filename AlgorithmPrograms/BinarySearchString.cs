using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmPrograms
{
    public class BinarySearchString
    {
        public static void BinarySearchStringFunction()
        {
            try
            {
                string str = File.ReadAllText(@"C:\File.txt.txt");
                Console.WriteLine(str);
                Console.WriteLine();
                Utility utility = new Utility();
                Console.WriteLine("Enter word to search");
                string find = Console.ReadLine();
                if (utility.BinarySearchString(str, find) == -1)
                {
                    Console.WriteLine("Word not found");
                }
                else
                {
                    Console.WriteLine("Word present in file");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
