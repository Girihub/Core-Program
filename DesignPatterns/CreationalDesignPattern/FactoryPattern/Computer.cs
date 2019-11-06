using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern.FactoryPattern
{
    public abstract class Computer
    {
        public abstract string getRAM();
        public abstract string getHDD();
        public abstract string getCPU();

        public string toString()
        {
            return "RAM " + this.getRAM() + ", HDD " + this.getHDD() + ", CPU " + getCPU();
        }
    }
}
