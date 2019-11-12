//----------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Program as a class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// main function
        /// </summary>
        /// <param name="args">args as a parameter</param>
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
                    Console.WriteLine("4: Annoatation");
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
                                BehavioralDesignPattern.Display.DisplayFunction();
                                break;

                            case 3:
                                StructuralDesignPattern.Display.DisplayFunction();
                                break;

                            case 4:
                                Annotation.AnnoatationTest.AnnoatationFunction();
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
