using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern
{
    public class Display
    {
        public static void DisplayFunction()
        {
            Console.WriteLine("1: Singleton Patteen");
            Console.WriteLine("2: Factory Patteen");
            Console.WriteLine("3: Prototype Patteen");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    SingletonPattern.Utility.GetSingleton();
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
