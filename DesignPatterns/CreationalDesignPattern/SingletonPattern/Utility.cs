using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern.SingletonPattern
{
    public class Utility
    {
        public static void GetSingleton()
        {
            Console.WriteLine("1: Eager Singleton");
            Console.WriteLine("2: Lazy Singleton");
            Console.WriteLine("3: Thread Safe Singleton");
            Console.WriteLine("4: Bill Pugh Singleton");

            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    PatternInstances.EagerInstance();
                    break;

                case 2:
                    PatternInstances.LazyInstance();
                    break;

                case 3:
                    PatternInstances.ThreadSafeInstance();
                    break;

                case 4:
                    PatternInstances.BillPughInstance();
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
