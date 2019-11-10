//----------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.CreationalDesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ComputerFactory as a class
    /// </summary>
    public class ComputerFactory
    {
        /// <summary>
        /// Function to create computer
        /// </summary>
        /// <param name="type">type of computer as a parameter</param>
        /// <param name="ram">RAM of computer as a parameter</param>
        /// <param name="hdd">HDD of computer as a parameter</param>
        /// <param name="cpu">CPU of computer as a parameter</param>
        /// <returns>returns computer with specification</returns>
        public static Computer CreateComputer(string type, string ram, string hdd, string cpu)
        {
            switch (type)
            {
                case "PC":
                    return new PC(ram, hdd, cpu);                    

                case "Server":
                    return new Server(ram, hdd, cpu);

                case "Laptop":
                    return new Laptop(ram, hdd, cpu);

                default:
                    throw new ArgumentException("Invalid type", "type");                    
            }            
        }
    }
}
