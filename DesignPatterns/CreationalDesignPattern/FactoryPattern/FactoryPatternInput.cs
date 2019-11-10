//----------------------------------------------------
// <copyright file="FactoryPatternInput.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.CreationalDesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class to execute Factory Pattern
    /// </summary>
    public class FactoryPatternInput
    {
        /// <summary>
        /// FactoryInput as an input
        /// </summary>
        public static void FactoryInput()
        {
            try
            {
                ////create instance of PC, Server, Laptop
                Computer pc = ComputerFactory.createComputer("PC", "4 GB", "HDD 4TB", "Dual Core");
                Computer server = ComputerFactory.createComputer("Server", "8 GB", "Toshiba 500GB", "Pentium");
                Computer laptop = ComputerFactory.createComputer("Laptop", "4 GB", "SATA 1 TB", "Intel Core I5");

                Console.WriteLine("PC Config " + pc.toString());
                Console.WriteLine("Server Config " + server.toString());
                Console.WriteLine("Laptop Config " + laptop.toString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
