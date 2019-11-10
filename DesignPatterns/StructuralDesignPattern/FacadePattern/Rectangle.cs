//----------------------------------------------------
// <copyright file="Rectangle.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.StructuralDesignPattern.FacadePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Rectangle implements interface IShape
    /// </summary>
    public class Rectangle : IShape
    {
        /// <summary>
        /// Function to draw rectangle
        /// </summary>
        public void draw()
        {
            Console.WriteLine("Rectangle::draw()");
        }
    }
}
