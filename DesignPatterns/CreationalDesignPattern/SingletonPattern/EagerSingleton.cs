using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern.SingletonPattern
{
    public class EagerSingleton
    {
        /// <summary>
        /// instance initialized when loading the class
        /// </summary>
        private static EagerSingleton instance = new EagerSingleton();
        private static int counter = 0;
        /// <summary>
        /// Private Constructor
        /// </summary>
        private EagerSingleton()
        {
            counter++;
            Console.WriteLine("This is EagerSingleton Constructor. Counter is " + counter);
        }

        /// <summary>
        /// Methode to return instance
        /// </summary>
        /// <returns>returns instance</returns>
        public static EagerSingleton getInstance()
        {
            return instance;
        }
    }
}
