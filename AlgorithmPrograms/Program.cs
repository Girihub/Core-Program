using System;
using System.Text.RegularExpressions;

namespace AlgorithmPrograms
{
    public class Program
    {
        static void Main(string[] args)
        { 
            
            bool exit = false;
            while (!exit)
             {
                Console.WriteLine("1: Permutation");
                Console.WriteLine("2: BinarySearchString");
                Console.WriteLine("3: InsertionSortWord");
                Console.WriteLine("4: BubbleSortWord");
                Console.WriteLine("5: MergeSortString");
                Console.WriteLine("0: Exit");
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^[0-9]+$"))
                {
                    int num = Convert.ToInt32(input);
                    switch (num)
                    {
                        case 1:
                            Permutation.PermutationFunction();
                            break;

                        case 2:
                            BinarySearchString.BinarySearchStringFunction();
                            break;

                        case 3:
                            InsertionSortWords.InsertionSortWordsFunction();
                            break;

                        case 4:
                            BubbleSortWords.BubbleSortWordsFunction();
                            break;

                        case 5:
                            MergeSortString.MergeSortStringFunction();
                            break;

                        case 0:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Enter digit among following");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter integer value");
                }
            }           
        }
    }
}
