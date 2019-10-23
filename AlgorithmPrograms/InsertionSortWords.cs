using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    public class InsertionSortWords
    {
        public static void InsertionSortWordsFunction()
        {
            try
            {
                Console.WriteLine("Enter size of string array");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter " + size + " words in array separated by space");
                string str = Console.ReadLine();
                string[] str1 = str.Split(' ');
                Utility utility = new Utility();
                string[] str2 = utility.InsertionSortString(str1);
                foreach (string s in str2)
                {
                    Console.Write(s + " ");
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
