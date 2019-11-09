//----------------------------------------------------
// <copyright file="ItemElement.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.VisitorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ItemElement as an interface
    /// </summary>
    internal interface ItemElement
    {
        /// <summary>
        /// Function to accept the visitor
        /// </summary>
        /// <param name="visitor">visitor as a parameter</param>
        /// <returns>returns int</returns>
        int Accept(IShopingCartVisitor visitor);
    }
}
