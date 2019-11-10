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
    /// ProxyTest as a class
    /// </summary>
    public class ProxyTest
    {
        /// <summary>
        /// Function to execuet Proxy Pattern
        /// </summary>
        public void ProxyTestFunction()
        {
            try
            {
                ////create instance of ProxyInternet
                IInternet internet = new ProxyInternet();
                internet.ConnectTo("bridgelabz.com");
                internet.ConnectTo("yyy.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
