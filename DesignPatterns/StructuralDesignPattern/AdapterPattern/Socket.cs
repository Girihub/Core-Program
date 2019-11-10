//----------------------------------------------------
// <copyright file="Socket.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.StructuralDesignPattern.AdapterPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Socket as a class
    /// </summary>
    public class Socket
    {
        /// <summary>
        /// Function to get new volt instance
        /// </summary>
        /// <returns>returns volt instance</returns>
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }

    /// <summary>
    /// ISocketAdapter as an interface
    /// </summary>
    internal interface ISocketAdapter
    {
        /// <summary>
        /// Function to return new Volt
        /// </summary>
        /// <returns>returns volt convert into 120</returns>
        Volt Get120Volt();

        /// <summary>
        /// Function to return new Volt
        /// </summary>
        /// <returns>returns volt convert into 12</returns>
        Volt Get12Volt();

        /// <summary>
        /// Function to return new Volt
        /// </summary>
        /// <returns>returns volt convert into 3</returns>
        Volt Get3Volt();
    }
}
