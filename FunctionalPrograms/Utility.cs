﻿//----------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Utility class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// function to replace string
        /// </summary>
        /// <param name="input">input as a parameter</param>
        public void ReplaceString(string input)
        {
            string str = "Hello <<UserName>>, How are you?";
            while (input.Length < 3)
            {
                Console.WriteLine("Name should contains atleast 3 chars");
                input = Console.ReadLine();      
            }

            str = str.Replace("<<UserName>>", input);
            Console.WriteLine(str);     
        }

        /// <summary>
        /// Flipping the coin
        /// </summary>
        /// <param name="input">input as a parameter</param>
        public void Flipcoin(int input)
        {
            int heads = 0, tails = 0;
            Random random = new Random();
            for (int i = 1; i <= input; i++)
            {
                double number = random.NextDouble();
                if (number < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }

            double headPercent = ((double)heads / input) * 100;
            double tailPercent = ((double)tails / input) * 100;
            Console.WriteLine("Percentage of Head vs Tail is " + headPercent + "% to " + tailPercent + "%");
        }

        /// <summary>
        /// Checking the leap year
        /// </summary>
        /// <param name="year">year as an input</param>
        /// <returns>Returns true if year is leap</returns>
        public bool Leap(int year)
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Power of 2
        /// </summary>
        /// <param name="num">number as an input</param>
        public void PowerOf2(int num)
        {
            int sum = 2;
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("2^" + i + "= " + sum);
                sum *= 2;
            }
        }

        /// <summary>
        /// Harmonic value of number
        /// </summary>
        /// <param name="num">number as parameter</param>
        /// <returns>returns harmonic value of number</returns>
        public double Harmonic(int num)
        {
            double sum = 0;
            for (double i = 1; i <= num; i++)
            {
                sum += 1 / i;
            }

            return sum;
        }

        /// <summary>
        /// Find prime factors by Brute Force
        /// </summary>
        /// <param name="num">number as a parameter</param>
        public void PrimeFactors(int num)
        {
            for (int i = 2; i * i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i);
                    num = num / i;
                }
            }

            if (num > 2)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Print two dimension array
        /// </summary>
        /// <param name="rows">rows as a parameter</param>
        /// <param name="columns">columns as a parameter</param>
        public void TwoDimensionArray(int rows, int columns)
        {
            int[,] array = new int[rows, columns];
            Console.WriteLine("Enter " + (rows * columns) + " values of array");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
