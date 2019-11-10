//----------------------------------------------------
// <copyright file="Volt.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.StructuralDesignPattern.AdapterPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Volt as a class
    /// </summary>
    public class Volt
    {
        /// <summary>
        /// private field volts
        /// </summary>
        private int volts;

        /// <summary>
        /// Initializes a new instance of the <see cref="Volt"/> class.
        /// </summary>
        /// <param name="volt">returns private field volts</param>
        public Volt(int volt)
        {
            this.volts = volt;
        }

        /// <summary>
        /// Function to get volts value
        /// </summary>
        /// <returns>returns volts value</returns>
        public int GetVolts()
        {
            return this.volts;
        }

        /// <summary>
        /// Function to set the value of the private field volts
        /// </summary>
        /// <param name="volts">volts as a parameter</param>
        public void SetVolts(int volts)
        {
            this.volts = volts;
        }
    }
}
