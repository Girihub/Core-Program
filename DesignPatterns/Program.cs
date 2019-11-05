using System;
using System.Text.RegularExpressions;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("1: ");
                Console.WriteLine("0: Exit");
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^[0-9]+$"))
                {
                    int num = Convert.ToInt32(input);
                    switch (num)
                    {
                        case 1:                            
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
