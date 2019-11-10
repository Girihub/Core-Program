//----------------------------------------------------
// <copyright file="PC.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.CreationalDesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class PC implements interface Computer
    /// </summary>
    public class PC : Computer
    {
        /// <summary>
        /// private field for RAM
        /// </summary>
        private string ram;

        /// <summary>
        /// private field for HDD
        /// </summary>
        private string hdd;

        /// <summary>
        /// private field for CPU
        /// </summary>
        private string cpu;

        /// <summary>
        /// Initializes a new instance of the <see cref="PC"/> class.
        /// </summary>
        /// <param name="ram">RAM as a parameter</param>
        /// <param name="hdd">HDD as a parameter</param>
        /// <param name="cpu">CPU as a parameter</param>
        public PC(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
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
        /// function for CPU
        /// </summary>
        /// <returns>override and returns CPU</returns>
        public override string GetCPU()
        {
            return this.cpu;
        }

        /// <summary>
        /// function for RAM
        /// </summary>
        /// <returns>override and returns RAM</returns>
        public override string GetRAM()
        {
            return this.ram;
        }
    }
}
