//----------------------------------------------------
// <copyright file="ShopingCartVisitor.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.VisitorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// interface ShopingCartVisitor contains methods to be implemented
    /// </summary>
    public interface IShopingCartVisitor
    {
        /// <summary>
        /// Function add book
        /// </summary>
        /// <param name="book">book as a parameter</param>
        /// <returns>returns book</returns>
        int Visit(Book book);

        /// <summary>
        /// Function to add fruit
        /// </summary>
        /// <param name="fruit">fruit as a parameter</param>
        /// <returns>returns fruit</returns>
        int Visit(Fruit fruit);
    }
}
