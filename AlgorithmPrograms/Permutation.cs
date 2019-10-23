namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Permutation
    {
        public static void PermutationFunction()
        {
            try
            {
                Console.WriteLine("Enter string for permutation");
                string str = Console.ReadLine();
                char[] charArray = str.ToCharArray();
                Utility utility = new Utility();
                utility.PermutationOfCharArray(charArray, 0, charArray.Length - 1);
            } 
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
