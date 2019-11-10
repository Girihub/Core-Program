//----------------------------------------------------
// <copyright file="EagerSingleton.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.CreationalDesignPattern.SingletonPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// EagerSingleton as a class
    /// </summary>
    public class EagerSingleton
    {
        /// <summary>
        /// instance initialized when loading the class
        /// </summary>
        private static EagerSingleton instance = new EagerSingleton();

        /// <summary>
        /// counter as a private field
        /// </summary>
        private static int counter = 0;
       
        /// <summary>
        /// Initializes a new instance of the <see cref="EagerSingleton"/> class.
        /// </summary>        
        private EagerSingleton()
        {
            counter++;
            Console.WriteLine("This is EagerSingleton Constructor. Counter is " + counter);
        }

        /// <summary>
        /// Method to return instance
        /// </summary>
        /// <returns>returns instance</returns>
        public static EagerSingleton GetInstance()
        {
            return instance;
        }
    }
}
