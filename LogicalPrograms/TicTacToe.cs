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
            string[] str = {"0","1", "2", "3", "4", "5", "6", "7", "8"};
            int[] arr = {11,11,11,11,11,11,11,11,11 };
            int j = 0;


            while (j < 9)
            {
                if (WinComputer(str) == true)
                {
                    Console.WriteLine("Computer Won");
                    return;
                }
                else
                {
                    Console.WriteLine("Your turn Enter no. for X");
                    int num = Convert.ToInt32(Console.ReadLine());
                    while (utility.contains(arr, num))
                    {
                        Console.WriteLine("Number is already taken. Enter another number");
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                    str[num] = "X";
                    play(str);
                    arr[j] = num;
                    j++;
                }
                if (WinHuman(str) == true)
                {
                    Console.WriteLine("You Won");
                    return;
                }
                else
                {
                    bool a = false;
                    while (a == false)
                    {
                        int number = random.Next(0, 9);
                        if (!utility.contains(arr, number)){
                            arr[j] = number;
                            str[number] = "O";                           
                            Console.WriteLine("Computer played " + number);
                            play(str);
                            j++;
                            a = true;
                        }
                    }
                }
            }

            Console.WriteLine("Match Draw");
               
            
        } 
        
        public static void play(string[] str)
        {
            int k = 0;
            for(int i = 0; i <= 2; i++)
            {
                for(int j = 0; j <= 2; j++)
                {
                    Console.Write(str[k]+" ");
                    k++;
                }
                Console.WriteLine();
            }
        }

        public static bool WinHuman(string[] arr)
        {
            if((arr[0]=="X"&&arr[3]=="X"&&arr[6]=="X")||(arr[1] == "X" && arr[4] == "X" && arr[7] == "X")
                ||(arr[2] == "X" && arr[5] == "X" && arr[8] == "X")|| (arr[0] == "X" && arr[4] == "X" && arr[8] == "X")
                ||(arr[2] == "X" && arr[4] == "X" && arr[6] == "X") || (arr[0] == "X" && arr[1] == "X" && arr[2] == "X")
                || (arr[3] == "X" && arr[4] == "X" && arr[5] == "X") || (arr[6] == "X" && arr[7] == "X" && arr[8] == "X"))
            {
                return true;
            }
            return false;
        }

        public static bool WinComputer(string[] arr)
        {
            if ((arr[0] == "O" && arr[3] == "O" && arr[6] == "O") || (arr[1] == "O" && arr[4] == "O" && arr[7] == "O")
                || (arr[2] == "O" && arr[5] == "O" && arr[8] == "O") || (arr[0] == "O" && arr[4] == "O" && arr[8] == "O")
                || (arr[2] == "O" && arr[4] == "O" && arr[6] == "O")|| (arr[0] == "O" && arr[1] == "O" && arr[2] == "O")
                || (arr[3] == "O" && arr[4] == "O" && arr[5] == "O")|| (arr[6] == "O" && arr[7] == "O" && arr[8] == "O"))
            {
                return true;
            }
            return false;
        }
    }
}
