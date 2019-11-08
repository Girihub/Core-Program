using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern
{
    public class Display
    {
        public static void DisplayFunction()
        {
            try
            {
                Console.WriteLine("1: Adapter Pattern");
                Console.WriteLine("2: Facade Pattern");
                Console.WriteLine("3: Proxy Pattern");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AdapterPattern.AdapterPatternTest adapterPatternTest = new AdapterPattern.AdapterPatternTest();
                        adapterPatternTest.AdapterPatternFunction();
                        break;

                    case 2:
                        FacadePattern.FacadePatternTest facadePattern = new FacadePattern.FacadePatternTest();
                        facadePattern.FacadeTest();
                        break;

                    case 3:
                        ProxyPattern.ProxyTest proxyTest = new ProxyPattern.ProxyTest();
                        proxyTest.ProxyTestFunction();
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
