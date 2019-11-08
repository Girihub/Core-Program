using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern
{
    public class Display
    {
        public static void DisplayFunction()
        {
            try
            {
                Console.WriteLine("1: Observer Patteen");
                Console.WriteLine("2: Visitor Patteen");
                Console.WriteLine("3: Mediator Patteen");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ObserverPattern.ObserverTest observerTest = new ObserverPattern.ObserverTest();
                        observerTest.ObserverFunction();
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
