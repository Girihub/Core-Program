//----------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Utility as a class. Contains all the functions of programs
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// epsilon as a constant to use in program
        /// </summary>
        public const double Epsilon = 1e-15;

        /// <summary>
        /// Function for gambling game
        /// </summary>
        /// <param name="stake">stake as a parameter</param>
        /// <param name="goal">goal as a parameter</param>
        /// <param name="time">time as a parameter</param>
        public void Gambling(int stake, int goal, int time)
        {
            int win = 0, j = 0;
            Random random = new Random();
            for (int i = 1; i <= time; i++)
            {
                j++;
                if (random.NextDouble() > 0.5)
                {
                    stake++;
                    win++;
                }
                else
                {
                    stake--;
                }

                if (stake == goal)
                {
                    Console.WriteLine("CONGRATS! YOU WON!");
                    break;
                }

                if (stake == 0)
                {
                    Console.WriteLine("Sorry. You Lost");
                    break;
                }
            }

            Console.WriteLine("You won " + win + " times");
            Console.WriteLine("You lost " + (j - win) + " times");
            double winPercent = ((double)win / j) * 100;
            double lossPercent = ((double)(j - win) / j) * 100;
            Console.WriteLine("Win percentages are " + winPercent + "%");
            Console.WriteLine("Loss percentages are " + lossPercent + "%");
        }

        /// <summary>
        /// Function check whether array contains given number
        /// </summary>
        /// <param name="arr">array as a parameter</param>
        /// <param name="number">number as a parameter</param>
        /// <returns>Returns true if array contains given number</returns>
        public bool Contains(int[] arr, int number)
        {
            foreach (int i in arr)
            {
                if (i == number)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Function to generate distinct coupon
        /// </summary>
        /// <param name="number">number as a parameter</param>
        public void Coupon(int number)
        {
            string coupon = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            int[] arr = new int[number];
            Random random = new Random();
            int i = 0, j = 0;
            while (i < number)
            {
                int randomNumber = random.Next(coupon.Length);
                if (!this.Contains(arr, randomNumber))
                {
                    arr[i] = randomNumber;
                    i++;
                }

                j++;
            }

            Console.WriteLine("Total " + j + " random numbers required to generate " + i + " distinct coupon numbers");
            Console.Write("Generated coupon is ");
            foreach (var k in arr)
            {
                Console.Write(coupon[k - 1]);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Function to give current time
        /// </summary>
        /// <returns>returns current time as a long</returns>
        public long Time()
        {
            return Environment.TickCount;             
        }

        /// <summary>
        /// Function for Elapsed time
        /// </summary>
        /// <param name="start">start as a parameter</param>
        /// <param name="stop">stop as a parameter</param>
        /// <returns>Returns difference of start and stop</returns>
        public long ElapsedTime(long start, long stop)
        {
            return stop - start;
        }

        /// <summary>
        /// Convert temperature from Celsius To Fahrenheit
        /// </summary>
        /// <param name="temperature">temperature as a parameter</param>
        /// <returns>Returns temperature in Fahrenheit</returns>
        public double CelsiusToFahrenheit(double temperature)
        {
            return (temperature * 9 / 5) + 32;
        }

        /// <summary>
        /// Convert temperature from Fahrenheit To Celsius 
        /// </summary>
        /// <param name="temperature">temperature as a parameter</param>
        /// <returns>Returns temperature in Celsius</returns>
        public double FahrenheitToCelsius(double temperature)
        {
            return (temperature - 32) * (double)5 / 9;
        }

        /// <summary>
        /// Function to get Monthly Payment
        /// </summary>
        /// <param name="p">p as a parameter</param>
        /// <param name="interest">interest as a parameter</param>
        /// <param name="y">y as a parameter</param>
        /// <returns> returns Monthly Payment</returns>
        public double MonthlyPayments(int p, int interest, int y)
        {
            double n, payments;
            n = 12 * y;
            double r = (double)interest / (12 * 100);
            payments = (p * r) / (1 - Math.Pow(1 + r, -n));
            return payments;
        }

        /// <summary>
        /// Function to calculate square root by Newton's method
        /// </summary>
        /// <param name="c">c as a parameter</param>
        /// <returns>returns square root of given number</returns>
        public double Squareroot(double c)
        {            
            double t = c;           
            while (Math.Abs(t - (c / t)) > Epsilon * t)
            {
                t = ((c / t) + t) / 2;
            }

            return t;
        }      

        /// <summary>
        /// Function to convert binary of decimal
        /// </summary>
        /// <param name="number">decimal number as a parameter</param>
        public void BinaryOf(int number)
        {
            int[] arr = new int[10];
            int i = 0;
            while (number > 0)
            {
                arr[i] = number % 2;
                number = number / 2;
                i++;
            }

            for (int j = i - 1; j >= 0; j--)
            {
                if ((j % 4) - 3 == 0)
                {
                    Console.Write(" ");
                }

                Console.Write(arr[j]);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Function to return binary of decimal
        /// </summary>
        /// <param name="number">decimal number as a parameter</param>
        /// <returns>return array of binary number</returns>
        public int[] DecimalToBinaryArray(int number)
        {
            int[] arr = new int[8];
            int[] arr1 = new int[8];
            int i = 0;
            int len = arr.Length;
            while (number > 0)
            {
                arr[i] = number % 2;
                number = number / 2;
                i++;
            }

            for (int j = i - 1; j >= 0; j--)
            {
                arr1[len - 1 - j] = arr[j];
            }

            return arr1;
        }

        /// <summary>
        /// Function to convert Binary To Decimal
        /// </summary>
        /// <param name="arr">array of binary as a parameter</param>
        /// <returns>returns decimal number</returns>
        public double BinaryToDecimal(int[] arr)
        {
            double number = 0;
            int len = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
               number += arr[len - 1 - i] * Math.Pow(2, i);
            }

            return number;
        }      

        /// <summary>
        /// Function to check whether input is power of two or not
        /// </summary>
        /// <param name="number">number as a parameter</param>
        /// <returns>returns true if number is power of two</returns>
        public bool IsPowerOfTwo(double number)
        {
            if (number == 0)
            {
                return false;
            }

            while (number > 1)
            {
                if (number % 2 != 0)
                {
                    return false;
                }

                number = number / 2;
            }

            return true;
        }

        /// <summary>
        /// Function to swap nibbles in byte
        /// </summary>
        /// <param name="number">decimal number as a parameter</param>
        public void SwapNibbles(int number)
        {
            int[] arr = this.DecimalToBinaryArray(number);
            int mid = arr.Length / 2;
            int[] firstNibble = new int[mid];
            int[] secondNibble = new int[mid];
            for (int i = 0; i < mid; i++)
            {
                firstNibble[i] = arr[i];
                secondNibble[i] = arr[mid + i];
            }

            int length1 = firstNibble.Length;
            int length2 = secondNibble.Length;
            mid = (length1 + length2) / 2;
            int[] arr1 = new int[length1 + length2];
            for (int j = 0; j < mid; j++)
            {
                arr1[j] = secondNibble[j];
                arr1[mid + j] = firstNibble[j];
            }

            Console.Write("Binary of " + number + " is ");
            foreach (int i in arr)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            Console.Write("After swapping nibbles it becomes ");
            foreach (int i in arr1)
            {
                Console.Write(i);
            }

            Console.Write(" which is " + this.BinaryToDecimal(arr1) + " in decimal ");
            if (this.IsPowerOfTwo(this.BinaryToDecimal(arr1)))
            {
                Console.Write("and is power of 2");
            }
            else
            {
                Console.Write("and is not a power of 2");
            }
        }
       
        /// <summary>
        /// Function count fewest notes required
        /// </summary>
        /// <param name="amount">amount as a parameter</param>
        public void FewestNotes(int amount)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int total = 0;
            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    int numberOfNote = amount / notes[i];
                    Console.WriteLine(numberOfNote + " notes needed of " + notes[i]);
                    amount = amount - (notes[i] * numberOfNote);
                    total += numberOfNote;
                }                 
            }

            Console.WriteLine("Total " + total + " notes will need");
        }

        /// <summary>
        /// Function to display day of week
        /// </summary>
        /// <param name="d">date as a parameter</param>
        /// <param name="m">month as a parameter</param>
        /// <param name="y">year as a parameter</param>
        public void DayOfweek(int d, int m, int y)
        {
            double y0 = y - Math.Floor((double)(14 - m) / 12);
            double x = y0 + Math.Floor(y0 / 4) - Math.Floor(y0 / 100) + Math.Floor(y0 / 400);
            double m0 = m + (12 * Math.Floor((double)((14 - m) / 12))) - 2;
            double d0 = Math.Ceiling((d + x + (31 * m0 / 12)) % 7);
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine(days[(int)d0 - 1]);
        }

        ////Functions for TicTacToe game

        /// <summary>
        /// Function to display game in array
        /// </summary>
        /// <param name="str">string array as a parameter</param>
        public void Display(string[] str)
        {
            int k = 0;
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(str[k] + " ");
                    k++;
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Function to check whether human won or not
        /// </summary>
        /// <param name="arr">string array as a parameter</param>
        /// <returns>returns true if human won</returns>
        public bool WinHuman(string[] arr)
        {
            if ((arr[0] == "X" && arr[3] == "X" && arr[6] == "X") || (arr[1] == "X" && arr[4] == "X" && arr[7] == "X")
                || (arr[2] == "X" && arr[5] == "X" && arr[8] == "X") || (arr[0] == "X" && arr[4] == "X" && arr[8] == "X")
                || (arr[2] == "X" && arr[4] == "X" && arr[6] == "X") || (arr[0] == "X" && arr[1] == "X" && arr[2] == "X")
                || (arr[3] == "X" && arr[4] == "X" && arr[5] == "X") || (arr[6] == "X" && arr[7] == "X" && arr[8] == "X"))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Function to check whether computer won or not
        /// </summary>
        /// <param name="arr">string array as a parameter</param>
        /// <returns>returns true if computer won</returns>
        public bool WinComputer(string[] arr)
        {
            if ((arr[0] == "O" && arr[3] == "O" && arr[6] == "O") || (arr[1] == "O" && arr[4] == "O" && arr[7] == "O")
                || (arr[2] == "O" && arr[5] == "O" && arr[8] == "O") || (arr[0] == "O" && arr[4] == "O" && arr[8] == "O")
                || (arr[2] == "O" && arr[4] == "O" && arr[6] == "O") || (arr[0] == "O" && arr[1] == "O" && arr[2] == "O")
                || (arr[3] == "O" && arr[4] == "O" && arr[5] == "O") || (arr[6] == "O" && arr[7] == "O" && arr[8] == "O"))
            {
                return true;
            }

            return false;
        }
    }
}
