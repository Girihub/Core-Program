using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class ToBinary
    {
        public static void ToBinaryFunction()
        {
            try
            {
                Console.WriteLine("Enter decimal number to find it binary representation");
                int number = Convert.ToInt32(Console.ReadLine());
                Utility utility = new Utility();
                int[] arr = utility.BinaryOf(number);
                for(int i = 0; i < arr.Length; i++)
                {
                    if((i % 4)-3== 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(arr[i]);
                }
                Console.WriteLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
