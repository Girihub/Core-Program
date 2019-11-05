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

        /// <summary>
        /// Private constructor
        /// </summary>
        private LazySingleton()
        {
            Console.WriteLine("This is LazySingleton Constructor");
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
