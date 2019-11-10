//----------------------------------------------------
// <copyright file="ThreadSafeSingleton.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.CreationalDesignPattern.SingletonPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ThreadSafeSingleton as a class
    /// </summary>
    public class ThreadSafeSingleton
    {
        /// <summary>
        /// private field counter
        /// </summary>
        private static int counter = 0;

        /// <summary>
        /// private readonly object
        /// </summary>
        private static readonly object PadLock = new object();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadSafeSingleton"/> class.
        /// </summary>
        private ThreadSafeSingleton()
        {
            counter++;
            Console.WriteLine("This is Thread Safe Singleton.Counter value is " + counter);
        }

        /// <summary>
        /// set instance to null first
        /// </summary>
        private static ThreadSafeSingleton instance = null;

        /// <summary>
        /// Function to create instance of class
        /// </summary>
        /// <returns>returns instance of class</returns>
        public static ThreadSafeSingleton GetInstance()
        {
            if (instance == null)
            {
                lock (PadLock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                }
            }

            return instance;
        }
    }
}
