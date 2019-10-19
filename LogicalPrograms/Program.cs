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
                Console.WriteLine("5: DayOfWeek");
                Console.WriteLine("6: TemperatureConversion");
                Console.WriteLine("7: MonthlyPayment");
                Console.WriteLine("8: SquareRoot");
                Console.WriteLine("9: ToBinary");
                Console.WriteLine("10: ToSwapNibbles");
                Console.WriteLine("11: VendingMechine");
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

                        case 5:
                            DayOfWeek.DayOfWeekFunction();
                            break;

                        case 6:
                            TemperatureConversion.TemperatureConversionFunction();
                            break;

                        case 7:
                            MonthlyPayment.MonthlyPaymentFunction();
                            break;

                        case 8:
                            SquareRoot.SquareRootFunction();
                            break;

                        case 9:
                            ToBinary.ToBinaryFunction();
                            break;

                        case 10:
                            Binary.BinaryFunction();
                            break;

                        case 11:
                            VendingMechine.VendingMechineFunction();
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
