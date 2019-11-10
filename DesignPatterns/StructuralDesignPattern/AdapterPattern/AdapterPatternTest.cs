//----------------------------------------------------
// <copyright file="AdapterPatternTest.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.StructuralDesignPattern.AdapterPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// AdapterPatternTest as a class
    /// </summary>
    public class AdapterPatternTest
    {
        /// <summary>
        /// Function to execute Adapter Pattern
        /// </summary>
        public void AdapterPatternFunction()
        {
            this.ClassAdapterTest();
            this.ObjectAdapterTest();
        }

        /// <summary>
        /// Adapter pattern by Object approach
        /// </summary>
        private void ObjectAdapterTest()
        {
            ISocketAdapter socketAdapter = new SocketClassAdapter();
            Volt v3 = this.GetVolt(socketAdapter, 3);
            Volt v12 = this.GetVolt(socketAdapter, 12);
            Volt v120 = this.GetVolt(socketAdapter, 120);
            Console.WriteLine("v3 volts using Object Adapter is " + v3.GetVolts());
            Console.WriteLine("v12 volts using Object Adapter is " + v12.GetVolts());
            Console.WriteLine("v120 volts using Object Adapter is " + v120.GetVolts());
        }

        /// <summary>
        /// Adapter pattern by Class approach
        /// </summary>
        private void ClassAdapterTest()
        {
            ISocketAdapter socketAdapter = new SocketObjectAdapter();
            Volt v3 = this.GetVolt(socketAdapter, 3);
            Volt v12 = this.GetVolt(socketAdapter, 12);
            Volt v120 = this.GetVolt(socketAdapter, 120);
            Console.WriteLine("v3 volts using Object Adapter is " + v3.GetVolts());
            Console.WriteLine("v12 volts using Object Adapter is " + v12.GetVolts());
            Console.WriteLine("v120 volts using Object Adapter is " + v120.GetVolts());
        }

        /// <summary>
        /// Private function to get volt
        /// </summary>
        /// <param name="socketAdapter">socketAdapter as a parameter</param>
        /// <param name="v">v as a parameter</param>
        /// <returns>returns volt as per user input</returns>
        private Volt GetVolt(ISocketAdapter socketAdapter, int v)
        {
            switch (v)
            {
                case 3:
                    return socketAdapter.Get3Volt();

                case 12:
                    return socketAdapter.Get12Volt();

                case 120:
                    return socketAdapter.Get120Volt();

                default:
                    return socketAdapter.Get120Volt();
            }
        }
    }
}
