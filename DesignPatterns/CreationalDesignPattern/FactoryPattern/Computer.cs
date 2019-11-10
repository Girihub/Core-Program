//----------------------------------------------------
// <copyright file="Computer.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.CreationalDesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Computer as a class
    /// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// function to return RAM information
        /// </summary>
        /// <returns>returns RAM information</returns>
        public abstract string GetRAM();

        /// <summary>
        /// function to return Hard Disk Drive information
        /// </summary>
        /// <returns>returns Hard Disk Drive information</returns>
        public abstract string GetHDD();

        /// <summary>
        /// function to return CPU information
        /// </summary>
        /// <returns>returns CPU information</returns>
        public abstract string GetCPU();

        /// <summary>
        /// Function to return computer information
        /// </summary>
        /// <returns>return computer information</returns>
        public string toString()
        {
            return "RAM " + this.GetRAM() + ", HDD " + this.GetHDD() + ", CPU " + this.GetCPU();
        }
    }
}
