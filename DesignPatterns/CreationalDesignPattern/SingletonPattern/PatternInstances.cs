﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern.SingletonPattern
{
    public class PatternInstances
    {
        public static void EagerInstance()
        {
            EagerSingleton instanceOne = EagerSingleton.getInstance();
            EagerSingleton instanceTwo = EagerSingleton.getInstance();
            EagerSingleton instanceThree = EagerSingleton.getInstance();

            if(instanceOne == instanceThree)
            {
                Console.WriteLine("Both instances are same");
                Console.WriteLine("instanceOne hashcode is " + instanceOne.GetHashCode());
                Console.WriteLine("instanceThree hashcode is " + instanceThree.GetHashCode());
            }
        }

        public static void LazyInstance()
        {
            LazySingleton instanceOne = LazySingleton.getInstance();
            LazySingleton instanceTwo = LazySingleton.getInstance();

            if (instanceOne == instanceTwo)
            {
                Console.WriteLine("Both instances are same");
                Console.WriteLine("instanceOne hashcode is " + instanceOne.GetHashCode());
                Console.WriteLine("instanceTwo hashcode is " + instanceTwo.GetHashCode());
            }
        }

        public static void ThreadSafeInstance()
        {
            ThreadSafeSingleton instanceOne = ThreadSafeSingleton.GetInstance();
            ThreadSafeSingleton instanceTwo = ThreadSafeSingleton.GetInstance();

            if (instanceOne == instanceTwo)
            {
                Console.WriteLine("Both instances are same");
                Console.WriteLine("instanceOne hashcode is " + instanceOne.GetHashCode());
                Console.WriteLine("instanceTwo hashcode is " + instanceTwo.GetHashCode());
            }
        }

        public static void BillPughInstance()
        {
            BillPughSingleton instanceOne = BillPughSingleton.GetInstance();
            BillPughSingleton instanceTwo = BillPughSingleton.GetInstance();

            if (instanceOne == instanceTwo)
            {
                Console.WriteLine("Both instances are same");
                Console.WriteLine("instanceOne hashcode is " + instanceOne.GetHashCode());
                Console.WriteLine("instanceTwo hashcode is " + instanceTwo.GetHashCode());
            }
        }
    }
}
