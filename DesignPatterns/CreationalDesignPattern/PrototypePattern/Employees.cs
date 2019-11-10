//----------------------------------------------------
// <copyright file="Employees.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.CreationalDesignPattern.PrototypePattern
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Employees implements interface
    /// </summary>
    public class Employees : ICloneable
    {
        /// <summary>
        /// private field employeeList
        /// </summary>
        private List<string> employeeList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employees"/> class.
        /// </summary>
        public Employees()
        {
            this.employeeList = new ArrayList<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employees"/> class.
        /// </summary>
        /// <param name="list">list as  a parameter</param>
        public Employees(List<string> list)
        {
            this.employeeList = list;
        }

        /// <summary>
        /// Function to add data in list
        /// </summary>
        public void AddData()
        {
            this.employeeList.Add("Giri");
            this.employeeList.Add("Ankush");
            this.employeeList.Add("Shekhar");
            this.employeeList.Add("Chetan");
        }

        /// <summary>
        /// function to return employee list
        /// </summary>
        /// <returns>returns employee list</returns>
        public List<string> GetData()
        {
            return this.employeeList;
        }

        /// <summary>
        /// function to create clone
        /// </summary>
        /// <returns>returns cloned object</returns>
        public object Clone()
        {
            ////initialize list for clone
            List<string> employeeClone = new ArrayList<string>();
            foreach (string data in this.GetData())
            {
                employeeClone.Add(data);
            }

            return new Employees(employeeClone);
        }
    }
}
