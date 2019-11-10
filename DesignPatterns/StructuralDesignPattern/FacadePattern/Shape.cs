//----------------------------------------------------
// <copyright file="Shape.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.StructuralDesignPattern.FacadePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// interface IShape
    /// </summary>
    internal interface IShape
    {
        /// <summary>
        /// function to draw shape when any class implements this
        /// </summary>
        void draw();
    }
}
