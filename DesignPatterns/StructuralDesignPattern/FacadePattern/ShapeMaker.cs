//----------------------------------------------------
// <copyright file="ShapeMaker.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.StructuralDesignPattern.FacadePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ShapeMaker as a class
    /// </summary>
    public class ShapeMaker
    {
        /// <summary>
        /// Private interface field circle
        /// </summary>
        private IShape circle;

        /// <summary>
        /// Private interface field rectangle
        /// </summary>
        private IShape rectangle;

        /// <summary>
        /// Private interface field square
        /// </summary>
        private IShape square;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeMaker"/> class.
        /// </summary>
        public ShapeMaker()
        {
            this.circle = new Circle();
            this.rectangle = new Rectangle();
            this.square = new Square();
        }

        /// <summary>
        /// Function to draw circle
        /// </summary>
        public void drawCircle()
        {
            this.circle.draw();
        }

        /// <summary>
        /// Function to draw square
        /// </summary>
        public void drawSquare()
        {
            this.square.draw();
        }

        /// <summary>
        /// Function to draw rectangle
        /// </summary>
        public void drawRectangle()
        {
            this.rectangle.draw();
        }
    }
}
