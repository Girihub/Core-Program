//----------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.StructuralDesignPattern.ProxyPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class RealInternet implements interface IInternet
    /// </summary>
    public class RealInternet : IInternet
    {
        /// <summary>
        /// implementing ConnectTo method from IInternet
        /// </summary>
        /// <param name="serverHost">serverHost as a parameter</param>
        public void ConnectTo(string serverHost)
        {
            Console.WriteLine("Connecting to " + serverHost);
        }
    }
}
