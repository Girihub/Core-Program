//----------------------------------------------------
// <copyright file="BillPughSingleton.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.CreationalDesignPattern.SingletonPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BillPughSingleton as a class
    /// </summary>
    public class BillPughSingleton
    {
        /// <summary>
        /// initialize private field counter
        /// </summary>
        private static int counter = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="BillPughSingleton"/> class.
        /// </summary>
        private BillPughSingleton()
        {
            counter++;
            Console.WriteLine("This is Bill Pugh Singleton. Counter value is " + counter);
        }        

        /// <summary>
        /// Function to return instance of BillPughSingleton
        /// </summary>
        /// <returns>return instance of BillPughSingleton</returns>
        public static BillPughSingleton GetInstance()
        {
            return SingletonHelper.Instance;
        }

        /// <summary>
        /// class to create instance of BillPughSingleton
        /// </summary>
        private static class SingletonHelper
        {
            /// <summary>
            /// class to create instance of BillPughSingleton
            /// </summary>
            public static BillPughSingleton Instance = new BillPughSingleton();
        }
    }
}
