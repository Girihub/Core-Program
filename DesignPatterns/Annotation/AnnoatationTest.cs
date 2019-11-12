//----------------------------------------------------
// <copyright file="AnnoatationTest.cs" company="Bridgelabz">
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
    /// Annotation class
    /// </summary>
    public class AnnoatationTest
    {
        /// <summary>
        /// Annotation function
        /// </summary>
        public static void AnnoatationFunction()
        {
            ////Create object of Customer
            Customer customer = new Customer();
            customer.CustomerName = string.Empty;

            var context = new ValidationContext(customer, null, null);
            var result = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(customer, context, result, true);
            foreach (var error in result)
            {
                Console.WriteLine(error.ErrorMessage);
            }

            Console.WriteLine(isValid);
        }
    }
}
