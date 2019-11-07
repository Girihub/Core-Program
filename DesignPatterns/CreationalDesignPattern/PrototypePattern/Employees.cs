using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPattern.PrototypePattern
{
    public class Employees : ICloneable
    {
        private List<string> employeeList;

        public Employees()
        {
            this.employeeList = new ArrayList<string>();
        }

        public Employees(List<string> list)
        {
            this.employeeList = list;
        }

        public void AddData()
        {
            this.employeeList.Add("Giri");
            this.employeeList.Add("Ankush");
            this.employeeList.Add("Shekhar");
            this.employeeList.Add("Chetan");
        }

        public List<string> GetData()
        {
            return this.employeeList;
        }

        public object Clone()
        {
            List<string> employeeClone = new ArrayList<string>();
            foreach(string data in this.GetData())
            {
                employeeClone.Add(data);
            }

            return new Employees(employeeClone);
        }
    }
}
