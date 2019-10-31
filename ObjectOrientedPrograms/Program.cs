//----------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
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
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("1: AddressBook");
                Console.WriteLine("2: InventoryDataManagement");
                Console.WriteLine("0: Exit");
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^[0-9]+$"))
                {
                    int num = Convert.ToInt32(input);
                    switch (num)
                    {
                        case 1:
                            AddressBook.AddressBook.AddressBookFunction();
                            break;

                        case 2:
                            InventoryDataManagement.InventoryDataManagement.InventoryDataManagementFunction();
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
