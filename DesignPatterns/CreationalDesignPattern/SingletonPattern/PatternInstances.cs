//----------------------------------------------------
// <copyright file="PatternInstances.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.CreationalDesignPattern.SingletonPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// PatternInstances as a class to create instances of patterns
    /// </summary>
    public class PatternInstances
    {
        /// <summary>
        /// Function for eager singleton
        /// </summary>
        public static void EagerInstance()
        {
            ////creating instances of EagerSingleton
            EagerSingleton instanceOne = EagerSingleton.GetInstance();
            EagerSingleton instanceTwo = EagerSingleton.GetInstance();
            EagerSingleton instanceThree = EagerSingleton.GetInstance();

            ////checking if all the instances are same
            if (instanceOne == instanceThree)
            {
                Console.WriteLine("Both instances are same");
                Console.WriteLine("instanceOne hashcode is " + instanceOne.GetHashCode());
                Console.WriteLine("instanceThree hashcode is " + instanceThree.GetHashCode());
            }
        }

        /// <summary>
        /// Function for lazy singleton
        /// </summary>
        public static void LazyInstance()
        {
            ////creating instances of EagerSingleton
            LazySingleton instanceOne = LazySingleton.GetInstance();
            LazySingleton instanceTwo = LazySingleton.GetInstance();

            ////checking if all the instances are same
            if (instanceOne == instanceTwo)
            {
                Console.WriteLine("Both instances are same");
                Console.WriteLine("instanceOne hashcode is " + instanceOne.GetHashCode());
                Console.WriteLine("instanceTwo hashcode is " + instanceTwo.GetHashCode());
            }
        }

        /// <summary>
        /// Function for thread safe
        /// </summary>
        public static void ThreadSafeInstance()
        {
            ////creating instances of EagerSingleton
            ThreadSafeSingleton instanceOne = ThreadSafeSingleton.GetInstance();
            ThreadSafeSingleton instanceTwo = ThreadSafeSingleton.GetInstance();

            ////checking if all the instances are same
            if (instanceOne == instanceTwo)
            {
                Console.WriteLine("Both instances are same");
                Console.WriteLine("instanceOne hashcode is " + instanceOne.GetHashCode());
                Console.WriteLine("instanceTwo hashcode is " + instanceTwo.GetHashCode());
            }
        }

        /// <summary>
        /// Function for BillPugh singleton
        /// </summary>
        public static void BillPughInstance()
        {
            ////creating instances of EagerSingleton
            BillPughSingleton instanceOne = BillPughSingleton.GetInstance();
            BillPughSingleton instanceTwo = BillPughSingleton.GetInstance();

            ////checking if all the instances are same
            if (instanceOne == instanceTwo)
            {
                Console.WriteLine("Both instances are same");
                Console.WriteLine("instanceOne hashcode is " + instanceOne.GetHashCode());
                Console.WriteLine("instanceTwo hashcode is " + instanceTwo.GetHashCode());
            }
        }
    }
}
