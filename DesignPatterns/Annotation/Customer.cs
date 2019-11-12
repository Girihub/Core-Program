//----------------------------------------------------
// <copyright file="Customer.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.Annotation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    /// <summary>
    /// Customer as a class
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// private field customerName
        /// </summary>
        private string customerName;

        /// <summary>
        /// CustomerName to get and set the given field
        /// </summary>
        [Required]
        public string CustomerName
        {
            get
            {
                return this.customerName;
            }

            set
            {
                this.customerName = value;
            }
        }
    }
}
