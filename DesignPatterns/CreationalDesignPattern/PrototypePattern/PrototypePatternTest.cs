//----------------------------------------------------
// <copyright file="PrototypePatternTest.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.CreationalDesignPattern.PrototypePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// PrototypePatternTest as a class
    /// </summary>
    public class PrototypePatternTest
    {
        /// <summary>
        /// Function for Prototype Patterns
        /// </summary>
        public static void PrototypeFunction()
        {
            try
            {
                ////create instance of Employees
                Employees employees = new Employees();
                employees.AddData();

                ////cloning Employees
                Employees employeeOne = (Employees)employees.Clone();
                Employees employeeTwo = (Employees)employees.Clone();

                List<string> listOne = employeeOne.GetData();
                List<string> listTwo = employeeTwo.GetData();

                listOne.Add("Vishal");
                listTwo.Remove("Ankush");

                Console.WriteLine("*********Employee List*********");
                foreach (string data in employees.GetData())
                {
                    Console.Write(data + " ");
                }

                Console.WriteLine("\n *********Cloned One Employee List*********");
                foreach (string data in listOne)
                {
                    Console.Write(data + " ");
                }

                Console.WriteLine("\n *********Cloned Two Employee List*********");
                foreach (string data in listTwo)
                {
                    Console.Write(data + " ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
