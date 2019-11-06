using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern.SingletonPattern
{
    public class LazySingleton
    {
        /// <summary>
        /// private instance set to null
        /// </summary>
        private static LazySingleton instance = null;
        private static int counter = 0;
        /// <summary>
        /// Private constructor
        /// </summary>
        private LazySingleton()
        {
            counter++;
            Console.WriteLine("This is LazySingleton Constructor. Counter is " + counter);
        }

        /// <summary>
        /// Method to return instance
        /// </summary>
        /// <returns>returns instance</returns>
        public static LazySingleton getInstance()
        {
            ////if instance is null, initialize
            if (instance == null)
            {
                instance = new LazySingleton();
            }
            return instance;
        }
    }
}
