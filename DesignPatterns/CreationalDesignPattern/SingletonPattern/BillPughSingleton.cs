using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern.SingletonPattern
{
    public class BillPughSingleton
    {
        private static int counter = 0;

        private BillPughSingleton()
        {
            counter++;
            Console.WriteLine("This is Bill Pugh Singleton. Counter value is " + counter);
        }

        private static class SingletonHelper
        {
            public static BillPughSingleton Instance = new BillPughSingleton();
        }

        public static BillPughSingleton GetInstance()
        {
            return SingletonHelper.Instance;
        }
    }
}
