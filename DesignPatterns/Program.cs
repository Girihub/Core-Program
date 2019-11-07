using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine();
                    Console.WriteLine("1: Creational Design Pattern");
                    Console.WriteLine("2: Behavioral Design Pattern");
                    Console.WriteLine("3: Structural Design Pattern");
                    Console.WriteLine("0: Exit");
                    string input = Console.ReadLine();
                    if (Regex.IsMatch(input, @"^[0-9]+$"))
                    {
                        int num = Convert.ToInt32(input);
                        switch (num)
                        {
                            case 1:
                                CreationalDesignPattern.Display.DisplayFunction();
                                break;

                            case 2:
                                
                                break;

                            case 3:
                                StructuralDesignPattern.Display.DisplayFunction();
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
