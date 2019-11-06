using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern.FactoryPattern
{
    public class ComputerFactory
    {
        public static Computer createComputer(string type, string ram, string hdd, string cpu)
        {
            switch (type)
            {
                case "PC":
                    return new PC(ram,hdd,cpu);                    

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
