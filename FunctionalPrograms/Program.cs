//----------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Linq;

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
                Console.WriteLine("Enter 1: ReplaceString");
                Console.WriteLine("Enter 2: FlipCoin");
                Console.WriteLine("Enter 3: LeapYear");
                Console.WriteLine("Enter 4: PowerOf2");
                Console.WriteLine("Enter 5: HarmonicNumber");
                Console.WriteLine("Enter 6: PrimeFactors");
                Console.WriteLine("Enter 7: TwoDimensionArray");
                Console.WriteLine("Enter 8: SumOfThreeInteger");
                Console.WriteLine("Enter 9: Distance");
                Console.WriteLine("Enter 10: Quadratic");
                Console.WriteLine("Enter 11: WindChill");
                Console.WriteLine("Enter 0: To Exit");
                Console.WriteLine();

                string input = Console.ReadLine();
                bool isAllInt = input.All(char.IsDigit);             
                if (isAllInt)
                {
                    long num = Convert.ToInt64(input);
                    switch (num)
                    {
                        case 1:
                            ReplaceString.Replaceword();
                            break;

                        case 2:
                            FlipCoin.FlipCoinFunction();
                            break;

                        case 3:
                            LeapYear.LeapYearFunction();
                            break;

                        case 4:
                            PowerOf2.PowerOf2Function();
                            break;

                        case 5:
                            HarmonicNumber.HarmonicNumberFunction();
                            break;

                        case 6:
                            PrimeFactors.PrimeFactorFunction();
                            break;

                        case 7:
                            TwoDimensionArray.TwoDimensionArrayFunction();
                            break;

                        case 8:
                            SumOfThreeInteger.SumOfThreeFunction();
                            break;

                        case 9:
                            Distance.DistanceFunction();
                            break;

                        case 10:
                            Quadratic.QuadraticFunction();
                            break;

                        case 11:
                            WindChill.WindChillFunction();
                            break;

                        case 0:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid digit");
                }

                Console.WriteLine();
            }            
        }
    }
}
