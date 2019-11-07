using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern
{
    public class Display
    {
        public static void DisplayFunction()
        {
            Console.WriteLine("1: Adapter Patteen");
            Console.WriteLine("2:  Patteen");
            Console.WriteLine("3:  Patteen");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    AdapterPattern.AdapterPatternTest adapterPatternTest = new AdapterPattern.AdapterPatternTest();
                    adapterPatternTest.AdapterPatternFunction();
                    break;

                case 2:
                   
                    break;

                case 3:
                    
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
