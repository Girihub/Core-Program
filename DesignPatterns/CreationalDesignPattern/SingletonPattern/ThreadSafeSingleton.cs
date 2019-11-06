using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern.SingletonPattern
{
    public class ThreadSafeSingleton
    {
        private static int counter = 0;
        private static readonly object padLock = new object();

        private ThreadSafeSingleton()
        {
            counter++;
            Console.WriteLine("This is Thread Safe Singleton.Counter value is " + counter);
        }

        private static ThreadSafeSingleton instance = null;

        public static ThreadSafeSingleton GetInstance()
        {
            if(instance == null)
            {
                lock (padLock)
                {
                    if(instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                }
            }
            return instance;
        }
    }
}
