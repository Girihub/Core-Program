//----------------------------------------------------
// <copyright file="UtilityFunctions.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure
{    
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using DataStructure.Utility;    

    /// <summary>
    /// UtilityFunctions as a function which contains all some functions of programs
    /// </summary>
    public class UtilityFunctions
    {
        /// <summary>
        /// Function to check if the given string is palindrome or not
        /// </summary>
        /// <param name="input">input, to be checked, as a parameter</param>
        /// <returns>returns true if the input is palindrome</returns>
        public bool PalindromCheck(string input)
        {
            Deque deque = new Deque();
            string temp = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                deque.AddFront(input[i]);                
            }

            while (!deque.IsEmpty())
            {
                temp += deque.RemoveFront();
            }

            if (temp == input)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Function to display elements in hash
        /// </summary>
        /// <param name="hash">hash array as parameter</param>
        /// <param name="path">path of the file as a parameter</param>
         public void DispalyHash(Hash[] hash, string path)
        {
            StreamReader file = new StreamReader(path, Encoding.UTF8);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] numbers = line.Split(',', ' ');
                for (int i = 0; i < numbers.Length; i++)
                {
                    int number = Convert.ToInt32(numbers[i]);
                    int remainder = number % hash.Length;
                    hash[remainder].Add(number);
                }
            }

            string end = file.ReadToEnd();
            file.Close();
            for (int i = 0; i < hash.Length; i++)
            {
                hash[i].Show();
            }
        }

        /// <summary>
        /// Function to delete element from the hash
        /// </summary>
        /// <param name="input">input , to be deleted, as a parameter</param>
        /// <param name="hash">hash as a parameter</param>
        public void DeleteFromFile(int input, Hash hash)
        {
            hash.Remove(input);
            string changeFile = File.ReadAllText(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\HashNumbers.txt", Encoding.UTF8);
            changeFile = changeFile.Replace(input + string.Empty, "0");
            File.WriteAllText(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\HashNumbers.txt", changeFile);
        }

        /// <summary>
        /// Function to insert element in the hash
        /// </summary>
        /// <param name="input">input element as a parameter</param>
        /// <param name="hash">hash element as a parameter</param>
        /// <param name="path">path element as a parameter</param>
        public void InsertInFile(int input, Hash[] hash, string path)
        {
            int remainder = input % hash.Length;
            hash[remainder].Add(input);
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(input);
            }
        }

        /// <summary>
        /// Function to check if the given input number is prime
        /// </summary>
        /// <param name="input">integer input as a parameter</param>
        /// <returns>returns true if the given number is prime</returns>
        public bool IsPrime(int input)
        {
            if (input == 2)
            {
                return true;
            }

            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }

            return input > 1;
        }

        /// <summary>
        /// Function to check if two input strings are anagram
        /// </summary>
        /// <param name="stringOne">stringOne as a parameter</param>
        /// <param name="stringTwo">stringTwo as a parameter</param>
        /// <returns>Returns true if the strings are anagram</returns>
        public bool IsAnagram(string stringOne, string stringTwo)
        {
            if (stringOne.Length != stringTwo.Length)
            {
                return false;
            }

            char[] stringOneArray = stringOne.ToLower().ToCharArray();
            char[] stringTwoArray = stringTwo.ToLower().ToCharArray();
            Array.Sort(stringOneArray);
            Array.Sort(stringTwoArray);
            for (int i = 0; i < stringOneArray.Length; i++)
            {
                if (stringOneArray[i] != stringTwoArray[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Function to return day of week
        /// </summary>
        /// <param name="d">day as a parameter</param>
        /// <param name="m">month as a parameter</param>
        /// <param name="y">year as a parameter</param>
        /// <returns>return day number</returns>
        public int DayOfweek(int d, int m, int y)
        {
            double y0 = y - Math.Floor((double)(14 - m) / 12);
            double x = y0 + Math.Floor(y0 / 4) - Math.Floor(y0 / 100) + Math.Floor(y0 / 400);
            double m0 = m + (12 * Math.Floor((double)((14 - m) / 12))) - 2;
            double d0 = Math.Ceiling((d + x + (31 * m0 / 12)) % 7);            
            return (int)d0;
        }

        /// <summary>
        /// Function to check if given year is leap
        /// </summary>
        /// <param name="year">year as a parameter</param>
        /// <returns>returns true if year is leap</returns>
        public bool Leap(int year)
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Function to return end date of month
        /// </summary>
        /// <param name="month">month as a parameter</param>
        /// <param name="year">year as a parameter</param>
        /// <returns>returns end date of month</returns>
        public int EndDate(int month, int year)
        {
            if (month == 2 && this.Leap(year))
            {
                return 29;
            }

            if (month == 2)
            {
                return 28;
            }

            if (month % 2 == 0 && month < 8)
            {
                return 30;
            }

            if (month % 2 != 0 && month > 8)
            {
                return 30;
            }

            return 31;
        }
    }    
}
