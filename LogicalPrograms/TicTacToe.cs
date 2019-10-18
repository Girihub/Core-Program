using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LogicalPrograms
{
    public class TicTacToe
    {
        public static void TicTacToeFunction()
        {
            Utility utility = new Utility();       
            Random random = new Random();
            string[] arr = {"1","1","1","1","1","1","1","1","1" };
            //int[] arr1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, };
            int[] arr2 = new int[arr.Length];
            int y = 0;
            while (y < 9 )
            {

                bool done = false;
                while (!done)
                {
                    int num = random.Next(0, 9);
                    if (!utility.contains(arr2, num))
                    {
                        arr2[y] = num;
                        arr[num] = "O";
                        y++;
                        done = true;
                        Console.WriteLine("Computer played " + num);
                        play(arr);
                    }
                }
                if (isWinC(arr))
                {
                    Console.WriteLine("Computer Wins");
                    return;
                }
                Console.WriteLine("Enter number for X");
                int input = Convert.ToInt32(Console.ReadLine());
                while (utility.contains(arr2, input))
                {
                    Console.WriteLine("Already taken. Enter another digit");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                arr2[y] = input;
                arr[input] = "X";
                y++;
                play(arr);
                if (isWinH(arr))
                {
                    Console.WriteLine("You Won");
                    return;
                }
              
            }
            Console.WriteLine("Match Draw");


        }

        public static void play(string[] arr)
        {
           foreach(string i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }

       

        public static bool isWinH(string[] arr)
        {
            if (((arr[0] = arr[3] = arr[6]) == "X") || ((arr[1] = arr[4] = arr[7]) == "X") ||
                ((arr[2] = arr[5] = arr[8]) == "X") || ((arr[0] = arr[4] = arr[8]) == "X") ||
                ((arr[2] = arr[4] = arr[6]) == "X"))
            {
                return true;
            }
            return false;
            
        }
        public static bool isWinC(string[] arr)
        {
            if (((arr[0] = arr[3] = arr[6]) == "O") || ((arr[1] = arr[4] = arr[7]) == "O") ||
                ((arr[2] = arr[5] = arr[8]) == "O") || ((arr[0] = arr[4] = arr[8]) == "O") ||
                ((arr[2] = arr[4] = arr[6]) == "O"))
            {
                return true;
            }
            return false;
        }

       
    }
}
