//----------------------------------------------------
// <copyright file="TicTacToe.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Defined class
    /// </summary>
    public class TicTacToe
    {
        /// <summary>
        /// Defined function
        /// </summary>
        public static void TicTacToeFunction()
        {
            Utility utility = new Utility();       
            Random random = new Random();
            string[] str = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int[] arr = { 11, 11, 11, 11, 11, 11, 11, 11, 11 };
            int j = 0;

            utility.Display(str);
            while (j < 9)
            {
                if (utility.WinComputer(str) == true)
                {
                    Console.WriteLine("Computer Won");
                    return;
                }
                else
                {                    
                    Console.WriteLine("Your turn Enter no. for X");
                    int num = Convert.ToInt32(Console.ReadLine());
                    while (utility.Contains(arr, num - 1))
                    {
                        Console.WriteLine("Number is already taken. Enter another number");
                        num = Convert.ToInt32(Console.ReadLine());
                    }

                    str[num - 1] = "X";
                    utility.Display(str);
                    arr[j] = num - 1;
                    j++;
                }

                if (utility.WinHuman(str) == true)
                {
                    Console.WriteLine("You Won");
                    return;
                }
                else if (j == 9)
                {
                    break;
                }
                else
                {
                    bool contain = false;
                    while (contain == false)
                    {
                        int number = random.Next(1, 10);
                        if (!utility.Contains(arr, number - 1))
                        {
                            arr[j] = number - 1;
                            str[number - 1] = "O";                           
                            Console.WriteLine("Computer played " + number);
                            utility.Display(str);
                            j++;
                            contain = true;
                        }
                    }
                }
            }

            Console.WriteLine("Match Draw");           
        }     
    }
}
