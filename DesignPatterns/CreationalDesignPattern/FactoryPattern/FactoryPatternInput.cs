using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern.FactoryPattern
{
    public class FactoryPatternInput
    {
        public static void FactoryInput()
        {
            try
            {
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
