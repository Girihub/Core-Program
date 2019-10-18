//----------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace LogicalPrograms
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Program as a class name
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args">args parameter</param>
        public static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1: Gambler");
                Console.WriteLine("2: CouponNumber");
                Console.WriteLine("3: StopWatch");
                Console.WriteLine("4: TicTacToe");
                Console.WriteLine("0: Exit");
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^[0-9]+$"))
                {
                    int number = Convert.ToInt32(input);
                    switch (number)
                    {
                        case 1:
                            Gambler.GamblerFunction();
                            break;

                        case 2:
                            CouponNumber.CouponNumberFunction();
                            break;

                        case 3:
                            StopWatch.StopWatchFunction();
                            break;

                        case 4:
                            TicTacToe.TicTacToeFunction();
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
