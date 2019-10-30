//----------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Program as a class name
    /// </summary>
    public class Program
    {
        /// <summary>
        /// main function
        /// </summary>
        /// <param name="args">args as a parameter</param>
        public static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1: UnOrdered List");
                Console.WriteLine("2: Ordered List");
                Console.WriteLine("3: BalancedParenthesis");
                Console.WriteLine("4: BankingCashCounter");
                Console.WriteLine("5: PalindromeChecker");
                Console.WriteLine("6: HashChain");
                Console.WriteLine("7: PrimeNumbers");
                Console.WriteLine("8: PrimeAnagram By Stack");
                Console.WriteLine("9: PrimeAnagram By Queue");
                Console.WriteLine("10: Calender");
                Console.WriteLine("0: Exit");
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^[0-9]+$"))
                {
                    int num = Convert.ToInt32(input);
                    switch (num)
                    {
                        case 1:
                            UnOrderedList.UnOrderedListFunction();
                            break;

                        case 2:
                            OrderedList.OrderedListFunction();
                            break;

                        case 3:
                            BalancedParenthesis.BalancedParenthesisFunction();
                            break;

                        case 4:
                            BankingCashCounter.BankingCashCounterFunction();
                            break;

                        case 5:
                            PalindromeChecker.PalindromeCheckerFunction();
                            break;

                        case 6:
                            HashChain.HashChainFunction();
                            break;

                        case 7:
                            PrimeNumbers.TwoDimensionArray();
                            break;

                        case 8:
                            PrimeAnagramStack.PrimeAndAnagram();
                            break;

                        case 9:
                            PrimeAnagramQueue.PrimeAndAnagram();
                            break;

                        case 10:
                            Calender.CalenderFunction();
                            break;

                        case 0:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid input to run any program");
                    Console.WriteLine();
                }
            }
        }
    }
}
