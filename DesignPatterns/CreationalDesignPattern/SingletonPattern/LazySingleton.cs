//----------------------------------------------------
// <copyright file="LazySingleton.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.CreationalDesignPattern.SingletonPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// LazySingleton as a class
    /// </summary>
    public class LazySingleton
    {
        /// <summary>
        /// private instance set to null
        /// </summary>
        private static LazySingleton instance = null;

        /// <summary>
        /// counter as a private field
        /// </summary>
        private static int counter = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="LazySingleton"/> class.
        /// </summary>
        /// 
        private LazySingleton()
        {
            counter++;
            Console.WriteLine("This is LazySingleton Constructor. Counter is " + counter);
        }

        /// <summary>
        /// Method to return instance
        /// </summary>
        /// <returns>returns instance</returns>
        public static LazySingleton GetInstance()
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
