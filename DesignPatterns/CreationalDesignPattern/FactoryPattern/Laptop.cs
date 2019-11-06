﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern.FactoryPattern
{
    class Laptop:Computer
    {
        private string ram;
        private string hdd;
        private string cpu;

        public Laptop(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        public override string getCPU()
        {
            return this.cpu;
        }

        public override string getHDD()
        {
            return this.hdd;
        }

        public override string getRAM()
        {
            return this.ram;
        }
    }
}
