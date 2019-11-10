//----------------------------------------------------
// <copyright file="Laptop.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.CreationalDesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class laptop implements interface computer
    /// </summary>
    public class Laptop : Computer
    {
        /// <summary>
        /// private field ram
        /// </summary>
        private string ram;

        /// <summary>
        /// private field
        /// </summary>
        private string hdd;

        /// <summary>
        /// private field
        /// </summary>
        private string cpu;

        /// <summary>
        /// Initializes a new instance of the <see cref="Laptop"/> class.
        /// </summary>
        /// <param name="ram">RAM as a parameter</param>
        /// <param name="hdd">HDD as a parameter</param>
        /// <param name="cpu">CPU as a parameter</param>
        public Laptop(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        /// <summary>
        /// function for CPU
        /// </summary>
        /// <returns>override and returns CPU</returns>
        public override string GetCPU()
        {
            return this.cpu;
        }

        /// <summary>
        /// function for HDD
        /// </summary>
        /// <returns>override and returns HDD</returns>
        public override string GetHDD()
        {
            return this.hdd;
        }

        /// <summary>
        /// function for ram
        /// </summary>
        /// <returns>override and returns ram</returns>
        public override string GetRAM()
        {
            return this.ram;
        }
    }
}
