using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern.PrototypePattern
{
    public class PrototypePatternTest
    {
        public static void PrototypeFunction()
        {
            try
            {
                Employees employees = new Employees();
                employees.AddData();

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
                foreach(string data in listOne)
                {
                    Console.Write(data + " ");
                }

                Console.WriteLine("\n *********Cloned Two Employee List*********");
                foreach(string data in listTwo)
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
